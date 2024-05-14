using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManagementSystem.Models
{
    public class FlightTicket
    {
        [Key]
        public int ID { get; set; }
        public string seatNumber { get; set; }


        [ForeignKey(nameof(Customer))]
        public int customerID { get; set; }
        public Customer customer { get; set; }


        [ForeignKey(nameof(Flight))]
        public int flightID { get; set; }
        public Flight flight { get; set; }
    }
}
