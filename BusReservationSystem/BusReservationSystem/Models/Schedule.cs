using System;
using System.Collections.Generic;

#nullable disable

namespace BusReservationSystem.Models
{
    public partial class Schedule
    {
        public Schedule()
        {
            Bookings = new HashSet<Booking>();
        }

        public int ScheduleId { get; set; }
        public int? RouteId { get; set; }
        public DateTime JrnyDate { get; set; }
        public int? BusId { get; set; }
        public int? SeatAvl { get; set; }
        public decimal? Fare { get; set; }

        public virtual Bus Bus { get; set; }
        public virtual Route Route { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
