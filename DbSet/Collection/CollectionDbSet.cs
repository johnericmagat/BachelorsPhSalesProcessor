using BachelorsPhSalesProcessor.Abstractions.Models;
using BachelorsPhSalesProcessor.DbSet.Collection;

namespace BachelorsPhSalesProcessor.DbSet
{
    public class CollectionDbSet : ISoftDelete
    {
        public int? Id { get; set; }
        public DateTime? CollectionDate { get; set; }
        public string? ReferenceNumber { get; set; }
        public string? Client { get; set; }
        public int? SalesId { get; set; }
        public decimal? CommissionAmount { get; set; }
        public decimal? PaidAmount { get; set; }
        public decimal? BalanceAmount { get; set; }
        public decimal? ChangeAmount { get; set; }
        public string? Status { get; set; }
        public string? Remarks { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public bool? DeleteFlag { get; set; }
        public string? CollectionNumber { get; set; }
        public int? Agent { get; set; }
        public virtual SalesDbSet? Sales_Id { get; set; }
        public virtual ICollection<CollectionClientDbSet>? CollectionClient_CollectionId { get; set; }
        public virtual ICollection<CollectionAgentDbSet>? CollectionAgent_CollectionId { get; set; }
        public virtual ICollection<CollectionImageDbSet>? CollectionImage_CollectionId { get; set; }
    }
}
