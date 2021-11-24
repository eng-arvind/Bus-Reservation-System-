using BusReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BusReservationSystem.DAL
{
    public class UserRegImpl : iUserRegistration
    {
        BRSDBContext db = new();
        public bool Register(UserReg newUser)
        {
            db.Add(newUser);
            return db.SaveChanges() == 1;
        }
    }
}
