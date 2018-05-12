using BilgeAdam.YMSBank.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BilgeAdam.YMSBank.Data.Entities
{
    [Table("Transfers", Schema = "Finance")]
    public class Transfer : EntityBase
    {
        [Required]
        public long FromId { get; set; }
        [Required]
        public long ToId { get; set; }
        [Required]
        public decimal Amount { get; set; }

        [ForeignKey(nameof(FromId))]
        public virtual Account From { get; set; }
        [ForeignKey(nameof(ToId))]
        public virtual Account To { get; set; }
    }
}
