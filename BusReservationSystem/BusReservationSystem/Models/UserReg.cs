using System;
using System.Collections.Generic;

#nullable disable

namespace BusReservationSystem.Models
{
    public partial class UserReg
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserEmail { get; set; }
        public string UserMob { get; set; }
        public string Pswd { get; set; }
        public decimal? Wallet { get; set; }
        public string UsrAddress { get; set; }
    }
}
