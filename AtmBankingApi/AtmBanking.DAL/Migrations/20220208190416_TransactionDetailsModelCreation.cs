using Microsoft.EntityFrameworkCore.Migrations;

namespace AtmBanking.DAL.Migrations
{
    public partial class TransactionDetailsModelCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "transactionDetails",
                columns: table => new
                {
                    transactionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountId = table.Column<int>(type: "int", nullable: false),
                    withdrawal = table.Column<int>(type: "int", nullable: false),
                    deposit = table.Column<int>(type: "int", nullable: false),
                    transfer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transaction_amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transactionDetails", x => x.transactionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "transactionDetails");
        }
    }
}
