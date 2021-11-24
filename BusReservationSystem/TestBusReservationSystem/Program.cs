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
                //**********************************
                //Admin Modules

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
                //TestAdmin.DelSchedule();
                //***********************************

                //**********************************
                //UserRegistraion Module

                //TestUserReg.UserRegister();
                //**********************************

                //**********************************
                // Ticket Modules

                //TestTicket.SearchBus("Bangalore", "Chennai", Convert.ToDateTime("4/3/2020"));
                //TestTicket.BusReserve();
                //TestTicket.CancelTicket(23);
                //TestTicket.UpdateSchedule();
                TestTicket.GetTicketDet(10);
                //**********************************

            }
            catch(BusNotFound b)
            {
                Console.WriteLine(b.Message);
            }
            catch (UserNotFound u)
            {
                Console.WriteLine(u.Message);
                return;
            }
        }

    }
}
