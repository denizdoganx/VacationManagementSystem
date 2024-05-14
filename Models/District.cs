using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManagementSystem.Models
{
    public class District
    {
        [Key]
        public int ID { get; set; }
        public string districtName { get; set; }


        [ForeignKey(nameof(Town))]
        public int townID { get; set; }
        public Town town { get; set; }


        public ICollection<Address> addresses { get; set; }
    }
}
