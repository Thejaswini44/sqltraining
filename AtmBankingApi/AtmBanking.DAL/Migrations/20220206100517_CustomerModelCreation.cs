using Microsoft.EntityFrameworkCore.Migrations;

namespace AtmBanking.DAL.Migrations
{
    public partial class CustomerModelCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customer",
                columns: table => new
                {
                    card_no = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email_address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contact_info = table.Column<int>(type: "int", nullable: false),
                    pin_no = table.Column<int>(type: "int", nullable: false),
                    account_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    account_number = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer", x => x.card_no);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customer");
        }
    }
}
