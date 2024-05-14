using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManagementSystem.Models.ViewModels
{
    public class FlightAddVM
    {
        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public string airlineName { get; set; }


        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public string from { get; set; }


        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public string to { get; set; }


        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public int price { get; set; }


        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public DateTime arrivalTime { get; set; }


        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public DateTime depertureTime { get; set; }



        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public string destination { get; set; }



        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public int capacity { get; set; }
        
    }
}
