using Microsoft.EntityFrameworkCore.Migrations;

namespace VacationManagementSystem.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "totalTourNumber",
                table: "travelAgencies");

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "travelAgencies",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "name",
                table: "travelAgencies");

            migrationBuilder.AddColumn<int>(
                name: "totalTourNumber",
                table: "travelAgencies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
