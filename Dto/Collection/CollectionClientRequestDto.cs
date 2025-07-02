namespace BachelorsPhSalesProcessor.Dto.Collection
{
    public class CollectionClientRequestDto
    {
        public int? CollectionClientId { get; set; }
        public int? CollectionClientCollectionId { get; set; }
        public string? CollectionClientFirstName { get; set; }
        public string? CollectionClientMiddleName { get; set; }
        public string? CollectionClientLastName { get; set; }
        public string? CollectionClientSuffix { get; set; }
        public string? CollectionClientRemarks { get; set; }
        public bool? CollectionClientPrimary { get; set; }
    }
}
