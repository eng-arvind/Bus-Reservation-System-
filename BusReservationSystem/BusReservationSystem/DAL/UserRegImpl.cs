using BusReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationSystem.Exceptions;


namespace BusReservationSystem.DAL
{
    public class UserRegImpl : iUserRegistration
    {
        BRSDBContext db = new();
        public bool Register(UserReg newUser)
        {
            var oldUser = db.UserRegs.Where(x => x.UserEmail == newUser.UserEmail).FirstOrDefault();
            if (oldUser != null) throw new UserAlreadyRegistered($"User with {newUser.UserEmail} emailId is already registered");
            db.Add(newUser);
            return db.SaveChanges() == 1;
        }
    }
}
