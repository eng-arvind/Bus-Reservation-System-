using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationSystem.Models;

namespace BusReservationSystem.DAL
{
    public interface iUserRegistration
    {
        public bool Register(UserReg newUser);
    }
}
