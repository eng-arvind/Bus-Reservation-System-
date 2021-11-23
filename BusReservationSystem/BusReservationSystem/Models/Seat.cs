using System;
using System.Collections.Generic;

#nullable disable

namespace BusReservationSystem.Models
{
    public partial class Seat
    {
        public int SeatId { get; set; }
        public int RefId { get; set; }
        public int? BookId { get; set; }

        public virtual Booking Book { get; set; }
    }
}
