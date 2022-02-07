using Microsoft.EntityFrameworkCore.Migrations;

namespace AtmBanking.DAL.Migrations
{
    public partial class AccountDetailsModelCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "accountDetails",
                columns: table => new
                {
                    accountId_no = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    account_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    account_number = table.Column<int>(type: "int", nullable: false),
                    card_no = table.Column<int>(type: "int", nullable: false),
                    credit_fields = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    current_balance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accountDetails", x => x.accountId_no);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "accountDetails");
        }
    }
}
