using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission7DeLange.Migrations
{
    public partial class FixModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<bool>(
                name: "PurchaseShipped",
                table: "Purchases",
                nullable: false,
                defaultValue: false);
        }

    }
}
