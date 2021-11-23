using System;
using System.Collections.Generic;

#nullable disable

namespace BusReservationSystem.Models
{
    public partial class Route
    {
        public Route()
        {
            Schedules = new HashSet<Schedule>();
        }

        public int RouteId { get; set; }
        public string Arrive { get; set; }
        public string Dest { get; set; }

        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
