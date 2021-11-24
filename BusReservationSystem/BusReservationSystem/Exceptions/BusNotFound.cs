using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservationSystem.Exceptions
{
    public class BusNotFound:Exception
    {
        public BusNotFound(string msg) : base(msg) { }
    }
}
