using BilgeAdam.YMSBank.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilgeAdam.YMSBank.Data.Entities
{
    [Table("GenericLookupTypes", Schema = "Enterprise")]
    public class GenericLookupType : EntityBase
    {
        [Required]
        public string Name { get; set; }
    }
}
