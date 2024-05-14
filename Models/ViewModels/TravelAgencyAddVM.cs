using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManagementSystem.Models.ViewModels
{
    public class TravelAgencyAddVM
    {


        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public string name { get; set; }
    }
}
