using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationSystem;
using BusReservationSystem.DAL;
using BusReservationSystem.Models;

namespace BusReservationSystem.Controllers
{
    [Route("api/AdminAPI")]
    [ApiController]
    public class AdminAPIController : ControllerBase
    {
        IAdmin a;
        BRSDBContext db = new();
        [HttpDelete]
        //we are defining URL for every method, In api term it is called  Route
        [Route("/api/AdminAPI/deleteBus/{id}")]
        public bool Delete(int bid)
        {
            return a.DeleteBus(bid);
        }
        [HttpDelete]
        [Route("/api/AdminAPI/deleteRoute/{id}")]
        [ActionName("Delete")]
        public bool DeleteRoute(int rid)
        {
            return a.DeleteRoute(rid);
        }
        [HttpDelete]
        [Route("/api/AdminAPI/deleteSchedule/{id}")]
        [ActionName("Delete")]
        public bool DeleteSch(int sid)
        {
            return a.DeleteSchedule(Convert.ToInt32(sid));
        }
        [HttpGet]
        [Route("/api/AdminAPI/GetRegUNotBookedYet")]
        public List<UserReg> Get()
        {
            return a.GetRegUserNotBookedYet();
        }
        [HttpPost]
        [Route("/api/AdminAPI/insertBus")]
        public bool Post(Bus bs)
        {
            return a.InsertBus(bs);
        }
        [HttpPost]
        [Route("/api/AdminAPI/insertRoute")]
        public bool Post(Route rt)
        {
            return a.InsertRoute(rt);
        }
        [HttpPost]
        [Route("/api/AdminAPI/insertSch")]
        public bool Post(Schedule sc)
        {
            return a.InsertSchedule(sc);
        }
        [HttpPost]
        [Route("/api/AdminAPI/IsAdmin/{name}/{pass}")]
        public bool Post(string name,string pass)
        {
            return a.IsAdmin(name, pass);
        }
        [HttpGet]
        [Route("/api/AdminAPI/LastMonthProfit")]
        [ActionName("Get")]
        public decimal GetLstMProf()
        {
            return a.LastMnthProfit();
        }

        [HttpGet]
        [Route("/api/AdminAPI/PreferedTypeOfBus")]
        [ActionName("Get")]
        public Bus GetPrefBus()
        {
            return a.PrefferedTypeOfBus();
        }
        [HttpPost]
        [Route("/api/AdminAPI/RestDetailsOFCust")]
        public List<Booking> Post(DateTime dt)
        {
            return a.ResDetailsOFCust(dt);
        }

        [HttpGet]
        [Route("/api/AdminAPI/RouteWithMxReservation")]
        [ActionName("Get")]
        public Route GetRtwithMxRes()
        {
            return a.RouteWithMaxReservation();
        }
        [HttpPut]
        [Route("/api/AdminAPI/updateBus")]
        public bool Put(Bus obj, int bid)
        {
            return a.UpdateBus(obj, bid);
        }
        [HttpPut]
        [Route("/api/AdminAPI/updateRoute")]
        public bool Put(Route obj, int rid)
        {
            return a.UpdateRoute(obj, rid);
        }
        [HttpPut]
        [Route("/api/AdminAPI/updateSchedule")]
        public bool Put(Schedule obj, int sid)
        {
            return a.UpdateSchedule(obj, sid);
        }
    }
}
