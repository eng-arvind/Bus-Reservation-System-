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
            user.FirstName = "Karthik";
            user.LastName = "K S";
            user.UserEmail = "3420karthik@gmail.com";
            user.UserMob = "8277398693";
            user.Pswd = "Karthik@123$";

            if (iuser.Register(user)) Console.WriteLine("User Added Successfully");
            else Console.WriteLine("There is an problem while adding the user");
        }

        
    }
}
