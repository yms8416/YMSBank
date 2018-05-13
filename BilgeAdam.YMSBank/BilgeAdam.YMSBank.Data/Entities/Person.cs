using BilgeAdam.YMSBank.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilgeAdam.YMSBank.Data.Entities
{
    [Table("People", Schema = "Enterprise")]
    public class Person : EntityBase
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(14)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(60)]
        public string EMail { get; set; }
    }
}
