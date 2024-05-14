using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VacationManagementSystem.Migrations
{
    public partial class mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "airlines",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_airlines", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "countries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    countryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countries", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "travelAgencies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tourType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    totalTourNumber = table.Column<int>(type: "int", nullable: false),
                    totalStarNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_travelAgencies", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "flights",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    price = table.Column<int>(type: "int", nullable: false),
                    arrivalTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    depertureTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    destination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    from = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    to = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    capacity = table.Column<int>(type: "int", nullable: false),
                    emptySeatNumber = table.Column<int>(type: "int", nullable: false),
                    airlineID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_flights", x => x.ID);
                    table.ForeignKey(
                        name: "FK_flights_airlines_airlineID",
                        column: x => x.airlineID,
                        principalTable: "airlines",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    countryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_cities_countries_countryID",
                        column: x => x.countryID,
                        principalTable: "countries",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tours",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tourPrice = table.Column<int>(type: "int", nullable: false),
                    deperturePlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    arrivalPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maxGuest = table.Column<int>(type: "int", nullable: false),
                    bookingStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    travelAgencyID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tours", x => x.ID);
                    table.ForeignKey(
                        name: "FK_tours_travelAgencies_travelAgencyID",
                        column: x => x.travelAgencyID,
                        principalTable: "travelAgencies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "adminastrators",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adminastrators", x => x.ID);
                    table.ForeignKey(
                        name: "FK_adminastrators_users_userID",
                        column: x => x.userID,
                        principalTable: "users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_customers_users_userID",
                        column: x => x.userID,
                        principalTable: "users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "flightTickets",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    seatNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    flightID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_flightTickets", x => x.ID);
                    table.ForeignKey(
                        name: "FK_flightTickets_flights_flightID",
                        column: x => x.flightID,
                        principalTable: "flights",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "towns",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    townName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cityID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_towns", x => x.ID);
                    table.ForeignKey(
                        name: "FK_towns_cities_cityID",
                        column: x => x.cityID,
                        principalTable: "cities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cards",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cards", x => x.ID);
                    table.ForeignKey(
                        name: "FK_cards_customers_customerID",
                        column: x => x.customerID,
                        principalTable: "customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reservations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dateOfEntry = table.Column<DateTime>(type: "datetime2", nullable: false),
                    releaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    customerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_reservations_customers_customerID",
                        column: x => x.customerID,
                        principalTable: "customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "districts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    districtName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    townID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_districts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_districts_towns_townID",
                        column: x => x.townID,
                        principalTable: "towns",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "payments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    amount = table.Column<int>(type: "int", nullable: false),
                    customerID = table.Column<int>(type: "int", nullable: false),
                    reservationID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_payments_customers_customerID",
                        column: x => x.customerID,
                        principalTable: "customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_payments_reservations_reservationID",
                        column: x => x.reservationID,
                        principalTable: "reservations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "addresses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    postalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    addressText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerID = table.Column<int>(type: "int", nullable: true),
                    countryID = table.Column<int>(type: "int", nullable: false),
                    cityID = table.Column<int>(type: "int", nullable: false),
                    townID = table.Column<int>(type: "int", nullable: false),
                    districtID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addresses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_addresses_cities_cityID",
                        column: x => x.cityID,
                        principalTable: "cities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_addresses_countries_countryID",
                        column: x => x.countryID,
                        principalTable: "countries",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_addresses_customers_customerID",
                        column: x => x.customerID,
                        principalTable: "customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_addresses_districts_districtID",
                        column: x => x.districtID,
                        principalTable: "districts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_addresses_towns_townID",
                        column: x => x.townID,
                        principalTable: "towns",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "hotels",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    totalRoomNumber = table.Column<int>(type: "int", nullable: false),
                    totalStarNumber = table.Column<int>(type: "int", nullable: false),
                    addressID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hotels", x => x.ID);
                    table.ForeignKey(
                        name: "FK_hotels_addresses_addressID",
                        column: x => x.addressID,
                        principalTable: "addresses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rooms",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maxGuest = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    roomPrice = table.Column<int>(type: "int", nullable: false),
                    bookingStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hotelID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rooms", x => x.ID);
                    table.ForeignKey(
                        name: "FK_rooms_hotels_hotelID",
                        column: x => x.hotelID,
                        principalTable: "hotels",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_addresses_cityID",
                table: "addresses",
                column: "cityID");

            migrationBuilder.CreateIndex(
                name: "IX_addresses_countryID",
                table: "addresses",
                column: "countryID");

            migrationBuilder.CreateIndex(
                name: "IX_addresses_customerID",
                table: "addresses",
                column: "customerID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_addresses_districtID",
                table: "addresses",
                column: "districtID");

            migrationBuilder.CreateIndex(
                name: "IX_addresses_townID",
                table: "addresses",
                column: "townID");

            migrationBuilder.CreateIndex(
                name: "IX_adminastrators_userID",
                table: "adminastrators",
                column: "userID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_cards_customerID",
                table: "cards",
                column: "customerID");

            migrationBuilder.CreateIndex(
                name: "IX_cities_countryID",
                table: "cities",
                column: "countryID");

            migrationBuilder.CreateIndex(
                name: "IX_customers_userID",
                table: "customers",
                column: "userID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_districts_townID",
                table: "districts",
                column: "townID");

            migrationBuilder.CreateIndex(
                name: "IX_flights_airlineID",
                table: "flights",
                column: "airlineID");

            migrationBuilder.CreateIndex(
                name: "IX_flightTickets_flightID",
                table: "flightTickets",
                column: "flightID");

            migrationBuilder.CreateIndex(
                name: "IX_hotels_addressID",
                table: "hotels",
                column: "addressID");

            migrationBuilder.CreateIndex(
                name: "IX_payments_customerID",
                table: "payments",
                column: "customerID");

            migrationBuilder.CreateIndex(
                name: "IX_payments_reservationID",
                table: "payments",
                column: "reservationID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_reservations_customerID",
                table: "reservations",
                column: "customerID");

            migrationBuilder.CreateIndex(
                name: "IX_rooms_hotelID",
                table: "rooms",
                column: "hotelID");

            migrationBuilder.CreateIndex(
                name: "IX_tours_travelAgencyID",
                table: "tours",
                column: "travelAgencyID");

            migrationBuilder.CreateIndex(
                name: "IX_towns_cityID",
                table: "towns",
                column: "cityID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "adminastrators");

            migrationBuilder.DropTable(
                name: "cards");

            migrationBuilder.DropTable(
                name: "flightTickets");

            migrationBuilder.DropTable(
                name: "payments");

            migrationBuilder.DropTable(
                name: "rooms");

            migrationBuilder.DropTable(
                name: "tours");

            migrationBuilder.DropTable(
                name: "flights");

            migrationBuilder.DropTable(
                name: "reservations");

            migrationBuilder.DropTable(
                name: "hotels");

            migrationBuilder.DropTable(
                name: "travelAgencies");

            migrationBuilder.DropTable(
                name: "airlines");

            migrationBuilder.DropTable(
                name: "addresses");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "districts");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "towns");

            migrationBuilder.DropTable(
                name: "cities");

            migrationBuilder.DropTable(
                name: "countries");
        }
    }
}
