using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManagementSystem.Models.ViewModels
{
    public class HotelAddVM
    {
        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public string name { get; set; }



        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public int totalRoomNumber { get; set; }



        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public string countryName { get; set; }



        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public string cityName { get; set; }




        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public string townName { get; set; }



        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public string districtName { get; set; }



        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public string postalCode { get; set; }



        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public string addressText { get; set; }




    }
}
