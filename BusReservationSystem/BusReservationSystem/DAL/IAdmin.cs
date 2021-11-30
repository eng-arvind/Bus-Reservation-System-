using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationSystem.Models;

namespace BusReservationSystem.DAL
{
   public interface IAdmin
    {
        public AdminMaster IsAdmin(AdminMaster admn);
        public bool InsertBus(Bus newbus);
        public List<Bus> GetAllBus();
        public bool InsertRoute(Route newRoute);
        public List<Route> GetAllRoute();
        public bool InsertSchedule(Schedule newSch);
        public List<Schedule> GetAllSchedule();
        public bool UpdateBus(Bus updateBus, int busId);
        public bool UpdateRoute(Route updateRoute, int routeId);
        public bool UpdateSchedule(Schedule updateSch, int schId);
        public bool DeleteBus(int busId);
        public bool DeleteRoute(int routeId);
        public bool DeleteSchedule(int schId);
        public List<UserReg> GetRegUserNotBookedYet();
        public Bus PrefferedTypeOfBus();
        public decimal LastMnthProfit();
        public Route RouteWithMaxReservation();
        public List<Booking> ResDetailsOFCust(DateTime jDate);
    }
}
