using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservationSystem.Exceptions
{
    public class RouteNotFound : Exception
    {
        public RouteNotFound(string message) : base(message)
        {
        }
    }
}
