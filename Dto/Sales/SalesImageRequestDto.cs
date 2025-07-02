namespace BachelorsPhSalesProcessor.Dto
{
    public class SalesImageRequestDto
    {
        public int? SalesImageId { get; set; }
        public int? SalesImageSalesId { get; set; }
        public string? SalesImageFileName { get; set; }
        public string? SalesImageTitle { get; set; }
        public bool? SalesImagePrimary { get; set; }
        public int? SalesImageSequenceNumber { get; set; }
    }
}
