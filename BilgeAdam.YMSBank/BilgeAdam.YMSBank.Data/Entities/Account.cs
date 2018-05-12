using BilgeAdam.YMSBank.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BilgeAdam.YMSBank.Data.Entities
{
    [Table("Accounts", Schema = "Account")]
    public class Account : EntityBase
    {
        [Required]
        public long OwnerId { get; set; }
        [Required]
        public long CurrencyTypeId { get; set; }
        [Required]
        public decimal Amount { get; set; }

        [ForeignKey(nameof(OwnerId))]
        public virtual Customer Owner { get; set; }
    }
}
