using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManagementSystem.Models.ViewModels
{
    public class FlightListVM
    {

        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public string from { get; set; }


        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public string to { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public DateTime depertureTime { get; set; }

    }
}
