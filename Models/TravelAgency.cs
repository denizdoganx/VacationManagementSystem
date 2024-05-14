using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManagementSystem.Models
{
    public class TravelAgency
    {
        [Key]
        public int ID { get; set; }
        public string name { get; set; }
        public int totalStarNumber { get; set; }






        public ICollection<Tour> tours { get; set; }
    }
}
