using BachelorsPhSalesProcessor.DbSet;
using Microsoft.EntityFrameworkCore;

namespace BachelorsPhSalesProcessor.DbModelBuilder.Sales
{
    public class SalesClientModelBuilder
    {
        public static void CreateSalesClientModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SalesClientDbSet>(entity =>
            {
                entity.ToTable("SalesClient");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.SalesId).HasColumnName("SalesId").HasColumnType("int").IsRequired();
                entity.Property(e => e.FirstName).HasColumnName("FirstName").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.MiddleName).HasColumnName("MiddleName").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.LastName).HasColumnName("LastName").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.Suffix).HasColumnName("Suffix").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.Remarks).HasColumnName("Remarks").HasColumnType("nvarchar(max)").IsRequired();
                entity.Property(e => e.Primary).HasColumnName("Primary").HasColumnType("bit").IsRequired();
                entity.Property(e => e.CreateDate).HasColumnName("CreateDate").HasColumnType("datetime").IsRequired();
                entity.Property(e => e.CreateUser).HasColumnName("CreateUser").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.UpdateDate).HasColumnName("UpdateDate").HasColumnType("datetime").IsRequired();
                entity.Property(e => e.UpdateUser).HasColumnName("UpdateUser").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.DeleteFlag).HasColumnName("DeleteFlag").HasColumnType("bit").IsRequired();
                entity.HasOne(f => f.Sales_Id).WithMany(f => f.SalesClient_SalesId).HasForeignKey(f => f.SalesId).OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
