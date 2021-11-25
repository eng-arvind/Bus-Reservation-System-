using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservationSystem.Models
{
    public class BusScheduleJoin
    {
        public int BusId { get; set; }
        public string BusName { get; set; }
        public int ScheduleId { get; set; }
        public int? RouteId { get; set; }
        public DateTime JourneyDate { get; set; }
        public int? SeatAvail { get; set; }
        public decimal? Fare { get; set; }
    }
}
