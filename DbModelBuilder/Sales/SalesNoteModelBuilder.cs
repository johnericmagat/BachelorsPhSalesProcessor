using BachelorsPhSalesProcessor.DbSet;
using Microsoft.EntityFrameworkCore;

namespace BachelorsPhSalesProcessor.DbModelBuilder.Sales
{
    public class SalesNoteModelBuilder
    {
        public static void CreateSalesNoteModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SalesNoteDbSet>(entity =>
            {
                entity.ToTable("SalesNote");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.SalesId).HasColumnName("SalesId").HasColumnType("int").IsRequired();
                entity.Property(e => e.Description).HasColumnName("Description").HasColumnType("nvarchar(max)").IsRequired();
                entity.Property(e => e.CreateDate).HasColumnName("CreateDate").HasColumnType("datetime").IsRequired();
                entity.Property(e => e.CreateUser).HasColumnName("CreateUser").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.UpdateDate).HasColumnName("UpdateDate").HasColumnType("datetime").IsRequired();
                entity.Property(e => e.UpdateUser).HasColumnName("UpdateUser").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.DeleteFlag).HasColumnName("DeleteFlag").HasColumnType("bit").IsRequired();
                entity.HasOne(f => f.Sales_Id).WithMany(f => f.SalesNote_SalesId).HasForeignKey(f => f.SalesId).OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
