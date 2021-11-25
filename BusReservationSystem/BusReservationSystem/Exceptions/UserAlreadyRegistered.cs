using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservationSystem.Exceptions
{
    public class UserAlreadyRegistered : Exception
    {
        public UserAlreadyRegistered(string message) : base(message)
        {
        }
    }
}
