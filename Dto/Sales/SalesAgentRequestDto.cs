namespace BachelorsPhSalesProcessor.Dto
{
    public class SalesAgentRequestDto
    {
        public int? SalesAgentId { get; set; }
        public int? SalesAgentSalesId { get; set; }
        public int? SalesAgentUserId { get; set; }
        public decimal? SalesAgentPercentage { get; set; }
        public decimal? SalesAgentCommissionAmount { get; set; }
        public decimal? SalesAgentPaidAmount { get; set; }
        public decimal? SalesAgentBalanceAmount { get; set; }
        public string? SalesAgentRemarks { get; set; }
        public bool? SalesAgentPrimary { get; set; }
    }
}
