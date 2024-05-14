using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManagementSystem.Models.ViewModels
{
    public class CombinedPacketOfAirlineFlightCard
    {
        public int airlineID { get; set; }
        public int flightID { get; set; }
        
        public Card card { get; set; }
    }
}
