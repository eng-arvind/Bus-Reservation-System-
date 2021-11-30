using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationSystem.Models;

namespace BusReservationSystem.DAL
{
    public interface IAuthUser
    {
        public UserReg Login(Lgn lg);
        public bool AddMoneyWallet(ADJ adj);
        public List<Booking> GetLastReservations(UserReg user);
        public bool UpdateProfile(UserReg updated, string email);

        public UserReg GetProfile(UserReg user);
        public bool ResetPassword(UserReg updated, string email);

    }
}
