using BilgeAdam.YMSBank.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BilgeAdam.YMSBank.Data.Entities
{
    [Table("UserRoles", Schema = "Enterprise")]
    public class UserRole : EntityBase
    {
        [Required]
        public long UserId { get; set; }
        [Required]
        public long RoleId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }
        [ForeignKey(nameof(RoleId))]
        public virtual Role Role { get; set; }
    }
}
