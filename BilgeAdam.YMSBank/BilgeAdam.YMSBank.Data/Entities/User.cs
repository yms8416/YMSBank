using BilgeAdam.YMSBank.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BilgeAdam.YMSBank.Data.Entities
{
    [Table("Users", Schema = "Enterprise")]
    public class User : EntityBase
    {
        [Required]
        [MaxLength(100)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(64)]
        public string Password { get; set; }
        [Required]
        public long PersonId { get; set; }
        [Required]
        public string IsLocked { get; set; }

        [ForeignKey(nameof(PersonId))]
        public virtual Person Person { get; set; }
    }
}
