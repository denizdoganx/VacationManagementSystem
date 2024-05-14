using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManagementSystem.Models.ViewModels
{
    public class CustomerSignUpVM
    {
        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        [EmailAddress(ErrorMessage = "Enter a correct email address !!!")]
        public string email { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public string password { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public string name { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public string surname { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public string phoneNumber { get; set; }
    }
}
