using BachelorsPhSalesProcessor.DbSet;
using Microsoft.EntityFrameworkCore;

namespace BachelorsPhSalesProcessor.DbModelBuilder.Sales
{
    public class SalesAgentModelBuilder
    {
        public static void CreateSalesAgentModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SalesAgentDbSet>(entity =>
            {
                entity.ToTable("SalesAgent");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.SalesId).HasColumnName("SalesId").HasColumnType("int").IsRequired();
                entity.Property(e => e.UserId).HasColumnName("UserId").HasColumnType("int").IsRequired();
                entity.Property(e => e.Percentage).HasColumnName("Percentage").HasColumnType("decimal(18, 5)").IsRequired();
                entity.Property(e => e.CommissionAmount).HasColumnName("CommissionAmount").HasColumnType("decimal(18, 5)").IsRequired();
                entity.Property(e => e.PaidAmount).HasColumnName("PaidAmount").HasColumnType("decimal(18, 5)").IsRequired();
                entity.Property(e => e.BalanceAmount).HasColumnName("BalanceAmount").HasColumnType("decimal(18, 5)").IsRequired();
                entity.Property(e => e.Remarks).HasColumnName("Remarks").HasColumnType("nvarchar(max)").IsRequired();
                entity.Property(e => e.CreateDate).HasColumnName("CreateDate").HasColumnType("datetime").IsRequired();
                entity.Property(e => e.CreateUser).HasColumnName("CreateUser").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.UpdateDate).HasColumnName("UpdateDate").HasColumnType("datetime").IsRequired();
                entity.Property(e => e.UpdateUser).HasColumnName("UpdateUser").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.DeleteFlag).HasColumnName("DeleteFlag").HasColumnType("bit").IsRequired();
                entity.Property(e => e.Primary).HasColumnName("Primary").HasColumnType("bit").IsRequired();
                entity.HasOne(f => f.Sales_Id).WithMany(f => f.SalesAgent_SalesId).HasForeignKey(f => f.SalesId).OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
