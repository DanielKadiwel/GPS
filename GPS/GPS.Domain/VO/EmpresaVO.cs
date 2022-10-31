using System.ComponentModel.DataAnnotations;

namespace GPS.Domain.VO
{
    public class EmpresaVO
    {
        [Key]
        public int Id { get; set; }
        public string status { get; set; }
        public string message { get; set; }
        public BillingVO billing { get; set; }
        public string cnpj { get; set; }
        public string tipo { get; set; }
        public string abertura { get; set; }
        public string nome { get; set; }
        public string fantasia { get; set; }
        public ICollection<AtividadePrincipalVO> atividade_principais { get; set; }
        public ICollection<AtividadesSecundariasVO> atividades_secundarias { get; set; }
        public string natureza_juridica { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string cep { get; set; }
        public string bairro { get; set; }
        public string municipio { get; set; }
        public string uf { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string efr { get; set; }
        public string situacao { get; set; }
        public string data_situacao { get; set; }
        public string motivo_situacao { get; set; }
        public string situacao_especial { get; set; }
        public string data_situacao_especial { get; set; }
        public string capital_social { get; set; }
        public ICollection<QsaVO> qsas { get; set; }
    }
}
