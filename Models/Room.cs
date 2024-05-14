using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManagementSystem.Models
{
    public class Room
    {
        public int ID { get; set; }
        public int maxGuest { get; set; }
        public string description { get; set; }
        public int roomPrice { get; set; }
        public string bookingStatus { get; set; }


        [ForeignKey(nameof(Hotel))]
        public int hotelID { get; set; }
        public Hotel hotel { get; set; }

    }
}
