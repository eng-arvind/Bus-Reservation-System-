using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusReservationSystem.DAL;
using BusReservationSystem.Models;
namespace TestBusReservationSystem
{
    class TestUserReg
    {

        static iUserRegistration iuser = new UserRegImpl();
        static UserReg user = new();
        public static void UserRegister()
        {
            user.FirstName = "Nitish";
            user.LastName = "NS";
            user.UserEmail = "342Nitish@gmail.com";
            user.UserMob = "956896483";
            user.Pswd = "Manish@123$";

            if (iuser.Register(user)) Console.WriteLine("User Added Successfully");
            else Console.WriteLine("There is an problem while adding the user");
        }

        
    }
}
