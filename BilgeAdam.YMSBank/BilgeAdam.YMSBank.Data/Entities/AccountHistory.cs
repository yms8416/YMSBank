using BilgeAdam.YMSBank.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilgeAdam.YMSBank.Data.Entities
{
    [Table("AccountHistories", Schema = "Account")]
    public class AccountHistory : EntityBase
    {
        [Required]
        public long HistoryTypeId { get; set; }
        [Required]
        public long AccountId { get; set; }
        [Required]
        public decimal Amount { get; set; }

        [ForeignKey(nameof(AccountId))]
        public virtual Account Account { get; set; }

        [ForeignKey(nameof(HistoryTypeId))]
        public virtual GenericLookup HistoryType { get; set; }
    }
}
