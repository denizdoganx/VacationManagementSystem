using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VacationManagementSystem.Context;
using VacationManagementSystem.Models;


namespace VacationManagementSystem.Context
{
    public class VacationDbContext : DbContext
    {

        public DbSet<Address> addresses { get; set; }
        public DbSet<Country> countries { get; set; }
        public DbSet<City> cities { get; set; }
        public DbSet<Town> towns { get; set; }
        public DbSet<District> districts { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Adminastrator> adminastrators { get; set; }
        public DbSet<Airline> airlines { get; set; }
        public DbSet<Flight> flights { get; set; }
        public DbSet<FlightTicket> flightTickets { get; set; }
        public DbSet<Hotel> hotels { get; set; }
        public DbSet<Room> rooms { get; set; }
        public DbSet<Tour> tours { get; set; }
        public DbSet<TravelAgency> travelAgencies { get; set; }
        public DbSet<Card> cards { get; set; }
        public DbSet<Payment> payments { get; set; }
        public DbSet<Reservation> reservations { get; set; }

        public DbSet<HotelTicket> hotelTickets { get; set; }
        public DbSet<TourTicket> tourTickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=192.168.92.134,1433;Database=VacationDB;User Id=sa;Password=Password1");
        }

    }
}
