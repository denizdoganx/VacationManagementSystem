using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManagementSystem.Models
{
    public class Tour
    {

        [Key]
        public int ID { get; set; }
        public string description { get; set; }
        public int tourPrice { get; set; }
        public string deperturePlace { get; set; }
        public string arrivalPlace { get; set; }
        public int maxGuest { get; set; }
        public int emptySeatNumber { get; set; }
        public string tourType { get; set; }



        [ForeignKey(nameof(TravelAgency))]
        public int travelAgencyID { get; set; }
        public TravelAgency TravelAgency { get; set; }
    }
}
