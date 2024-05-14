using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManagementSystem.Models
{
    public class Customer
    {
        public int ID { get; set; }

        public string name { get; set; }
        public string surname { get; set; }
        public string phoneNumber { get; set; }
        




        [ForeignKey(nameof(User))]
        public int userID { get; set; }
        public User user { get; set; }



        public ICollection<FlightTicket> flightTickets { get; set; }
        public Address address { get; set; }
        public ICollection<Payment> payments { get; set; }
        public ICollection<Card> cards { get; set; }
    }
}
