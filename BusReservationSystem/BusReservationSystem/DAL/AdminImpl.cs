using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationSystem.Models;
using BusReservationSystem.Exceptions;
namespace BusReservationSystem.DAL
{
    public class AdminImpl : IAdmin
    {
        BRSDBContext db = new();
        public List<Bus> GetAllBus()
        {
            var res = db.buses.ToList();
            return res;
        }
        public List<Route> GetAllRoute()
        {
            var res = db.Routes.ToList();
            return res;
        }
        public List<Schedule> GetAllSchedule()
        {
            var res = db.Schedules.ToList();
            return res;
        }
        public bool DeleteBus(int busId)
        {
            var res = db.buses.Where(x => x.BusId == busId).FirstOrDefault();
            if (res == null) throw new BusNotFound("Bus not found");
            var sch = db.Schedules.Where(x => x.BusId == res.BusId).ToList();
            foreach(var s in sch)
            {
                s.BusId = null;
            }
            db.SaveChanges();
            db.Remove(res);
            var op = db.SaveChanges();
            if (op >=1)
                return true;
            else
                return false;

           /* throw new NotImplementedException();*/
        }

        public bool DeleteRoute(int routeId)
        {
            var res = db.Routes.Where(x => x.RouteId == routeId).FirstOrDefault();
            if (res == null) throw new RouteNotFound($"Route with route id {routeId} is not found");
            var rt = db.Schedules.Where(x => x.RouteId == res.RouteId).ToList();
            foreach (var s in rt)
            {
                s.BusId = null;
            }
            db.SaveChanges();
            db.Remove(res);
            var op = db.SaveChanges();
            if (op >= 1)
                return true;
            else
                return false;
          /*  throw new NotImplementedException();*/
        }

        public bool DeleteSchedule(int schId)
        {
            var res = db.Schedules.Where(x => x.ScheduleId == schId).FirstOrDefault();
            if (res == null) throw new ScheduleNotFound($"Schedule with schedule id {schId} is not found");
            var dsc = db.Bookings.Where(x => x.ScheduleId == res.ScheduleId).ToList();
            foreach (var s in dsc)
            {
                s.ScheduleId = null;
            }
            db.SaveChanges();
            db.Remove(res);
            var op = db.SaveChanges();
            if (op >= 1)
                return true;
            else
                return false;
           /* throw new NotImplementedException();*/
        }

        public List<UserReg> GetRegUserNotBookedYet()
        {
            var res = (from d in db.UserRegs
                      where !(db.Bookings.Any(x => x.UserEmail == d.UserEmail))
                      select d).ToList();
            return res;

          /*  throw new NotImplementedException();*/
        }

        public bool InsertBus(Bus newbus)
        {
            db.buses.Add(newbus);
            var res = db.SaveChanges();
            if (res == 1)
                return true;
            else
                return false;
           /* throw new NotImplementedException();*/
        }

        public bool InsertRoute(Route newRoute)
        {
            db.Routes.Add(newRoute);
            var res = db.SaveChanges();
            if (res == 1)
                return true;
            else
                return false;
           /* throw new NotImplementedException();*/
        }

        public bool InsertSchedule(Schedule newSch)
        {
            db.Schedules.Add(newSch);
            var res = db.SaveChanges();
            if (res == 1)
                return true;
            else
                return false;
            /* throw new NotImplementedException();*/
        }

        public AdminMaster IsAdmin(AdminMaster obj)
        {
          if(obj.UserName == "Admin" && obj.UsrPswd == "Admin")
            {
                return db.AdminMasters.Where(x => x.UserName == "Admin").FirstOrDefault();
            }
            return null;
        }

        public decimal LastMnthProfit()
        {
            var res = (from s in db.Schedules
                               join b in db.Bookings on s.ScheduleId equals b.ScheduleId
                               where s.JrnyDate.Month == DateTime.Now.Month-1 && s.JrnyDate.Year == DateTime.Now.Year && b.BookStatus=="Booked"
                               select b).ToList();
            decimal totalfare = 0;
            foreach(var fare in res)
            {
                totalfare += Convert.ToDecimal(fare.Tcharge);
            }
            return totalfare;
            /*throw new NotImplementedException();*/
        }

        public Bus PrefferedTypeOfBus()
        {
            Dictionary<int?, int> bookings = new();
            foreach (var b in db.Bookings.ToList())
            {
               // int value;
                if (bookings.ContainsKey(b.ScheduleId)==true)
                    bookings[b.ScheduleId]++;
                else
                    bookings[b.ScheduleId] = 1;
            }
            int maxcount = bookings.Max(x => x.Value);
            int? maxbooking = 0;
           /* Console.WriteLine(maxcount);*/
            foreach (var k in bookings)
            {
                if (k.Value == maxcount)
                {
                    maxbooking = k.Key;
                    break;
                }

            }
            int res =Convert.ToInt32(db.Schedules.Where(x => x.ScheduleId == maxbooking).FirstOrDefault().BusId);
            return db.buses.Where(x => x.BusId == res).FirstOrDefault();
            /*throw new NotImplementedException();*/
        }

        public List<Booking> ResDetailsOFCust(DateTime jDate)
        {
            var res = (from b in db.Bookings
                       join s in db.Schedules
                       on b.ScheduleId equals s.ScheduleId
                       where s.JrnyDate == jDate
                       select b).ToList();
            return res;
           /* throw new NotImplementedException();*/
        }

        public Route RouteWithMaxReservation()
        {
            Dictionary<int?, int> bookings = new();
            foreach (var b in db.Bookings.ToList())
            {
                if (bookings.ContainsKey(b.ScheduleId) == true)
                    bookings[b.ScheduleId]++;
                else
                    bookings[b.ScheduleId] = 1;
            }
            int maxcount = bookings.Max(x => x.Value);
            int? maxbooking = 0;
            foreach (var k in bookings)
            {
                if (k.Value == maxcount)
                {
                    maxbooking = k.Key;
                    break;
                }

            }
            int res = Convert.ToInt32(db.Schedules.Where(x => x.ScheduleId == maxbooking).FirstOrDefault().RouteId);
            return db.Routes.Where(x => x.RouteId == res).FirstOrDefault();
           /* throw new NotImplementedException();*/
        }

        public bool UpdateBus(Bus updateBus, int busId)
        {
            var olddata = db.buses.Where(x => x.BusId == busId).FirstOrDefault();
            olddata.BusName = updateBus.BusName;
            olddata.TotalSeats = updateBus.TotalSeats;
            var res = db.SaveChanges();
            if (res == 1)
                return true;
            else
                return false;
            /* throw new NotImplementedException();*/
        }

        public bool UpdateRoute(Route updateRoute, int routeId)
        {
            var olddata = db.Routes.Where(x => x.RouteId == routeId).FirstOrDefault();
            olddata.Arrive = updateRoute.Arrive;
            olddata.Dest = updateRoute.Dest;
            var res = db.SaveChanges();
            if (res == 1)
                return true;
            else
                return false;
            /* throw new NotImplementedException();*/
        }

        public bool UpdateSchedule(Schedule updateSch, int schId)
        {
            var olddata = db.Schedules.Where(x => x.ScheduleId == schId).FirstOrDefault();
            olddata.JrnyDate = updateSch.JrnyDate;
            olddata.Fare = updateSch.Fare;
            olddata.BusId = updateSch.BusId;
            olddata.RouteId = updateSch.RouteId;
            olddata.SeatAvl = updateSch.SeatAvl;
            var res = db.SaveChanges();
            if (res == 1)
                return true;
            else
                return false;
           /* throw new NotImplementedException();*/
        }
    }
}
