using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManagementSystem.Models.ViewModels
{
    public class TourUpdateVM
    {
        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public string description { get; set; }


        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public int tourPrice { get; set; }


        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public int maxGuest { get; set; }


    }
}
