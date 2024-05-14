using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManagementSystem.Models
{
    public class User
    {
        public int ID { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int userLevel { get; set; }

        public Customer customer { get; set; }
        public Adminastrator adminastrator { get; set; }

    }
}
