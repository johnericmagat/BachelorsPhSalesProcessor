namespace BachelorsPhSalesProcessor.Dto.Collection
{
    public class CollectionAgentRequestDto
    {
        public int? CollectionAgentId { get; set; }
        public int? CollectionAgentCollectionId { get; set; }
        public int? CollectionAgentUserId { get; set; }
        public decimal? CollectionAgentPercentage { get; set; }
        public decimal? CollectionAgentCommissionAmount { get; set; }
        public decimal? CollectionAgentPaidAmount { get; set; }
        public decimal? CollectionAgentBalanceAmount { get; set; }
        public string? CollectionAgentRemarks { get; set; }
        public bool? CollectionAgentPrimary { get; set; }
    }
}
