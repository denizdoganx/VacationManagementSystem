using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManagementSystem.Models
{
    public class Card
    {

        public int ID { get; set; }
        public string nameOnCard { get; set; }
        public string cardNumber { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public int CVC { get; set; }

        [ForeignKey(nameof(Customer))]
        public int customerID { get; set; }
        public Customer customer { get; set; }
    }
}
