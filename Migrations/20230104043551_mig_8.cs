using Microsoft.EntityFrameworkCore.Migrations;

namespace VacationManagementSystem.Migrations
{
    public partial class mig_8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "hotelTickets",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    roomNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerID = table.Column<int>(type: "int", nullable: false),
                    roomID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hotelTickets", x => x.ID);
                    table.ForeignKey(
                        name: "FK_hotelTickets_customers_customerID",
                        column: x => x.customerID,
                        principalTable: "customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hotelTickets_rooms_roomID",
                        column: x => x.roomID,
                        principalTable: "rooms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tourTickets",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    seatNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerID = table.Column<int>(type: "int", nullable: false),
                    tourID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tourTickets", x => x.ID);
                    table.ForeignKey(
                        name: "FK_tourTickets_customers_customerID",
                        column: x => x.customerID,
                        principalTable: "customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tourTickets_tours_tourID",
                        column: x => x.tourID,
                        principalTable: "tours",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_hotelTickets_customerID",
                table: "hotelTickets",
                column: "customerID");

            migrationBuilder.CreateIndex(
                name: "IX_hotelTickets_roomID",
                table: "hotelTickets",
                column: "roomID");

            migrationBuilder.CreateIndex(
                name: "IX_tourTickets_customerID",
                table: "tourTickets",
                column: "customerID");

            migrationBuilder.CreateIndex(
                name: "IX_tourTickets_tourID",
                table: "tourTickets",
                column: "tourID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hotelTickets");

            migrationBuilder.DropTable(
                name: "tourTickets");
        }
    }
}
