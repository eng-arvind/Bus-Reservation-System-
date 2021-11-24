using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservationSystem.Exceptions
{
    public class UserNotFound:Exception
    {
        public UserNotFound(string msg) : base(msg) { }
    }
}
