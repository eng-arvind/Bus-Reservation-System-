using System;
using BusReservationSystem.Exceptions;
namespace TestBusReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
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

        }

    }
}
