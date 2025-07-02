using BachelorsPhSalesProcessor.DbSet;
using Microsoft.EntityFrameworkCore;

namespace BachelorsPhSalesProcessor.DbModelBuilder.Sales
{
    public class SalesImageModelBuilder
    {
        public static void CreateSalesImageModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SalesImageDbSet>(entity =>
            {
                entity.ToTable("SalesImage");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.SalesId).HasColumnName("SalesId").HasColumnType("int").IsRequired();
                entity.Property(e => e.FileName).HasColumnName("FileName").HasColumnType("nvarchar(max)").IsRequired();
                entity.Property(e => e.Title).HasColumnName("Title").HasColumnType("nvarchar(max)").IsRequired();
                entity.Property(e => e.Primary).HasColumnName("Primary").HasColumnType("bit").IsRequired();
                entity.Property(e => e.SequenceNumber).HasColumnName("SequenceNumber").HasColumnType("int").IsRequired();
                entity.Property(e => e.CreateDate).HasColumnName("CreateDate").HasColumnType("datetime").IsRequired();
                entity.Property(e => e.CreateUser).HasColumnName("CreateUser").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.UpdateDate).HasColumnName("UpdateDate").HasColumnType("datetime").IsRequired();
                entity.Property(e => e.UpdateUser).HasColumnName("UpdateUser").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.DeleteFlag).HasColumnName("DeleteFlag").HasColumnType("bit").IsRequired();
                entity.HasOne(f => f.Sales_Id).WithMany(f => f.SalesImage_SalesId).HasForeignKey(f => f.SalesId).OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
