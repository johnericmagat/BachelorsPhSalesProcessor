using BachelorsPhSalesProcessor.Abstractions.Models;

namespace BachelorsPhSalesProcessor.DbSet
{
    public class SalesImageDbSet : ISoftDelete
    {
        public int? Id { get; set; }
        public int? SalesId { get; set; }
        public string? FileName { get; set; }
        public string? Title { get; set; }
        public bool? Primary { get; set; }
        public int? SequenceNumber { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public bool? DeleteFlag { get; set; }
        public virtual SalesDbSet? Sales_Id { get; set; }
    }
}
