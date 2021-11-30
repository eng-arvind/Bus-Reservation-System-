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

        public bool AddMoneyWallet(ADJ dJ)
        {
            dJ.user.Wallet += dJ.amt;
            db.Update(dJ.user);
            return db.SaveChanges()>=1;
        }

        public List<Booking> GetLastReservations(UserReg user)
        {
            return db.Bookings.Where(x => x.UserEmail == user.UserEmail).ToList();
        }

        public UserReg GetProfile(UserReg user)
        {
            return user;
        }

        public UserReg Login(Lgn lg)
        {
            //Login
            var user = db.UserRegs.Where(x => x.UserEmail == lg.UserEmail && x.Pswd==lg.Password).FirstOrDefault();
            if (user == null) throw new UserNotFound($"The user with {lg.UserEmail} email id is not regestered");
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
