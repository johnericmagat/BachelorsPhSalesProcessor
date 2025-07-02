using BachelorsPhSalesProcessor.DbSet.Collection;
using Microsoft.EntityFrameworkCore;

namespace BachelorsPhSalesProcessor.DbModelBuilder.Collection
{
    public class CollectionImageModelBuilder
    {
        public static void CreateCollectionImageModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CollectionImageDbSet>(entity =>
            {
                entity.ToTable("CollectionImage");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.CollectionId).HasColumnName("CollectionId").HasColumnType("int").IsRequired();
                entity.Property(e => e.FileName).HasColumnName("FileName").HasColumnType("nvarchar(max)").IsRequired();
                entity.Property(e => e.Title).HasColumnName("Title").HasColumnType("nvarchar(max)").IsRequired();
                entity.Property(e => e.Primary).HasColumnName("Primary").HasColumnType("bit").IsRequired();
                entity.Property(e => e.SequenceNumber).HasColumnName("SequenceNumber").HasColumnType("int").IsRequired();
                entity.Property(e => e.CreateDate).HasColumnName("CreateDate").HasColumnType("datetime").IsRequired();
                entity.Property(e => e.CreateUser).HasColumnName("CreateUser").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.UpdateDate).HasColumnName("UpdateDate").HasColumnType("datetime").IsRequired();
                entity.Property(e => e.UpdateUser).HasColumnName("UpdateUser").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.DeleteFlag).HasColumnName("DeleteFlag").HasColumnType("bit").IsRequired();
                entity.HasOne(f => f.Collection_Id).WithMany(f => f.CollectionImage_CollectionId).HasForeignKey(f => f.CollectionId).OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
