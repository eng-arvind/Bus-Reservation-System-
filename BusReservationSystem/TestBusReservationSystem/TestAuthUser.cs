using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusReservationSystem.DAL;
using BusReservationSystem.Models;

namespace TestBusReservationSystem
{
    class TestAuthUser
    {
        static readonly IAuthUser iuser = new AuthUserImpl();
        static readonly UserReg user = new();
        //public static void Userlogin()
        //{
        //    string useremail = "342Nitish@gmail.com";
        //    string Password = "Manish@123$";
        //    var user = iuser.Login(useremail, Password);
        //    if (user != null)
        //    {
        //        Console.WriteLine(user.FirstName);
        //        Console.WriteLine(user.LastName);
        //        Console.WriteLine(user.UserEmail);
        //        Console.WriteLine(user.UserMob);
        //        Console.WriteLine(user.UsrAddress);
        //        Console.WriteLine(user.Wallet);
        //    }




        //}
       
    }
}
