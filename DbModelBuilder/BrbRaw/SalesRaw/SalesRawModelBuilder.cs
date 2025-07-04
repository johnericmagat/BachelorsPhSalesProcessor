using BachelorsPhSalesProcessor.DbSet.BrbRaw.SalesRaw;
using Microsoft.EntityFrameworkCore;

namespace BachelorsPhSalesProcessor.DbModelBuilder.BrbRaw.SalesRaw
{
    public class SalesRawModelBuilder
    {
        public static void CreateSalesRawModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SalesRawDbSet>(entity =>
            {
                entity.ToTable("[b'brb_raw'].[sales]");
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Public_Id).HasColumnName("public_id").HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
                entity.Property(e => e.ReservationDate).HasColumnName("reservationdate").HasColumnType("nvarchar").HasMaxLength(20).IsRequired();
                entity.Property(e => e.BuyerName).HasColumnName("buyername").HasColumnType("nvarchar").HasMaxLength(250).IsRequired();
                entity.Property(e => e.TotalContractPrice).HasColumnName("totalcontractprice").HasColumnType("float").IsRequired();
                entity.Property(e => e.Details).HasColumnName("details").HasColumnType("nvarchar(max)").HasMaxLength(100).IsRequired();
                entity.Property(e => e.Status).HasColumnName("status").HasColumnType("nvarchar").HasMaxLength(10).IsRequired();
                entity.Property(e => e.Prprty_Id).HasColumnName("prprty_id").HasColumnType("int");
                entity.Property(e => e.AcceptanceProgress).HasColumnName("acceptanceprogress").HasColumnType("float").IsRequired();
                entity.Property(e => e.Remarks).HasColumnName("remarks").HasColumnType("nvarchar(max)");
                entity.Property(e => e.CommisionableTcp).HasColumnName("commisionabletcp").HasColumnType("float").IsRequired();
                entity.Property(e => e.CommisionPercentage).HasColumnName("commisionpercentage").HasColumnType("float").IsRequired();
                entity.Property(e => e.CommisionTotalAmount).HasColumnName("commisiontotalamount").HasColumnType("float").IsRequired();
                entity.Property(e => e.BrokerIncentive).HasColumnName("brokerincentive").HasColumnType("float").IsRequired();
                entity.Property(e => e.Acct_Receivables_Rep_Flag).HasColumnName("acct_receivables_rep_flag").HasColumnType("nchar").HasMaxLength(1).IsRequired();
                entity.Property(e => e.Acct_Receivables_Rep_Entity_Flag).HasColumnName("acct_receivables_rep_entity_flag").HasColumnType("nchar").HasMaxLength(1).IsRequired();
                entity.Property(e => e.Create_Date).HasColumnName("create_date").HasColumnType("datetime2(0)").IsRequired();
                entity.Property(e => e.Create_User).HasColumnName("create_user").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.Update_Date).HasColumnName("update_date").HasColumnType("datetime2(0)").IsRequired();
                entity.Property(e => e.Update_User).HasColumnName("update_user").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                entity.Property(e => e.Delete_Flag).HasColumnName("delete_flag").HasColumnType("nchar").HasMaxLength(1).IsRequired();
            });
        }
    }
}
