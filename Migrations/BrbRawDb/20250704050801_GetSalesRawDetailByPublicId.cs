using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BachelorsPhSalesProcessor.Migrations.BrbRawDb
{
    /// <inheritdoc />
    public partial class GetSalesRawDetailByPublicId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var commandString = @"CREATE OR ALTER PROCEDURE GetSalesRawDetailByPublicId
                                    @PublicId NVARCHAR(50)
                                AS
                                BEGIN
									SELECT * FROM [b'brb_raw'].[sales] WHERE public_id = @PublicId;
                                END
                                ";

            migrationBuilder.Sql(commandString);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP PROCEDURE GetSalesRawDetailByPublicId");
        }
    }
}
