using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManagementSystem.Models
{
    public class Hotel
    {
        [Key]
        public int ID { get; set; }
        public string name { get; set; }
        public int totalRoomNumber { get; set; }
        public int totalStarNumber { get; set; }



        [ForeignKey(nameof(Address))]
        public int addressID { get; set; }
        public Address address { get; set; }


        public ICollection<Room> rooms { get; set; }
    }
}
