﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManagementSystem.Models
{
    public class Airline
    {
        [Key]
        public int ID { get; set; }
        public string name { get; set; }
        public ICollection<Flight> flights { get; set; }

    }
}
