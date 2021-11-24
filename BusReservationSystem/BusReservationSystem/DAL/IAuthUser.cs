using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationSystem.Models;

namespace BusReservationSystem.DAL
{
    public interface IAuthUser
    {
        public UserReg Login(String email, string password);
        public bool AddMoneyWallet(String email, decimal amt);
        public List<Booking> GetLastReservations(string email);
        public bool UpdateProfile(UserReg updated, string email);

        public UserReg GetProfile(String email);
        public bool ResetPassword(UserReg updated, string email);

    }
}
