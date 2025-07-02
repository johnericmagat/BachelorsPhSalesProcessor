using BachelorsPhSalesProcessor.DbSet.Collection;
using Microsoft.EntityFrameworkCore;

namespace BachelorsPhSalesProcessor.DbModelBuilder.Collection
{
    public class CollectionClientModelBuilder
    {
        public static void CreateCollectionClientModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CollectionClientDbSet>(entity =>
            {
                entity.ToTable("CollectionClient");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.CollectionId).HasColumnName("CollectionId").HasColumnType("int").IsRequired();
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
                entity.HasOne(f => f.Collection_Id).WithMany(f => f.CollectionClient_CollectionId).HasForeignKey(f => f.CollectionId).OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
