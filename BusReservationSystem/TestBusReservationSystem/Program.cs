using System;
using BusReservationSystem.Exceptions;
using BusReservationSystem.Models;
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

                ADJ adj = new() { Arrive = "Bangalore", Dest = "Chennai", JrnyDate = "4/3/2020" };
                TestTicket.SearchBus(adj);
                //TestTicket.BusReserve();
                //TestTicket.CancelTicket(23);
                //TestTicket.UpdateSchedule();
                //TestTicket.GetTicketDet(11);
                //**********************************

                //*************************************
                //TestAuthUser.userlogin();
                //TestAuthUser.GetReservations();
                //TestAuthUser.getuser();
                //TestAuthUser.Profileupdate();
                //TestAuthUser.AddMoneytoWallet();
                //TestAuthUser.PasswordReset();
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
