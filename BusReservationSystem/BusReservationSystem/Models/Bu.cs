using System;
using System.Collections.Generic;

#nullable disable

namespace BusReservationSystem.Models
{
    public partial class Bu
    {
        public Bu()
        {
            Schedules = new HashSet<Schedule>();
        }

        public int BusId { get; set; }
        public string BusName { get; set; }
        public int TotalSeats { get; set; }

        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
