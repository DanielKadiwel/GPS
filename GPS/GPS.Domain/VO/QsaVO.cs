using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace GPS.Domain.VO
{
    public class QsaVO
    {
        [Key]
        public int id { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual EmpresaVO Empresa { get; set; }
        public string nome { get; set; }
        public string qual { get; set; }
        public string pais_origem { get; set; }
        public string nome_rep_legal { get; set; }
        public string qual_rep_legal { get; set; }
    }
}
