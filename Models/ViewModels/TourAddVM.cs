using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManagementSystem.Models.ViewModels
{
    public class TourAddVM
    {
        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public string description { get; set; }


        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public int tourPrice { get; set; }


        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public string deperturePlace { get; set; }


        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public string arrivalPlace { get; set; }


        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public int maxGuest { get; set; }


        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public string tourType { get; set; }


        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public string travelAgencyName { get; set; }

    }
}
