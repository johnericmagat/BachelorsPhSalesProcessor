using BachelorsPhSalesProcessor.DbModelBuilder.BrbRaw.SalesRaw;
using BachelorsPhSalesProcessor.DbSet.BrbRaw.SalesRaw;
using Microsoft.EntityFrameworkCore;

namespace BachelorsPhSalesProcessor.Infrastructure.BrbRaw
{
    public class BrbRawDbContext : DbContext
    {
        public BrbRawDbContext(DbContextOptions<BrbRawDbContext> options) : base(options)
        {
        }

        public virtual DbSet<SalesRawDbSet> SalesRaw { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SalesRawModelBuilder.CreateSalesRawModel(modelBuilder);
        }
    }
}
