using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationSystem.Models;

namespace BusReservationSystem.DAL
{
    public class AdminImpl : IAdmin
    {
        BRSDBContext db = new();
        public bool DeleteBus(int busId)
        {
            var res = db.buses.Where(x => x.BusId == busId).FirstOrDefault();
            db.buses.Remove(res);
            var op = db.SaveChanges();
            if (op == 1)
                return true;
            else
                return false;

           /* throw new NotImplementedException();*/
        }

        public bool DeleteRoute(int routeId)
        {
            var res = db.Routes.Where(x => x.RouteId == routeId).FirstOrDefault();
            db.Routes.Remove(res);
            var op = db.SaveChanges();
            if (op == 1)
                return true;
            else
                return false;
          /*  throw new NotImplementedException();*/
        }

        public bool DeleteSchedule(int schId)
        {
            var res = db.Schedules.Where(x => x.ScheduleId == schId).FirstOrDefault();
            db.Schedules.Remove(res);
            var op = db.SaveChanges();
            if (op == 1)
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

        public bool IsAdmin(string adminName, string pswd)
        {
            return (adminName == "Admin" && pswd == "Admin");
        }

        public decimal LastMnthProfit()
        {
            var res = (from s in db.Schedules
                               join b in db.Bookings on s.ScheduleId equals b.ScheduleId
                               where s.JrnyDate.Month == DateTime.Now.Month-1 && s.JrnyDate.Year == DateTime.Now.Year
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
            Dictionary<int, int> bookings = new();
            foreach (var b in db.Bookings.ToList())
            {
                bookings[(int)b.ScheduleId]++;
            }
            int maxcount = bookings.Max(x => x.Value);
            int maxbooking = 0;
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
            Dictionary<int, int> bookings = new();
            foreach (var b in db.Bookings.ToList())
            {
                bookings[(int)b.ScheduleId]++;
            }
            int maxcount = bookings.Max(x => x.Value);
            int maxbooking = 0;
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
            var res = db.SaveChanges();
            if (res == 1)
                return true;
            else
                return false;
           /* throw new NotImplementedException();*/
        }
    }
}
