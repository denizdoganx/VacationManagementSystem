using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using VacationManagementSystem.Context;
using VacationManagementSystem.Models;
using VacationManagementSystem.Models.ViewModels;

namespace VacationManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        static VacationDbContext context = VacationDB.GetDatabase();

        static int flightID = 0;

        static int tourID = 0;

        static int hotelID = 0;


        static Random rnd = new Random();

        public static string accountID = null;

        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }




        [HttpGet]
        public IActionResult Index()
        {
            if (accountID != null)
            {
                ViewBag.id = accountID;
            }
            return View();
        }


        [HttpGet]
        public IActionResult Flight()
        {
            if (accountID != null)
            {
                ViewBag.id = accountID;
            }
            return View();
        }

        [HttpPost]
        public IActionResult Flight(FlightListVM pFlight)
        {
            if (accountID != null)
            {
                ViewBag.id = accountID;
               
            }
            if (!ModelState.IsValid)
            {
                return View(pFlight);
            }
            else
            {
                DateTime requestedDepertureDate = pFlight.depertureTime;
                DateTime tempDateTime;

                //string date = dateTime.ToShortDateString();

                //string day = dateTime.Day.ToString();


                List<Flight> flights = context.flights.Where(f => f.from == pFlight.from && f.to == pFlight.to).ToList();

                List<Flight> appopriateFlights = new List<Flight>();

                foreach (var item in flights)
                {
                    tempDateTime = item.depertureTime;

                    if (requestedDepertureDate.CompareTo(tempDateTime) <= 0)
                    {
                        appopriateFlights.Add(item);
                    }
                }

                if(appopriateFlights == null)
                {
                    ViewBag.errorMessage = "No flights were found according to your search criteria !";
                    return View(pFlight);
                }
                else
                {
                    string data = JsonSerializer.Serialize(appopriateFlights);
                    TempData["flights"] = data;
                    return RedirectToAction("ListFlights");
                }

            }
        }

        [HttpGet]
        public IActionResult ListFlights()
        {
            if (accountID != null)
            {
                ViewBag.id = accountID;

            }

            var data = TempData["flights"].ToString();

            return View(JsonSerializer.Deserialize<List<Flight>>(data));
        }

        [HttpGet]
        public IActionResult BuyFlightTicket()
        {
            if (accountID != null)
            {
                ViewBag.id = accountID;

            }

            var id = Request.Query["id"];

            flightID = Convert.ToInt32(id);

            Flight flight = context.flights.Where(f => f.ID == flightID).SingleOrDefault();

            Airline airline = context.airlines.Where(a => a.ID == flight.airlineID).SingleOrDefault();

            var combinedPacket = (flight, airline);

            return View(combinedPacket);

        }

        [HttpPost]
        public IActionResult BuyFlightTicket(int airlineID, int flightID)
        {
            if (accountID != null)
            {
                ViewBag.id = accountID;

            }

            Flight flight = context.flights.Where(f => f.ID == flightID).SingleOrDefault();

            if(flight.emptySeatNumber == 0)
            {
                ViewBag.errorMessage = "There are no empty seats on this flight";
                return View((flight, context.airlines.Where(a => a.ID == airlineID).SingleOrDefault()));
            }
            else
            {


                List<FlightTicket> flightTickets = context.flightTickets.Where(ft => ft.flightID == flightID).ToList();

                List<int> seatNumbers = new List<int>();

                foreach (var item in flightTickets)
                {
                    seatNumbers.Add((Convert.ToInt32(item.seatNumber)));
                }
                int randomSeatNumber = rnd.Next(1, flight.capacity + 1);
                while (seatNumbers.Contains(randomSeatNumber))
                {
                    randomSeatNumber = rnd.Next(1, flight.capacity + 1);
                }


                FlightTicket flightTicket = new FlightTicket
                {
                    customerID = Convert.ToInt32(context.customers.Where(c => c.userID.ToString() == accountID).SingleOrDefault().ID),
                    flightID = flight.ID,
                    seatNumber = randomSeatNumber.ToString()
                };
                context.flightTickets.Add(flightTicket);
                flightID = 0;
                flight.emptySeatNumber -= 1;
                context.SaveChanges();
                return View("FlightReservationSummary", (flightTicket ,flight, context.airlines.Where(a => a.ID == airlineID).SingleOrDefault()));
            }
        }


        [HttpGet]
        public IActionResult Tour()
        {
            if (accountID != null)
            {
                ViewBag.id = accountID;
            }
            return View();
        }

        [HttpPost]
        public IActionResult Tour(TourListVM pTour)
        {
            if (accountID != null)
            {
                ViewBag.id = accountID;

            }
            if (!ModelState.IsValid)
            {
                return View(pTour);
            }
            else
            {

                List<Tour> tours = context.tours.Where(t => t.tourType.ToLower() == pTour.tourType.ToLower()).ToList();

                if (tours == null)
                {
                    ViewBag.errorMessage = "No tours were found according to your search criteria !";
                    return View(pTour);
                }
                else
                {
                    string data = JsonSerializer.Serialize(tours);
                    TempData["tours"] = data;
                    return RedirectToAction("ListTours");
                }

            }
        }

        [HttpGet]
        public IActionResult ListTours()
        {
            if (accountID != null)
            {
                ViewBag.id = accountID;

            }

            var data = TempData["tours"].ToString();

            return View(JsonSerializer.Deserialize<List<Tour>>(data));
        }

        [HttpGet]
        public IActionResult ReservationTour()
        {
            if (accountID != null)
            {
                ViewBag.id = accountID;

            }
            var id = Request.Query["id"];
            tourID = Convert.ToInt32(id);
            Tour tour = context.tours.Where(t => t.ID == tourID).SingleOrDefault();
            TravelAgency travelAgency = context.travelAgencies.Where(t => t.ID == tour.travelAgencyID).SingleOrDefault();
            var combinedPacket = (tour, travelAgency);
            return View(combinedPacket);

        }

        [HttpPost]
        public IActionResult ReservationTour(int travelAgencyID, int tourID)
        {
            if (accountID != null)
            {
                ViewBag.id = accountID;

            }

            Tour tour = context.tours.Where(t => t.ID == tourID).SingleOrDefault();

            if (tour.emptySeatNumber == 0)
            {
                ViewBag.errorMessage = "There are no empty seats on this tour.";
                return View((tour, context.travelAgencies.Where(t => t.ID == travelAgencyID).SingleOrDefault()));
            }
            else
            {


                List<TourTicket> tourTickets = context.tourTickets.Where(t => t.ID == travelAgencyID).ToList();

                List<int> seatNumbers = new List<int>();

                foreach (var item in tourTickets)
                {
                    seatNumbers.Add((Convert.ToInt32(item.seatNumber)));
                }
                int randomSeatNumber = rnd.Next(1, tour.maxGuest + 1);
                while (seatNumbers.Contains(randomSeatNumber))
                {
                    randomSeatNumber = rnd.Next(1, tour.maxGuest + 1);
                }


                TourTicket tourTicket = new TourTicket
                {
                    customerID = Convert.ToInt32(context.customers.Where(c => c.userID.ToString() == accountID).SingleOrDefault().ID),
                    tourID = tour.ID,
                    seatNumber = randomSeatNumber.ToString()
                };
                context.tourTickets.Add(tourTicket);
                tourID = 0;
                tour.emptySeatNumber -= 1;
                context.SaveChanges();
                return View("TourReservationSummary", (tourTicket, tour, context.travelAgencies.Where(t => t.ID == travelAgencyID).SingleOrDefault()));
            }
        }

        [HttpGet]
        public IActionResult Hotel()
        {
            if (accountID != null)
            {
                ViewBag.id = accountID;
                
            }
            return View();
        }


        [HttpGet]
        public IActionResult About()
        {
            if (accountID != null)
            {
                ViewBag.id = accountID;
                
            }
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
