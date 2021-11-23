using System;
using System.Collections.Generic;

#nullable disable

namespace BusReservationSystem.Models
{
    public partial class Booking
    {
        public Booking()
        {
            Payments = new HashSet<Payment>();
            Seats = new HashSet<Seat>();
        }

        public int BookId { get; set; }
        public int? ScheduleId { get; set; }
        public string UserEmail { get; set; }
        public string UserMob { get; set; }
        public int Npassengers { get; set; }
        public decimal? Tcharge { get; set; }
        public string IdProof { get; set; }
        public string BookStatus { get; set; }
        public bool? Registered { get; set; }

        public virtual Schedule Schedule { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Seat> Seats { get; set; }
    }
}
