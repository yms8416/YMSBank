using BilgeAdam.YMSBank.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilgeAdam.YMSBank.Data.Entities
{
    [Table("Modules", Schema = "Enterprise")]
    public class Module : EntityBase
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
