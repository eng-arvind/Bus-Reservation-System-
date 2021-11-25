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
            user.FirstName = "Deepu";
            user.LastName = "A N";
            user.UserEmail = "Deepu@gmail.com";
            user.UserMob = "8277398667";
            user.Pswd = "Deepu@123$";

            if (iuser.Register(user)) Console.WriteLine("User Added Successfully");
            else Console.WriteLine("There is an problem while adding the user");
        }

        
    }
}
