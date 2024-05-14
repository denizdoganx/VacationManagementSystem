using Microsoft.EntityFrameworkCore.Migrations;

namespace VacationManagementSystem.Migrations
{
    public partial class mig_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tourType",
                table: "travelAgencies");

            migrationBuilder.AddColumn<string>(
                name: "tourType",
                table: "tours",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tourType",
                table: "tours");

            migrationBuilder.AddColumn<string>(
                name: "tourType",
                table: "travelAgencies",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
