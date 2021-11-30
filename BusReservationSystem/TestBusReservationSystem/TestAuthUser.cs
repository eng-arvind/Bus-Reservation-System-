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
        static readonly ITicket ticket = new TicketImpl();
        static readonly UserReg user = ticket.GetUserByEmail("3420karthik@gmail.com");

        public static void userlogin()
        {
            Lgn lg = new();
            lg.UserEmail = "342nitish@gmail.com";
            lg.Password = "manish@123$";
            var user = iuser.Login(lg);
            if (user != null)
            {
                Console.WriteLine("login successful");

            }
        }
        public static void getuser()
        {
            var user1 = iuser.GetProfile(user);
            Console.WriteLine(user.FirstName);
            Console.WriteLine(user.LastName);
            Console.WriteLine(user.UserEmail);
            Console.WriteLine(user.UserMob);
            Console.WriteLine(user.UsrAddress);
            Console.WriteLine(user.Wallet);
        }
        public static void GetReservations()
        {
            var reservations = iuser.GetLastReservations(user);
            if(reservations==null || reservations.Count==0)
            {
                Console.WriteLine("No reservations found");
                return;
            }
            foreach(var m in reservations)
            {
                Console.WriteLine(m.BookId+". "+m.BookStatus);

            }

        }
        //public static void AddMoneytoWallet()
        //{
        //    bool added = iuser.AddMoneyWallet(user, 1000);
        //    if(added)
        //    {
        //        Console.WriteLine("Money added to wallet "+user.Wallet);
                
        //    }
        //    else
        //    {
        //        Console.WriteLine("Money not added to wallet");
        //    }
              
        //}
        public static void PasswordReset()
        {
            user.Pswd = "Krish6579$";
            bool changed = iuser.ResetPassword(user,user.UserEmail);
            if(changed)
            {
                Console.WriteLine("password is resetted");
            }
            else
            {
                Console.WriteLine("Password reset is not successful");
            }
        }
        public static void Profileupdate()
        {
            user.FirstName = "sohel";
            bool changed = iuser.UpdateProfile(user, user.UserEmail);
            if (changed)
            {
                Console.WriteLine("Profile got updated");
            }
            else
            {
                Console.WriteLine("Profile is not updated");
            }

        }
    }
}
