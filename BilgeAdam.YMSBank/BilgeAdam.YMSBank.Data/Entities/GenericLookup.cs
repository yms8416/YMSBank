using BilgeAdam.YMSBank.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilgeAdam.YMSBank.Data.Entities
{
    [Table("GenericLookups", Schema = "Enterprise")]
    public class GenericLookup : EntityBase
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public long GenericLookupTypeId { get; set; }
        public int? Order { get; set; }

        [ForeignKey(nameof(GenericLookupTypeId))]
        public virtual GenericLookupType GenericLookupType { get; set; }
    }
}
