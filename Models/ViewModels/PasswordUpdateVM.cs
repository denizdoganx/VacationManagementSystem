using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManagementSystem.Models.ViewModels
{
    public class PasswordUpdateVM
    {
        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public string oldPassword { get; set; }
        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public string newPassword { get; set; }
        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public string newPasswordAgain { get; set; }
    }
}
