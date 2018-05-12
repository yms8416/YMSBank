using BilgeAdam.YMSBank.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BilgeAdam.YMSBank.Data.Entities
{
    [Table("Roles", Schema = "Enterprise")]
    public class Role : EntityBase
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
