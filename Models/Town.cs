using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManagementSystem.Models
{
    public class Town
    {
        [Key]
        public int ID { get; set; }
       
        public string townName { get; set; }


        [ForeignKey(nameof(City))]
        public int cityID { get; set; }
        public City city { get; set; }


        public ICollection<Address> addresses { get; set; }
        public ICollection<District> districts { get; set; }
    }
}
