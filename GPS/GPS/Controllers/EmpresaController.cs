using GPS.Domain.VO;
using GPS.Repository.Interfaces;
using Newtonsoft.Json;
using System.Web.Mvc;

namespace GPS.Controllers
{
    public class EmpresaController : Controller
    {
        private readonly IGpsRepository _gpsRepository;

        string Baseurl = "https://www.receitaws.com.br/v1/"; //Hardcode

        public EmpresaController(IGpsRepository gpsRepository)
        {
            _gpsRepository = gpsRepository;
        }

        public string GetEmpresasWService(string cnpj)
        {
            EmpresaVO empresa = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);

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

        public string SaveEmpresas(string empresa)
        {
            string output = "";
            try
            {
                ICollection<EmpresaVO> Empresas = JsonConvert.DeserializeObject<ICollection<EmpresaVO>>(empresa);

                EmpresaVO empr = Empresas.ToArray()[0];

                EmpresaVO exists = _gpsRepository.GetEmpresasByCnpj(empr.cnpj);

                if (exists != null)
                {
                    empr.Id = exists.Id;

                    _gpsRepository.Update(empr);
                    _gpsRepository.SaveChancesAsync();

                    output = String.Format("Empresa: {0} \n Cnpj: {1} \n Atualizada com Sucesso!", empr.nome, empr.cnpj);
                    output = JsonConvert.SerializeObject(output);
                }
                else
                {
                    _gpsRepository.Add(empr);
                    _gpsRepository.SaveChancesAsync();

                    output = String.Format("Empresa: {0} \n Cnpj: {1} \n Adicionada a Base com Sucesso!", empr.nome, empr.cnpj);
                    output = JsonConvert.SerializeObject(output);
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
