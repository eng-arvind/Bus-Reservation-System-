using System;
using System.Collections.Generic;

#nullable disable

namespace BusReservationSystem.Models
{
    public partial class AdminMaster
    {
        public int AdminId { get; set; }
        public string UserName { get; set; }
        public string UsrPswd { get; set; }
    }
}
