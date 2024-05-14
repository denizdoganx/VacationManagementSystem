using Microsoft.EntityFrameworkCore.Migrations;

namespace VacationManagementSystem.Migrations
{
    public partial class mig_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "customerID",
                table: "flightTickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_flightTickets_customerID",
                table: "flightTickets",
                column: "customerID");

            migrationBuilder.AddForeignKey(
                name: "FK_flightTickets_customers_customerID",
                table: "flightTickets",
                column: "customerID",
                principalTable: "customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_flightTickets_customers_customerID",
                table: "flightTickets");

            migrationBuilder.DropIndex(
                name: "IX_flightTickets_customerID",
                table: "flightTickets");

            migrationBuilder.DropColumn(
                name: "customerID",
                table: "flightTickets");
        }
    }
}
