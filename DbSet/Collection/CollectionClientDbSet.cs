using BachelorsPhSalesProcessor.Abstractions.Models;

namespace BachelorsPhSalesProcessor.DbSet.Collection
{
    public class CollectionClientDbSet : ISoftDelete
    {
        public int? Id { get; set; }
        public int? CollectionId { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Suffix { get; set; }
        public string? Remarks { get; set; }
        public bool? Primary { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public bool? DeleteFlag { get; set; }
        public virtual CollectionDbSet? Collection_Id { get; set; }
    }
}
