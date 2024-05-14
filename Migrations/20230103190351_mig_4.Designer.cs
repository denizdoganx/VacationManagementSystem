﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VacationManagementSystem.Context;

namespace VacationManagementSystem.Migrations
{
    [DbContext(typeof(VacationDbContext))]
    [Migration("20230103190351_mig_4")]
    partial class mig_4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("VacationManagementSystem.Models.Address", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("addressText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cityID")
                        .HasColumnType("int");

                    b.Property<int>("countryID")
                        .HasColumnType("int");

                    b.Property<int>("customerID")
                        .HasColumnType("int");

                    b.Property<int>("districtID")
                        .HasColumnType("int");

                    b.Property<string>("postalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("townID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("cityID");

                    b.HasIndex("countryID");

                    b.HasIndex("customerID")
                        .IsUnique();

                    b.HasIndex("districtID");

                    b.HasIndex("townID");

                    b.ToTable("addresses");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.Adminastrator", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("userID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("userID")
                        .IsUnique();

                    b.ToTable("adminastrators");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.Airline", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("airlines");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.Card", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("customerID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("customerID");

                    b.ToTable("cards");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.City", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("cityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("countryID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("countryID");

                    b.ToTable("cities");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.Country", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("countryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("countries");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("userID")
                        .IsUnique();

                    b.ToTable("customers");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.District", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("districtName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("townID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("townID");

                    b.ToTable("districts");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.Flight", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("airlineID")
                        .HasColumnType("int");

                    b.Property<DateTime>("arrivalTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("capacity")
                        .HasColumnType("int");

                    b.Property<DateTime>("depertureTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("emptySeatNumber")
                        .HasColumnType("int");

                    b.Property<string>("from")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<string>("to")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("airlineID");

                    b.ToTable("flights");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.FlightTicket", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("flightID")
                        .HasColumnType("int");

                    b.Property<string>("seatNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("flightID");

                    b.ToTable("flightTickets");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.Hotel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("addressID")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("totalRoomNumber")
                        .HasColumnType("int");

                    b.Property<int>("totalStarNumber")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("addressID");

                    b.ToTable("hotels");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.Payment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("amount")
                        .HasColumnType("int");

                    b.Property<int>("customerID")
                        .HasColumnType("int");

                    b.Property<int>("reservationID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("customerID");

                    b.HasIndex("reservationID")
                        .IsUnique();

                    b.ToTable("payments");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.Reservation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("customerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateOfEntry")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("releaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("customerID");

                    b.ToTable("reservations");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.Room", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("bookingStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("hotelID")
                        .HasColumnType("int");

                    b.Property<int>("maxGuest")
                        .HasColumnType("int");

                    b.Property<int>("roomPrice")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("hotelID");

                    b.ToTable("rooms");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.Tour", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("arrivalPlace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("deperturePlace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("emptySeatNumber")
                        .HasColumnType("int");

                    b.Property<int>("maxGuest")
                        .HasColumnType("int");

                    b.Property<int>("tourPrice")
                        .HasColumnType("int");

                    b.Property<string>("tourType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("travelAgencyID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("travelAgencyID");

                    b.ToTable("tours");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.Town", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("cityID")
                        .HasColumnType("int");

                    b.Property<string>("townName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("cityID");

                    b.ToTable("towns");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.TravelAgency", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("totalStarNumber")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("travelAgencies");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userLevel")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("users");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.Address", b =>
                {
                    b.HasOne("VacationManagementSystem.Models.City", "city")
                        .WithMany("addresses")
                        .HasForeignKey("cityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VacationManagementSystem.Models.Country", "country")
                        .WithMany("addresses")
                        .HasForeignKey("countryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VacationManagementSystem.Models.Customer", "customer")
                        .WithOne("address")
                        .HasForeignKey("VacationManagementSystem.Models.Address", "customerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VacationManagementSystem.Models.District", "district")
                        .WithMany("addresses")
                        .HasForeignKey("districtID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VacationManagementSystem.Models.Town", "town")
                        .WithMany("addresses")
                        .HasForeignKey("townID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("city");

                    b.Navigation("country");

                    b.Navigation("customer");

                    b.Navigation("district");

                    b.Navigation("town");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.Adminastrator", b =>
                {
                    b.HasOne("VacationManagementSystem.Models.User", "user")
                        .WithOne("adminastrator")
                        .HasForeignKey("VacationManagementSystem.Models.Adminastrator", "userID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.Card", b =>
                {
                    b.HasOne("VacationManagementSystem.Models.Customer", "customer")
                        .WithMany("cards")
                        .HasForeignKey("customerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customer");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.City", b =>
                {
                    b.HasOne("VacationManagementSystem.Models.Country", "country")
                        .WithMany("cities")
                        .HasForeignKey("countryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("country");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.Customer", b =>
                {
                    b.HasOne("VacationManagementSystem.Models.User", "user")
                        .WithOne("customer")
                        .HasForeignKey("VacationManagementSystem.Models.Customer", "userID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.District", b =>
                {
                    b.HasOne("VacationManagementSystem.Models.Town", "town")
                        .WithMany("districts")
                        .HasForeignKey("townID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("town");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.Flight", b =>
                {
                    b.HasOne("VacationManagementSystem.Models.Airline", "airline")
                        .WithMany("flights")
                        .HasForeignKey("airlineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("airline");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.FlightTicket", b =>
                {
                    b.HasOne("VacationManagementSystem.Models.Flight", "flight")
                        .WithMany("flightTickets")
                        .HasForeignKey("flightID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("flight");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.Hotel", b =>
                {
                    b.HasOne("VacationManagementSystem.Models.Address", "address")
                        .WithMany()
                        .HasForeignKey("addressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("address");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.Payment", b =>
                {
                    b.HasOne("VacationManagementSystem.Models.Customer", "customer")
                        .WithMany("payments")
                        .HasForeignKey("customerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VacationManagementSystem.Models.Reservation", "reservation")
                        .WithOne("payment")
                        .HasForeignKey("VacationManagementSystem.Models.Payment", "reservationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customer");

                    b.Navigation("reservation");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.Reservation", b =>
                {
                    b.HasOne("VacationManagementSystem.Models.Customer", "customer")
                        .WithMany()
                        .HasForeignKey("customerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customer");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.Room", b =>
                {
                    b.HasOne("VacationManagementSystem.Models.Hotel", "hotel")
                        .WithMany("rooms")
                        .HasForeignKey("hotelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("hotel");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.Tour", b =>
                {
                    b.HasOne("VacationManagementSystem.Models.TravelAgency", "TravelAgency")
                        .WithMany("tours")
                        .HasForeignKey("travelAgencyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TravelAgency");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.Town", b =>
                {
                    b.HasOne("VacationManagementSystem.Models.City", "city")
                        .WithMany("towns")
                        .HasForeignKey("cityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("city");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.Airline", b =>
                {
                    b.Navigation("flights");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.City", b =>
                {
                    b.Navigation("addresses");

                    b.Navigation("towns");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.Country", b =>
                {
                    b.Navigation("addresses");

                    b.Navigation("cities");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.Customer", b =>
                {
                    b.Navigation("address");

                    b.Navigation("cards");

                    b.Navigation("payments");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.District", b =>
                {
                    b.Navigation("addresses");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.Flight", b =>
                {
                    b.Navigation("flightTickets");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.Hotel", b =>
                {
                    b.Navigation("rooms");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.Reservation", b =>
                {
                    b.Navigation("payment");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.Town", b =>
                {
                    b.Navigation("addresses");

                    b.Navigation("districts");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.TravelAgency", b =>
                {
                    b.Navigation("tours");
                });

            modelBuilder.Entity("VacationManagementSystem.Models.User", b =>
                {
                    b.Navigation("adminastrator");

                    b.Navigation("customer");
                });
#pragma warning restore 612, 618
        }
    }
}
