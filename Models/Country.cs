using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManagementSystem.Models
{
    public class Country
    {
        [Key]
        public int ID { get; set; }
        public string countryName { get; set; }


        public ICollection<Address> addresses { get; set; }

        public ICollection<City> cities { get; set; }
    }
}
