using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BachelorsPhSalesProcessor.Migrations.BrbRawDb
{
    /// <inheritdoc />
    public partial class GetSalesRawSP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var commandString = @"CREATE OR ALTER PROCEDURE GetSalesRaw
                            AS
                            BEGIN

                           SELECT
								id AS Id,
								public_id AS Public_Id,
								reservationdate AS ReservationDate,
								buyername AS BuyerName,
								totalcontractprice AS TotalContractPrice,
								details AS Details,
								status AS Status,
								prprty_id AS Prprty_Id,
								acceptanceprogress AS AcceptanceProgress,
								remarks AS Remarks,
								commisionabletcp AS CommisionableTcp,
								commisionpercentage AS CommisionPercentage,
								commisiontotalamount AS CommisionTotalAmount,
								brokerincentive AS BrokerIncentive,
								acct_receivables_rep_flag AS Acct_Receivables_Rep_Flag,
								acct_receivables_rep_entity_flag AS Acct_Receivables_Rep_Entity_Flag,
								create_date AS Create_Date,
								create_user AS Create_User,
								update_date AS Update_Date,
								update_user AS Update_User,
								delete_flag AS Delete_Flag
						FROM
								[b'brb_raw'].[sales]
						ORDER BY
								reservationdate asc;
                END
                ";

            migrationBuilder.Sql(commandString);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP PROCEDURE GetSalesRaw");
        }
    }
}
