using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusReservationSystem.DAL;
using BusReservationSystem.Models;

namespace TestBusReservationSystem
{
    class TestAdmin
    {
        static IAdmin admin = new AdminImpl();
        static Bus bus = new();
        static Route route = new();
        static Schedule sch = new();
        public static void InsertBuses()
        {
            bus.BusName = "Sarathi";
            bus.TotalSeats = 30;
            if(admin.InsertBus(bus))
                Console.WriteLine("Bus Inserted Successfully!");
            else
                Console.WriteLine("Bus Not Inserted");
        }
        public static void InsertRoute()
        {
            route.Arrive = "Kanpur";
            route.Dest = "Delhi";
            if (admin.InsertRoute(route))
                Console.WriteLine("Route Inserted Successfully!");
            else
                Console.WriteLine("Route Not Inserted");
        }
        public static void InsertSchedule()
        {
            sch.RouteId = 1;
            sch.JrnyDate = DateTime.Now.Date;
            sch.BusId = 1;
            sch.SeatAvl = 25;
            sch.Fare = 300;
            if (admin.InsertSchedule(sch))
                Console.WriteLine("Schedule Inserted Successfully!");
            else
                Console.WriteLine("Schedule Not Inserted");
        }

        //public static void isAdmine()
        //{
        //    if (admin.IsAdmin("Admin","Admin"))
        //        Console.WriteLine("Login Successfully!");
        //    else
        //        Console.WriteLine(" Not Login");
        //}

        public static void LastMonthProf()
        {
            decimal amount = admin.LastMnthProfit();
            if(amount>0)
                Console.WriteLine("Amount:"+amount);
            else
                Console.WriteLine("No Data Found");
        }
        public static void preferedBusType()
        {
            Bus bs = admin.PrefferedTypeOfBus();
            if (bs.BusName!="")
                Console.WriteLine("Bus Name:" + bs.BusName);
            else
                Console.WriteLine("No Bus Found");
        }

        public static void RouteMaxReservation()
        {
            Route rt = admin.RouteWithMaxReservation();
            if (rt !=null )
                Console.WriteLine("Route Name:" + rt.Arrive+"->"+rt.Dest);
            else
                Console.WriteLine("No Route Found");
        }
        public static void GetRegUNotBookedYet()
        {
            List<UserReg> ures = admin.GetRegUserNotBookedYet();
            foreach(var u in ures)
            {
                Console.WriteLine("User=>"+u.UserEmail);
            }
        }
        public static void ReservDetailsOFCust()
        {
            List<Booking> blst = admin.ResDetailsOFCust(Convert.ToDateTime("11/29/2021"));
            foreach (var b in blst)
            {
                Console.WriteLine("User=>"+b.UserEmail+"status:" + b.BookStatus+"Fare:"+b.Tcharge);
            }

        }
        public static void UpdateBuses()
        {
            bus.BusName = "RTV";
            bus.TotalSeats = 34;
            if(admin.UpdateBus(bus, 1))
            {
                Console.WriteLine("Bus Updated Successfully");
            }
            else
                Console.WriteLine("Bus not updated");
        }
        public static void UpdateRoutes()
        {
            route.Arrive = "Simla";
            route.Dest = "Jammu";
            if (admin.UpdateRoute(route, 4))
            {
                Console.WriteLine("Route Updated Successfully");
            }
            else
                Console.WriteLine("Route not updated");
        }
        public static void UpdateSch()
        {
            sch.RouteId = 2;
            sch.JrnyDate = Convert.ToDateTime("11/27/2021");
            sch.BusId = 3;
            sch.Fare = 350;
            if (admin.UpdateSchedule(sch, 2))
            {
                Console.WriteLine("Scedule Updated Successfully");
            }
            else
                Console.WriteLine("Schedule not updated");
        }
        public static void DelBus()
        {
            if(admin.DeleteBus(1))
            {
                Console.WriteLine("Bus Deleted Successfully");
            }
            else
                Console.WriteLine("Bus not deleted");
        }
        public static void DelRoute()
        {
            if (admin.DeleteRoute(7))
            {
                Console.WriteLine("Route Deleted Successfully");
            }
            else
                Console.WriteLine("Route not deleted");
        }
        public static void DelSchedule()
        {
            if(admin.DeleteSchedule(3))
            {
                Console.WriteLine("Schedule deleted successfully");
            }
            else
                Console.WriteLine("Not deleted");
        }
    }
}
