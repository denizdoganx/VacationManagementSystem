using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManagementSystem.Models
{
    public class Reservation
    {
        [Key]
        public int ID { get; set; }

        //public string bookingStatus { get; set; }
        
        public DateTime dateOfEntry { get; set; }
        public DateTime releaseDate { get; set; }




        public Payment payment { get; set; }



        [ForeignKey(nameof(Customer))]
        public int customerID { get; set; }
        public Customer customer { get; set; }
    }
}
