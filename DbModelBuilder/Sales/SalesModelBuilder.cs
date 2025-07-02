using BachelorsPhSalesProcessor.DbSet;
using Microsoft.EntityFrameworkCore;

namespace BachelorsPhSalesProcessor.DbModelBuilder.Sales
{
    public class SalesModelBuilder
    {
        public static void CreateSalesModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SalesDbSet>(entity =>
            {
                entity.ToTable("Sales");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.UploadDate).HasColumnName("UploadDate").HasColumnType("datetime").IsRequired();
                entity.Property(e => e.ReserveDate).HasColumnName("ReserveDate").HasColumnType("datetime").IsRequired();
                entity.Property(e => e.ReferenceNumber).HasColumnName("ReferenceNumber").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.DeveloperId).HasColumnName("DeveloperId").HasColumnType("int").IsRequired();
                entity.Property(e => e.ProjectId).HasColumnName("ProjectId").HasColumnType("int").IsRequired();
                entity.Property(e => e.PropertyId).HasColumnName("PropertyId").HasColumnType("int").IsRequired();
                entity.Property(e => e.TotalContractPrice).HasColumnName("TotalContractPrice").HasColumnType("decimal(18, 5)").IsRequired();
                entity.Property(e => e.CommissionTotalContractPrice).HasColumnName("CommissionTotalContractPrice").HasColumnType("decimal(18, 5)").IsRequired();
                entity.Property(e => e.CommissionPercentage).HasColumnName("CommissionPercentage").HasColumnType("decimal(18, 5)").IsRequired();
                entity.Property(e => e.CommissionAmount).HasColumnName("CommissionAmount").HasColumnType("decimal(18, 5)").IsRequired();
                entity.Property(e => e.PaidAmount).HasColumnName("PaidAmount").HasColumnType("decimal(18, 5)").IsRequired();
                entity.Property(e => e.BalanceAmount).HasColumnName("BalanceAmount").HasColumnType("decimal(18, 5)").IsRequired();
                entity.Property(e => e.BachelorsOffice).HasColumnName("BachelorsOffice").HasColumnType("int").IsRequired();
                entity.Property(e => e.Status).HasColumnName("Status").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.Remarks).HasColumnName("Remarks").HasColumnType("nvarchar(max)").IsRequired();
                entity.Property(e => e.CreateDate).HasColumnName("CreateDate").HasColumnType("datetime").IsRequired();
                entity.Property(e => e.CreateUser).HasColumnName("CreateUser").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.UpdateDate).HasColumnName("UpdateDate").HasColumnType("datetime").IsRequired();
                entity.Property(e => e.UpdateUser).HasColumnName("UpdateUser").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.DeleteFlag).HasColumnName("DeleteFlag").HasColumnType("bit").IsRequired();
                entity.Property(e => e.UnitDetailUnitNumber).HasColumnName("UnitDetailUnitNumber").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.UnitDetailPhaseNumber).HasColumnName("UnitDetailPhaseNumber").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.UnitDetailBlockNumber).HasColumnName("UnitDetailBlockNumber").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.UnitDetailLotNumber).HasColumnName("UnitDetailLotNumber").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.Developer).HasColumnName("Developer").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.Project).HasColumnName("Project").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.Property).HasColumnName("Property").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.Client).HasColumnName("Client").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.Agent).HasColumnName("Agent").HasColumnType("int").IsRequired();
                entity.Property(e => e.ApprovedDate).HasColumnName("ApprovedDate").HasColumnType("datetime");
                entity.Property(e => e.ApprovedBy).HasColumnName("ApprovedBy").HasColumnType("int");
                entity.Property(e => e.ConfirmedDate).HasColumnName("ConfirmedDate").HasColumnType("datetime");
                entity.Property(e => e.ConfirmedBy).HasColumnName("ConfirmedBy").HasColumnType("int");
                entity.Property(e => e.CompletedDate).HasColumnName("CompletedDate").HasColumnType("datetime");
                entity.Property(e => e.CompletedBy).HasColumnName("CompletedBy").HasColumnType("int");
                entity.Property(e => e.CancelledDate).HasColumnName("CancelledDate").HasColumnType("datetime");
                entity.Property(e => e.CancelledBy).HasColumnName("CancelledBy").HasColumnType("int");
            });
        }
    }
}
