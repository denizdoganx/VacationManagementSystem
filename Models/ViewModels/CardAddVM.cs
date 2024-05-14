using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManagementSystem.Models.ViewModels
{
    public class CardAddVM
    {
        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public string nameOnCard { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public string cardNumber { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public int month { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public int year { get; set; }


        [Required(ErrorMessage = "This field cannot be left blank !!!")]
        public int CVC { get; set; }
    }
}
