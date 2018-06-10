using BilgeAdam.YMSBank.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BilgeAdam.YMSBank.Data.Entities
{
    [Table("Menus", Schema = "Enterprise")]
    public class Menu : EntityBase
    {
        [Required]
        [MaxLength(50)]
        public string Text { get; set; }
        [Required]
        [MaxLength(50)]
        public string Action { get; set; }
        [Required]
        [MaxLength(50)]
        public string Controller { get; set; }
        [MaxLength(50)]
        public string Area { get; set; }
        public long? ModuleId { get; set; }
        public long? ParentId { get; set; }
        [ForeignKey(nameof(ParentId))]
        public virtual Menu Parent { get; set; }
        [ForeignKey(nameof(ModuleId))]
        public virtual Module Module { get; set; }
    }
}
