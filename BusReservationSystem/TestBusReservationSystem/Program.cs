using System;
using BusReservationSystem.Exceptions;
namespace TestBusReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            try
            {
                /* TestUserReg.UserRegister();*/
                /*TestAdmin.InsertBuses();*/
                /* TestAdmin.InsertRoute();*/
                /* TestAdmin.InsertSchedule();*/
                /* TestAdmin.isAdmine();*/
                /* TestAdmin.LastMonthProf();*/
                /* TestAdmin.preferedBusType();*/
                /* TestAdmin.RouteMaxReservation();*/
                /* TestAdmin.GetRegUNotBookedYet();*/
                /*TestAdmin.ReservDetailsOFCust();*/
                /*  TestAdmin.UpdateBuses();*/
                /* TestAdmin.UpdateRoutes();*/
                /*TestAdmin.UpdateSch();*/
                /*TestAdmin.DelBus();*/
                /* TestAdmin.DelRoute();*/
                TestAdmin.DelSchedule();
            }
            catch(BusNotFound b)
            {
                Console.WriteLine(b.Message);
            }
=======
            //TestUserReg.UserRegister();
            TestAuthUser.Userlogin();
>>>>>>> ae7c24f7ad2f91d35ee78fe05cc39233f78c9391
        }

    }
}
