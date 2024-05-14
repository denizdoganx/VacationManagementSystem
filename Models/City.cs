using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManagementSystem.Models
{
    public class City
    {
        [Key]
        public int ID { get; set; }
        public string cityName { get; set; }


        [ForeignKey(nameof(Country))]
        public int countryID { get; set; }
        public Country country { get; set; }



        public ICollection<Address> addresses { get; set; }
        public ICollection<Town> towns { get; set; }
    }
}
