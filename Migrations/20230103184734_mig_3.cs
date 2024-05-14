using Microsoft.EntityFrameworkCore.Migrations;

namespace VacationManagementSystem.Migrations
{
    public partial class mig_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bookingStatus",
                table: "tours");

            migrationBuilder.AddColumn<int>(
                name: "emptySeatNumber",
                table: "tours",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "emptySeatNumber",
                table: "tours");

            migrationBuilder.AddColumn<string>(
                name: "bookingStatus",
                table: "tours",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
