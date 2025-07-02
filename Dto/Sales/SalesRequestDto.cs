namespace BachelorsPhSalesProcessor.Dto
{
    public class SalesRequestDto
    {
        public int? SalesId { get; set; }
        public string? SalesUploadDate { get; set; }
        public string? SalesReserveDate { get; set; }
        public string? SalesReferenceNumber { get; set; }
        public int? SalesDeveloperId { get; set; }
        public string? SalesDeveloper { get; set; }
        public int? SalesProjectId { get; set; }
        public string? SalesProject { get; set; }
        public int? SalesPropertyId { get; set; }
        public string? SalesProperty { get; set; }
        public decimal? SalesTotalContractPrice { get; set; }
        public decimal? SalesCommissionTotalContractPrice { get; set; }
        public decimal? SalesCommissionPercentage { get; set; }
        public decimal? SalesCommissionAmount { get; set; }
        public decimal? SalesPaidAmount { get; set; }
        public decimal? SalesBalanceAmount { get; set; }
        public int? SalesBachelorsOffice { get; set; }
        public string? SalesStatus { get; set; }
        public string? SalesRemarks { get; set; }
        public string? SalesUnitDetailUnitNumber { get; set; }
        public string? SalesUnitDetailPhaseNumber { get; set; }
        public string? SalesUnitDetailBlockNumber { get; set; }
        public string? SalesUnitDetailLotNumber { get; set; }
        public List<SalesClientRequestDto>? SalesClients { get; set; }
        public List<SalesAgentRequestDto>? SalesAgents { get; set; }
        public List<SalesImageRequestDto>? SalesImages { get; set; }
        public List<SalesIncentiveRequestDto>? SalesIncentives { get; set; }
        public List<SalesNoteRequestDto>? SalesNotes { get; set; }
        public string? UserName { get; set; }
    }
}
