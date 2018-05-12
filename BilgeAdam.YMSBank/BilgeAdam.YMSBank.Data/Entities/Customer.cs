using BilgeAdam.YMSBank.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BilgeAdam.YMSBank.Data.Entities
{
    [Table("Customers", Schema = "Enterprise")]
    public class Customer : EntityBase
    {
        [Required]
        public long PersonId { get; set; }
        [Required]
        [MaxLength(12)]
        public string CustomerNumber { get; set; }
        [ForeignKey(nameof(PersonId))]
        public Person Person { get; set; }
    }
}
