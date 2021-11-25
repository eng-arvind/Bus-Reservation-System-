using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservationSystem.Exceptions
{
    public class ScheduleNotFound : Exception
    {
        public ScheduleNotFound(string message) : base(message)
        {
        }
    }
}
