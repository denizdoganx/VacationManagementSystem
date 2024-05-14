using Microsoft.EntityFrameworkCore.Migrations;

namespace VacationManagementSystem.Migrations
{
    public partial class mig_6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CVC",
                table: "cards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "cardNumber",
                table: "cards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "month",
                table: "cards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "nameOnCard",
                table: "cards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "year",
                table: "cards",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CVC",
                table: "cards");

            migrationBuilder.DropColumn(
                name: "cardNumber",
                table: "cards");

            migrationBuilder.DropColumn(
                name: "month",
                table: "cards");

            migrationBuilder.DropColumn(
                name: "nameOnCard",
                table: "cards");

            migrationBuilder.DropColumn(
                name: "year",
                table: "cards");
        }
    }
}
