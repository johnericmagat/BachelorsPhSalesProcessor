using BachelorsPhSalesProcessor.Abstractions.Models;
using BachelorsPhSalesProcessor.DbModelBuilder.Collection;
using BachelorsPhSalesProcessor.DbModelBuilder.Sales;
using BachelorsPhSalesProcessor.DbSet;
using BachelorsPhSalesProcessor.DbSet.Collection;
using Microsoft.EntityFrameworkCore;

namespace BachelorsPhSalesProcessor.Infrastructure
{
    public class SalesDbContext : DbContext
    {
        public SalesDbContext(DbContextOptions<SalesDbContext> options) : base(options)
        {
        }

        public virtual DbSet<SalesDbSet> Sales { get; set; }
        public virtual DbSet<SalesClientDbSet> SalesClients { get; set; }
        public virtual DbSet<SalesAgentDbSet> SalesAgents { get; set; }
        public virtual DbSet<SalesImageDbSet> SalesImages { get; set; }
        public virtual DbSet<SalesIncentiveDbSet> SalesIncentives { get; set; }
        public virtual DbSet<SalesNoteDbSet> SalesNotes { get; set; }
        public virtual DbSet<CollectionDbSet> Collections { get; set; }
        public virtual DbSet<CollectionClientDbSet> CollectionClients { get; set; }
        public virtual DbSet<CollectionAgentDbSet> CollectionAgents { get; set; }
        public virtual DbSet<CollectionImageDbSet> CollectionImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SalesModelBuilder.CreateSalesModel(modelBuilder);
            SalesClientModelBuilder.CreateSalesClientModel(modelBuilder);
            SalesAgentModelBuilder.CreateSalesAgentModel(modelBuilder);
            SalesImageModelBuilder.CreateSalesImageModel(modelBuilder);
            SalesIncentiveModelBuilder.CreateSalesIncentiveModel(modelBuilder);
            SalesNoteModelBuilder.CreateSalesNoteModel(modelBuilder);
            CollectionModelBuilder.CreateCollectionModel(modelBuilder);
            CollectionClientModelBuilder.CreateCollectionClientModel(modelBuilder);
            CollectionAgentModelBuilder.CreateCollectionAgentModel(modelBuilder);
            CollectionImageModelBuilder.CreateCollectionImageModel(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries().Where(e => e.State == EntityState.Deleted);

            foreach (var entry in entries)
            {
                var entity = entry.Entity;

                if (entry.State == EntityState.Deleted && entity is ISoftDelete)
                {
                    entry.State = EntityState.Modified;
                    entity.GetType().GetProperty("DeleteFlag")!.SetValue(entity, true);
                }
            }

            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
    }
}
