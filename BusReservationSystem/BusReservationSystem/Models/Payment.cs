using System;
using System.Collections.Generic;

#nullable disable

namespace BusReservationSystem.Models
{
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public string UserEmail { get; set; }
        public int? BookId { get; set; }
        public decimal? TotalAmt { get; set; }
        public string PayMode { get; set; }

        public virtual Booking Book { get; set; }
    }
}
