using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VacationManagementSystem.Context;
using VacationManagementSystem.Models;
using VacationManagementSystem.Models.ViewModels;

namespace VacationManagementSystem.Controllers
{
    public class AdminController : Controller
    {
        static VacationDbContext context = VacationDB.GetDatabase();

        static int airlineID = 0;
        static int flightID = 0;

        static int hotelID = 0;
        static int roomID = 0;

        static int travelagencyID = 0;
        static int tourID = 0;

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AirlineAdmin()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddAirline()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAirline(AirlineAddVM pAirline)
        {
            if (!ModelState.IsValid)
            {
                return View(pAirline);
            }
            else
            {
                Airline airline = context.airlines.Where(a => a.name == pAirline.name).SingleOrDefault();
                if(airline != null)
                {
                    ViewBag.errorMessage = "There is already an airline with this name.";
                    return View();
                }
                else
                {
                    Airline airlineToBeAdded = new Airline
                    {
                        name = pAirline.name
                    };
                    context.airlines.Add(airlineToBeAdded);
                    context.SaveChanges();
                    ViewBag.succesfulMessage = "Successfully Added.";
                    return View();
                }
            }
        }

        [HttpGet]
        public IActionResult AddFlight()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddFlight(FlightAddVM pFlight)
        {
            if (!ModelState.IsValid)
            {
                return View(pFlight);
            }
            else
            {

                Airline airline = context.airlines.Where(a => a.name == pFlight.airlineName).SingleOrDefault();

                if (airline == null)
                {
                    ViewBag.errorMessage = "There is no such airline.";
                    return View();
                }
                else
                {
                    Flight flightToBeAdded = new Flight
                    {
                        airlineID = airline.ID,
                        price = pFlight.price,
                        capacity = pFlight.capacity,
                        from = pFlight.from,
                        to = pFlight.to,
                        depertureTime = pFlight.depertureTime,
                        arrivalTime = pFlight.arrivalTime,
                        destination = pFlight.destination,
                        emptySeatNumber = pFlight.capacity
                    };
                    context.flights.Add(flightToBeAdded);
                    context.SaveChanges();
                    ViewBag.succesfulMessage = "Successfully Added.";
                    return View();
                }
            }
        }

        [HttpGet]
        public IActionResult ListAirlines()
        {
            List<Airline> airlines = context.airlines.ToList();
            return View(airlines);
        }

        [HttpGet]
        public IActionResult ListFlights()
        {
            List<Flight> flights = context.flights.ToList();
            return View(flights);
        }

        [HttpGet]
        public IActionResult UpdateAirline()
        {
            var id = Request.Query["id"];

            airlineID = Convert.ToInt32(id);

            Airline airline = context.airlines.Where(a => a.ID == airlineID).SingleOrDefault();

            AirlineAddVM model = new AirlineAddVM
            {
                name = airline.name
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateAirline(AirlineAddVM pAirline)
        {
            if (!ModelState.IsValid)
            {
                return View(pAirline);
            }
            else
            {
                Airline airline = context.airlines.Where(a => a.ID == airlineID).SingleOrDefault();

                airline.name = pAirline.name;

                airlineID = 0;

                context.SaveChanges();
                return RedirectToAction("AirlineAdmin");
            }
            
        }


        [HttpGet]
        public IActionResult UpdateFlight()
        {
            var id = Request.Query["id"];

            flightID = Convert.ToInt32(id);

            Flight flight = context.flights.Where(f => f.ID == flightID).SingleOrDefault();

            FlightUpdateVM model = new FlightUpdateVM
            {
                from = flight.from,
                to = flight.to,
                price = flight.price,
                capacity = flight.capacity,
                arrivalTime = flight.arrivalTime,
                depertureTime = flight.depertureTime,
                destination = flight.destination
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateFlight(FlightUpdateVM pFlight)
        {
            if (!ModelState.IsValid)
            {
                return View(pFlight);
            }
            else
            {
                Flight flight = context.flights.Where(f => f.ID == flightID).SingleOrDefault();

                flight.from = pFlight.from;
                flight.to = pFlight.to;
                flight.price = pFlight.price;
                flight.capacity = pFlight.capacity;
                flight.arrivalTime = pFlight.arrivalTime;
                flight.depertureTime = pFlight.depertureTime;
                flight.destination = pFlight.destination;


                flightID = 0;

                context.SaveChanges();

                return RedirectToAction("AirlineAdmin");
            }
        }

        public IActionResult HotelAdmin()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddHotel()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddHotel(HotelAddVM pHotel)
        {
            if (!ModelState.IsValid)
            {
                return View(pHotel);
            }
            else
            {
                Country country = context.countries.Where(c => c.countryName == pHotel.countryName).SingleOrDefault();

                City city = context.cities.Where(c => c.cityName == pHotel.cityName).SingleOrDefault();

                Town town = context.towns.Where(t => t.townName == pHotel.townName).SingleOrDefault();

                District district = context.districts.Where(d => d.districtName == pHotel.districtName).SingleOrDefault();



                Address address = new Address
                {
                    countryID = country.ID,
                    cityID = city.ID,
                    townID = town.ID,
                    districtID = district.ID,
                    postalCode = pHotel.postalCode,
                    addressText = pHotel.addressText,
                    customerID = 1
                };

                context.addresses.Add(address);
                context.SaveChanges();

                Console.WriteLine();

                Hotel hotel = new Hotel
                {
                    name = pHotel.name,
                    totalRoomNumber = pHotel.totalRoomNumber,
                    addressID = address.ID
                    
                };
                context.hotels.Add(hotel);
                context.SaveChanges();
                ViewBag.succesfulMessage = "Successfully Added.";
                return View();
            }
        }

        [HttpGet]
        public IActionResult AddRoom()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddRoom(RoomAddVM pRoom)
        {
            if (!ModelState.IsValid)
            {
                return View(pRoom);
            }
            else
            {

                Hotel hotel = context.hotels.Where(h => h.ID == pRoom.hotelID).SingleOrDefault();

                if (hotel == null)
                {
                    ViewBag.errorMessage = "There is no such hotel.";
                    return View();
                }
                else
                {
                    Room roomToBeAdded = new Room
                    {
                        hotelID = pRoom.hotelID,
                        roomPrice = pRoom.roomPrice,
                        description = pRoom.description,
                        maxGuest = pRoom.maxGuest,
                        bookingStatus = "Available"
                    };
                    context.rooms.Add(roomToBeAdded);

                    context.SaveChanges();

                    ViewBag.succesfulMessage = "Successfully Added.";

                    return View();
                }
            }
        }

        [HttpGet]
        public IActionResult ListHotels()
        {
            List<Hotel> hotels = context.hotels.ToList();
            return View(hotels);
        }

        [HttpGet]
        public IActionResult ListRooms()
        {
            List<Room> rooms = context.rooms.ToList();
            return View(rooms);
        }

        [HttpGet]
        public IActionResult UpdateHotel()
        {
            var id = Request.Query["id"];

            hotelID = Convert.ToInt32(id);

            Hotel hotel = context.hotels.Where(h => h.ID == hotelID).SingleOrDefault();

            var query = from h in context.hotels
                        join a in context.addresses
                            on h.addressID equals a.ID
                        join co in context.countries
                            on a.countryID equals co.ID
                        join ci in context.cities
                            on a.cityID equals ci.ID
                        join tw in context.towns
                            on a.townID equals tw.ID
                        join dt in context.districts
                            on a.districtID equals dt.ID
                        select new
                        {
                            co.countryName,
                            ci.cityName,
                            tw.townName,
                            dt.districtName,
                            a.postalCode,
                            a.addressText
                        };

            var datas = query.ToList();


            HotelAddVM model = new HotelAddVM
            {
                name = hotel.name,
                totalRoomNumber = hotel.totalRoomNumber,
                countryName = datas[0].countryName,
                cityName = datas[0].cityName,
                townName = datas[0].townName,
                districtName = datas[0].districtName,
                addressText = datas[0].addressText,
                postalCode = datas[0].postalCode
        };

            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateHotel(HotelAddVM pHotel)
        {
            if (!ModelState.IsValid)
            {
                return View(pHotel);
            }
            else
            {
                Hotel hotel = context.hotels.Where(h => h.ID == hotelID).SingleOrDefault();

                Address address = context.addresses.Where(a => a.ID == hotel.addressID).SingleOrDefault();

                Country country = context.countries.Where(c => c.ID == address.countryID).SingleOrDefault();

                City city = context.cities.Where(c => c.ID == address.cityID).SingleOrDefault();

                Town town = context.towns.Where(t => t.ID == address.townID).SingleOrDefault();

                District district = context.districts.Where(d => d.ID == address.districtID).SingleOrDefault();




                address.countryID = (context.countries.Where(c => c.countryName == pHotel.countryName).SingleOrDefault()).ID;

                address.cityID = (context.cities.Where(c => c.cityName == pHotel.cityName).SingleOrDefault()).ID;

                address.townID = (context.towns.Where(t => t.townName == pHotel.townName).SingleOrDefault()).ID;

                address.districtID = (context.districts.Where(d => d.districtName == pHotel.districtName).SingleOrDefault()).ID;

                address.addressText = pHotel.addressText;

                address.postalCode = pHotel.postalCode;

                hotel.name = pHotel.name;

                hotel.totalRoomNumber = pHotel.totalRoomNumber;

                
                hotelID = 0;

                context.SaveChanges();

                return RedirectToAction("HotelAdmin");
            }

        }

        [HttpGet]
        public IActionResult UpdateRoom()
        {
            var id = Request.Query["id"];

            roomID = Convert.ToInt32(id);

            Room room = context.rooms.Where(r => r.ID == roomID).SingleOrDefault();

            RoomUpdateVM model = new RoomUpdateVM
            {
                description = room.description,
                roomPrice = room.roomPrice,
                maxGuest = room.maxGuest
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateRoom(RoomUpdateVM pRoom)
        {
            if (!ModelState.IsValid)
            {
                return View(pRoom);
            }
            else
            {
                Room room = context.rooms.Where(r => r.ID == roomID).SingleOrDefault();

                room.maxGuest = pRoom.maxGuest;
                room.roomPrice = pRoom.roomPrice;
                room.description = pRoom.description;


                roomID = 0;

                context.SaveChanges();

                return RedirectToAction("HotelAdmin");
            }
        }

        public IActionResult TravelAgencyAdmin()
        {
            return View();
        }


        [HttpGet]
        public IActionResult AddTravelAgency()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTravelAgency(TravelAgencyAddVM pTravelAgency)
        {
            if (!ModelState.IsValid)
            {
                return View(pTravelAgency);
            }
            else
            {
                TravelAgency travelAgency = context.travelAgencies.Where(t => t.name == pTravelAgency.name).SingleOrDefault();
                if (travelAgency != null)
                {
                    ViewBag.errorMessage = "There is already an Travel Agency with this name.";
                    return View();
                }
                else
                {
                    TravelAgency travelAgencyToBeAdded = new TravelAgency
                    {
                        name = pTravelAgency.name
                    };
                    context.travelAgencies.Add(travelAgencyToBeAdded);
                    context.SaveChanges();
                    ViewBag.succesfulMessage = "Successfully Added.";
                    return View();
                }
            }
        }

        [HttpGet]
        public IActionResult AddTour()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTour(TourAddVM pTour)
        {
            if (!ModelState.IsValid)
            {
                return View(pTour);
            }
            else
            {

                TravelAgency travelAgency = context.travelAgencies.Where(t => t.name == pTour.travelAgencyName).SingleOrDefault();

                if (travelAgency == null)
                {
                    ViewBag.errorMessage = "There is no such Travel Agency.";
                    return View();
                }
                else
                {
                    Tour tourToBeAdded = new Tour
                    {
                        travelAgencyID = travelAgency.ID,
                        description = pTour.description,
                        deperturePlace = pTour.deperturePlace,
                        arrivalPlace = pTour.arrivalPlace,
                        maxGuest = pTour.maxGuest,
                        tourPrice = pTour.tourPrice,
                        tourType = pTour.tourType,
                        emptySeatNumber = pTour.maxGuest
                    };
                    context.tours.Add(tourToBeAdded);
                    context.SaveChanges();
                    ViewBag.succesfulMessage = "Successfully Added.";
                    return View();
                }
            }
        }

        [HttpGet]
        public IActionResult ListTravelAgencies()
        {
            List<TravelAgency> travelAgencies = context.travelAgencies.ToList();
            return View(travelAgencies);
        }

        [HttpGet]
        public IActionResult ListTours()
        {
            List<Tour> tours = context.tours.ToList();
            return View(tours);
        }

        [HttpGet]
        public IActionResult UpdateTravelAgency()
        {
            var id = Request.Query["id"];

            travelagencyID = Convert.ToInt32(id);

            TravelAgency travelAgency = context.travelAgencies.Where(t => t.ID == travelagencyID).SingleOrDefault();

            TravelAgencyAddVM model = new TravelAgencyAddVM
            {
                name = travelAgency.name
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateTravelAgency(TravelAgencyAddVM pTravelAgency)
        {
            if (!ModelState.IsValid)
            {
                return View(pTravelAgency);
            }
            else
            {
                TravelAgency travelAgency = context.travelAgencies.Where(a => a.ID == travelagencyID).SingleOrDefault();

                travelAgency.name = pTravelAgency.name;

                travelagencyID = 0;

                context.SaveChanges();

                return RedirectToAction("TravelAgencyAdmin");
            }

        }

        [HttpGet]
        public IActionResult UpdateTour()
        {
            var id = Request.Query["id"];

            tourID = Convert.ToInt32(id);

            Tour tour = context.tours.Where(t => t.ID == tourID).SingleOrDefault();

            TourUpdateVM model = new TourUpdateVM
            {
                description = tour.description,
                tourPrice = tour.tourPrice,
                maxGuest = tour.maxGuest
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateTour(TourUpdateVM pTour)
        {
            if (!ModelState.IsValid)
            {
                return View(pTour);
            }
            else
            {
                Tour tour = context.tours.Where(t => t.ID == tourID).SingleOrDefault();

                tour.maxGuest = pTour.maxGuest;
                tour.tourPrice = pTour.tourPrice;
                tour.description = pTour.description;


                tourID = 0;

                context.SaveChanges();

                return RedirectToAction("TravelAgencyAdmin");
            }
        }


    }
}
