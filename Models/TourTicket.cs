using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManagementSystem.Models
{
    public class TourTicket
    {
        [Key]
        public int ID { get; set; }
        public string seatNumber { get; set; }


        [ForeignKey(nameof(Customer))]
        public int customerID { get; set; }
        public Customer customer { get; set; }


        [ForeignKey(nameof(Tour))]
        public int tourID { get; set; }
        public Tour Tour { get; set; }
    }
}
