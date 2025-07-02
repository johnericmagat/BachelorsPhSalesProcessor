namespace BachelorsPhSalesProcessor.Abstractions.Models
{
    public interface ISoftDelete
    {
        public bool? DeleteFlag { get; set; }
    }
}
