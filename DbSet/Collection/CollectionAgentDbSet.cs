using BachelorsPhSalesProcessor.Abstractions.Models;

namespace BachelorsPhSalesProcessor.DbSet.Collection
{
    public class CollectionAgentDbSet : ISoftDelete
    {
        public int? Id { get; set; }
        public int? CollectionId { get; set; }
        public int? UserId { get; set; }
        public decimal? Percentage { get; set; }
        public decimal? CommissionAmount { get; set; }
        public decimal? PaidAmount { get; set; }
        public decimal? BalanceAmount { get; set; }
        public string? Remarks { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public bool? DeleteFlag { get; set; }
        public bool? Primary { get; set; }
        public virtual CollectionDbSet? Collection_Id { get; set; }
    }
}
