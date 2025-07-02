using BachelorsPhSalesProcessor.DbSet;
using Microsoft.EntityFrameworkCore;

namespace BachelorsPhSalesProcessor.DbModelBuilder.Collection
{
    public class CollectionModelBuilder
    {
        public static void CreateCollectionModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CollectionDbSet>(entity =>
            {
                entity.ToTable("Collection");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.CollectionDate).HasColumnName("CollectionDate").HasColumnType("datetime").IsRequired();
                entity.Property(e => e.ReferenceNumber).HasColumnName("ReferenceNumber").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.Client).HasColumnName("Client").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.SalesId).HasColumnName("SalesId").HasColumnType("int").IsRequired();
                entity.Property(e => e.CommissionAmount).HasColumnName("CommissionAmount").HasColumnType("decimal(18, 5)").IsRequired();
                entity.Property(e => e.PaidAmount).HasColumnName("PaidAmount").HasColumnType("decimal(18, 5)").IsRequired();
                entity.Property(e => e.BalanceAmount).HasColumnName("BalanceAmount").HasColumnType("decimal(18, 5)").IsRequired();
                entity.Property(e => e.ChangeAmount).HasColumnName("ChangeAmount").HasColumnType("decimal(18, 5)").IsRequired();
                entity.Property(e => e.Status).HasColumnName("Status").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.Remarks).HasColumnName("Remarks").HasColumnType("nvarchar(max)").IsRequired();
                entity.Property(e => e.CreateDate).HasColumnName("CreateDate").HasColumnType("datetime").IsRequired();
                entity.Property(e => e.CreateUser).HasColumnName("CreateUser").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.UpdateDate).HasColumnName("UpdateDate").HasColumnType("datetime").IsRequired();
                entity.Property(e => e.UpdateUser).HasColumnName("UpdateUser").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.DeleteFlag).HasColumnName("DeleteFlag").HasColumnType("bit").IsRequired();
                entity.Property(e => e.CollectionNumber).HasColumnName("CollectionNumber").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.Agent).HasColumnName("Agent").HasColumnType("int").IsRequired();
                entity.HasOne(f => f.Sales_Id).WithMany(f => f.Collection_SalesId).HasForeignKey(f => f.SalesId).OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
