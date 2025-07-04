namespace BachelorsPhSalesProcessor.Dto.BrbRaw.Sales
{
    public class SalesRawResponseDto
    {
        public int? Id { get; set; }
        public string? Public_Id { get; set; }
        public string? ReservationDate { get; set; }
        public string? BuyerName { get; set; }
        public decimal? TotalContractPrice { get; set; }
        public string? Details { get; set; }
        public string? Status { get; set; }
        public int? Prprty_Id { get; set; }
        public decimal? AcceptanceProgress { get; set; }
        public string? Remarks { get; set; }
        public decimal? CommisionableTcp { get; set; }
        public decimal? CommisionPercentage { get; set; }
        public decimal? CommisionTotalAmount { get; set; }
        public decimal? BrokerIncentive { get; set; }
        public string? Acct_Receivables_Rep_Flag { get; set; }
        public string? Acct_Receivables_Rep_Entity_Flag { get; set; }
        public DateTime? Create_Date { get; set; }
        public string? Create_User { get; set; }
        public DateTime? Update_Date { get; set; }
        public string? Update_User { get; set; }
        public string? Delete_Flag { get; set; }
    }
}
