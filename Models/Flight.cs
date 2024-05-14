using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManagementSystem.Models
{
    public class Flight
    {
        [Key]
        public int ID { get; set; }
        public int price { get; set; }
        public DateTime arrivalTime { get; set; }
        public DateTime depertureTime { get; set; }
        public string destination { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public int capacity { get; set; }
        public int emptySeatNumber { get; set; }


        [ForeignKey(nameof(Airline))]
        public int airlineID { get; set; }
        public Airline airline { get; set; }

        public ICollection<FlightTicket> flightTickets { get; set; }

    }
}
