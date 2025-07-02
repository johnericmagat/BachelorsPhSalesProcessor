namespace BachelorsPhSalesProcessor.Dto.Collection
{
    public class CollectionRequestDto
    {
        public int? CollectionId { get; set; }
        public string? CollectionDate { get; set; }
        public string? CollectionReferenceNumber { get; set; }
        public string? CollectionClient { get; set; }
        public int? CollectionSalesId { get; set; }
        public decimal? CollectionCommissionAmount { get; set; }
        public decimal? CollectionPaidAmount { get; set; }
        public decimal? CollectionBalanceAmount { get; set; }
        public decimal? CollectionChangeAmount { get; set; }
        public string? CollectionStatus { get; set; }
        public string? CollectionRemarks { get; set; }
        public string? CollectionNumber { get; set; }
        public int? CollectionAgent { get; set; }
        public List<CollectionClientRequestDto>? CollectionClients { get; set; }
        public List<CollectionAgentRequestDto>? CollectionAgents { get; set; }
        public List<CollectionImageRequestDto>? CollectionImages { get; set; }
        public string? UserName { get; set; }
    }
}
