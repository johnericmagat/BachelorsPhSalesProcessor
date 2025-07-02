namespace BachelorsPhSalesProcessor.Dto.Collection
{
    public class CollectionImageRequestDto
    {
        public int? CollectionImageId { get; set; }
        public int? CollectionImageCollectionId { get; set; }
        public string? CollectionImageFileName { get; set; }
        public string? CollectionImageTitle { get; set; }
        public bool? CollectionImagePrimary { get; set; }
        public int? CollectionImageSequenceNumber { get; set; }
    }
}
