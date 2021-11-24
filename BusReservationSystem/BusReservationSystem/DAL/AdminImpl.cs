using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationSystem.Models;

namespace BusReservationSystem.DAL
{
    public class AdminImpl : IAdmin
    {
        readonly BRSDBContext db;
        public AdminImpl(BRSDBContext db)
        {
            this.db = db;
        }
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
            /*  var res = from d in db.UserRegs
                        join b in db.Bookings
                        on d.UserEmail equals b.UserEmail
                        select d;*/
            throw new NotImplementedException();
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

        public decimal LastMnthProfit()
        {
            throw new NotImplementedException();
        }

        public List<Bus> PrefferedTypeOfBus()
        {
            throw new NotImplementedException();
        }

        public List<Booking> ResDetailsOFCust()
        {
            throw new NotImplementedException();
        }

        public Route RouteWithMaxReservation()
        {
            throw new NotImplementedException();
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
