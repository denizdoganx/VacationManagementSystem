using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManagementSystem.Models
{
    public class Payment
    {
        public int ID { get; set; }
        public int amount { get; set; }


        [ForeignKey(nameof(Customer))]
        public int customerID { get; set; }
        public Customer customer { get; set; }





        [ForeignKey(nameof(Reservation))]
        public int reservationID { get; set; }
        public Reservation reservation { get; set; }
    }
}
