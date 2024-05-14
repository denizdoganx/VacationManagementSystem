using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManagementSystem.Models
{
    public class Adminastrator
    { 
        [Key]
        public int ID { get; set; }



        [ForeignKey(nameof(User))]
        public int userID { get; set; }
        public User user { get; set; }
        
    }
}
