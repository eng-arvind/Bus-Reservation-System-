using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationSystem.Models;
using BusReservationSystem.Exceptions;

namespace BusReservationSystem.DAL
{
    public class AuthUserImpl: IAuthUser
    {
        BRSDBContext db = new BRSDBContext();

        public bool AddMoneyWallet(string email, decimal amt)
        {
            var user = db.UserRegs.Where(x => x.UserEmail == email).FirstOrDefault();
            user.Wallet += amt;
            return user.Wallet > 0;
        }

        public List<Booking> GetLastReservations(string email)
        {
            var user = db.UserRegs.Where(x => x.UserEmail == email).FirstOrDefault();
            if (user == null) throw new UserNotFound($"The user with {email} email id is not regestered");
            return db.Bookings.Where(x => x.UserEmail == user.UserEmail).ToList();
        }

        public UserReg GetProfile(string email)
        {
            var user = db.UserRegs.Where(x => x.UserEmail == email).FirstOrDefault();
            if (user == null) throw new UserNotFound($"The user with {email} email id is not regestered");
            return user;
        }

        public UserReg Login(string email, string password)
        {
            //Login
            var user = db.UserRegs.Where(x => x.UserEmail == email).FirstOrDefault();
            if (user == null) throw new UserNotFound($"The user with {email} email id is not regestered");
            return user;

        }

        public bool ResetPassword(UserReg updated, string email)
        {
            var user = db.UserRegs.Where(x => x.UserEmail == email).FirstOrDefault();
            user.Pswd = updated.Pswd;
            db.Update(user);
            return db.SaveChanges() == 1;
        }

        public bool UpdateProfile(UserReg updated, string email)
        {
            var user = db.UserRegs.Where(x => x.UserEmail == email).FirstOrDefault();
            user.FirstName = updated.FirstName;
            user.UserMob = updated.UserMob;
            user.UsrAddress = updated.UsrAddress;
            db.Update(user);
            return db.SaveChanges() == 1;
        }
    }
}
