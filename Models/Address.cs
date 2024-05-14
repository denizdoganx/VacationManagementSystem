using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManagementSystem.Models
{
    public class Address
    {
        [Key]
        public int ID { get; set; }
        public string postalCode { get; set; }
        public string addressText { get; set; }



        [ForeignKey(nameof(Customer))]
        public int customerID { get; set; }
        public Customer customer { get; set; }



        [ForeignKey(nameof(Country))]
        public int countryID { get; set; }
        public Country country { get; set; }



        [ForeignKey(nameof(City))]
        public int cityID { get; set; }
        public City city { get; set; }



        [ForeignKey(nameof(Town))]
        public int townID { get; set; }
        public Town town { get; set; }



        [ForeignKey(nameof(District))]
        public int districtID { get; set; }
        public District district { get; set; }
    }
}
