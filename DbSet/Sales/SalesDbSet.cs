using BachelorsPhSalesProcessor.Abstractions.Models;

namespace BachelorsPhSalesProcessor.DbSet
{
    public class SalesDbSet : ISoftDelete
    {
        public int? Id { get; set; }
        public DateTime? UploadDate { get; set; }
        public DateTime? ReserveDate { get; set; }
        public string? ReferenceNumber { get; set; }
        public int? DeveloperId { get; set; }
        public int? ProjectId { get; set; }
        public int? PropertyId { get; set; }
        public decimal? TotalContractPrice { get; set; }
        public decimal? CommissionTotalContractPrice { get; set; }
        public decimal? CommissionPercentage { get; set; }
        public decimal? CommissionAmount { get; set; }
        public decimal? PaidAmount { get; set; }
        public decimal? BalanceAmount { get; set; }
        public int? BachelorsOffice { get; set; }
        public string? Status { get; set; }
        public string? Remarks { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public bool? DeleteFlag { get; set; }
        public string? UnitDetailUnitNumber { get; set; }
        public string? UnitDetailPhaseNumber { get; set; }
        public string? UnitDetailBlockNumber { get; set; }
        public string? UnitDetailLotNumber { get; set; }
        public string? Developer { get; set; }
        public string? Project { get; set; }
        public string? Property { get; set; }
        public string? Client { get; set; }
        public int? Agent { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? ConfirmedDate { get; set; }
        public int? ConfirmedBy { get; set; }
        public DateTime? CompletedDate { get; set; }
        public int? CompletedBy { get; set; }
        public DateTime? CancelledDate { get; set; }
        public int? CancelledBy { get; set; }
        public virtual ICollection<SalesClientDbSet>? SalesClient_SalesId { get; set; }
        public virtual ICollection<SalesAgentDbSet>? SalesAgent_SalesId { get; set; }
        public virtual ICollection<SalesImageDbSet>? SalesImage_SalesId { get; set; }
        public virtual ICollection<SalesIncentiveDbSet>? SalesIncentive_SalesId { get; set; }
        public virtual ICollection<SalesNoteDbSet>? SalesNote_SalesId { get; set; }
        public virtual ICollection<CollectionDbSet>? Collection_SalesId { get; set; }
    }
}
