using GPS.Domain.VO;
using GPS.Repository.Interfaces;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;

namespace GPS.Controllers
{
    public class EmpresaController : Controller
    {
        private readonly IGpsRepository _gpsRepository;

        string baseUrl = "https://www.receitaws.com.br/v1/"; //Hardcode

        public EmpresaController(IGpsRepository gpsRepository)
        {
            _gpsRepository = gpsRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

        public string GetEmpresas(string cnpj)
        {
            EmpresaVO empresa = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);

                //HTTP GET
                var responseTask = client.GetAsync("cnpj/" + cnpj);
                responseTask.Wait();
                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadFromJsonAsync<EmpresaVO>();
                    readTask.Wait();
                    empresa = readTask.Result;
                }
                else
                {
                    empresa = null;
                }

                List<EmpresaVO> list = new List<EmpresaVO>();
                list.Add(empresa);
                ICollection<EmpresaVO> collection = list;

                return JsonConvert.SerializeObject(collection);
            }
        }

        public string Save(string empresa)
        {
            string output = "";
            try
            {
                ICollection<EmpresaVO> Empresas = JsonConvert.DeserializeObject<ICollection<EmpresaVO>>(empresa);

                EmpresaVO empr = Empresas.ToArray()[0];

                EmpresaVO exists = _gpsRepository.GeyByCNPJ(empr.cnpj);

                if (exists != null)
                {
                    foreach (var x in Empresas)
                    {
                        empr.Id = exists.Id;

                        _gpsRepository.Update(empr);
                        _gpsRepository.SaveChancesAsync();

                        output = String.Format("Cnpj: {0} \n Atualizado com Sucesso!", empr.cnpj);
                        output = JsonConvert.SerializeObject(output);
                    }
                }
                else
                {
                    foreach (var x in Empresas)
                    {
                        _gpsRepository.Add(empr);
                        _gpsRepository.SaveChancesAsync();
                        output = String.Format("Cnpj: {0} \n Adicionada a Base com Sucesso!", empr.cnpj);
                        output = JsonConvert.SerializeObject(output);
                    }
                }

                return output;
            }
            catch (System.Exception ex)
            {
                string msg = ex.Message.ToString();

                return null;
            }
        }
    }
}
