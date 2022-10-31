using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace GPS.Domain.VO
{
    public class BillingVO
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("EmpresaId")]
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual EmpresaVO Empresa { get; set; }
        public Boolean free { get; set; }
        public Boolean database { get; set; }
    }
}
