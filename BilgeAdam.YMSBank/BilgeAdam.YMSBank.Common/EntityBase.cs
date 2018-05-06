using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BilgeAdam.YMSBank.Common
{
    public abstract class EntityBase
    {
        public EntityBase()
        {
            IsActive = true;
        }
        [Key]
        public long Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
    }
}
