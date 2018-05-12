using BilgeAdam.YMSBank.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BilgeAdam.YMSBank.Data.Entities
{
    [Table("Employees", Schema = "Enterprise")]
    public class Employee : EntityBase
    {
        [Required]
        public long PersonId { get; set; }
        [Required]
        public long DepartmentId { get; set; }
        public long? ManagerId { get; set; }

        [ForeignKey(nameof(PersonId))]
        public virtual Person Person { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        public virtual GenericLookup Department { get; set; }
        [ForeignKey(nameof(ManagerId))]
        public virtual Employee Manager { get; set; }
    }
}
