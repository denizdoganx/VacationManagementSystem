using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManagementSystem.Models
{
    public class HotelTicket
    {
        [Key]
        public int ID { get; set; }
        public string roomNumber { get; set; }


        [ForeignKey(nameof(Customer))]
        public int customerID { get; set; }
        public Customer customer { get; set; }


        [ForeignKey(nameof(Room))]
        public int roomID { get; set; }
        public Room room { get; set; }
    }
}
