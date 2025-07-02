namespace BachelorsPhSalesProcessor.Dto
{
    public class SalesClientRequestDto
    {
        public int? SalesClientId { get; set; }
        public int? SalesClientSalesId { get; set; }
        public string? SalesClientFirstName { get; set; }
        public string? SalesClientMiddleName { get; set; }
        public string? SalesClientLastName { get; set; }
        public string? SalesClientSuffix { get; set; }
        public string? SalesClientRemarks { get; set; }
        public bool? SalesClientPrimary { get; set; }
    }
}
