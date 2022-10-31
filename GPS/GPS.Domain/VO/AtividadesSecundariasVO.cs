using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace GPS.Domain.VO
{
    public class AtividadesSecundariasVO
    {
        [Key]
        public int id { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual EmpresaVO Empresa { get; set; }
        public string code { get; set; }
        public string text { get; set; }
    }
}
