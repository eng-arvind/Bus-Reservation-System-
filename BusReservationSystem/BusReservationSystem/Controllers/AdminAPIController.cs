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
        readonly IAdmin adm;
        readonly BRSDBContext db;

        public AdminAPIController(IAdmin it, BRSDBContext db)
        {
            this.adm = it;
            this.db = db;
        }
        [HttpGet]
        [Route("/api/AdminAPI/showAllbuses")]
        public List<Bus> Get()
        {
            return adm.GetAllBus();
        }
        [HttpGet]
        [Route("/api/AdminAPI/showAllroute")]
        [ActionName("Get")]
        public List<Route> Getroute()
        {
            return adm.GetAllRoute();
        }
        [HttpGet]
        [Route("/api/AdminAPI/showAllschedule")]
        [ActionName("Get")]
        public List<Schedule> Getsch()
        {
            return adm.GetAllSchedule();
        }
        [HttpDelete]
        //we are defining URL for every method, In api term it is called  Route
        [Route("/api/AdminAPI/deleteBus/{id}")]
        public bool Delete(int bid)
        {
            return adm.DeleteBus(bid);
        }
        [HttpDelete]
        [Route("/api/AdminAPI/deleteRoute/{id}")]
        [ActionName("Delete")]
        public bool DeleteRoute(int rid)
        {
            return adm.DeleteRoute(rid);
        }
        [HttpDelete]
        [Route("/api/AdminAPI/deleteSchedule/{id}")]
        [ActionName("Delete")]
        public bool DeleteSch(int sid)
        {
            return adm.DeleteSchedule(Convert.ToInt32(sid));
        }
        [HttpGet]
        [Route("/api/AdminAPI/GetRegUNotBookedYet")]
        [ActionName("Get")]
        public List<UserReg> Genotbyet()
        {
            return adm.GetRegUserNotBookedYet();
        }
        [HttpPost]
        [Route("/api/AdminAPI/insertBus")]
        public bool Post(Bus bs)
        {
            return adm.InsertBus(bs);
        }
        [HttpPost]
        [Route("/api/AdminAPI/insertRoute")]
        public bool Post(Route rt)
        {
            return adm.InsertRoute(rt);
        }
        [HttpPost]
        [Route("/api/AdminAPI/insertSch")]
        public bool Post(Schedule sc)
        {
            return adm.InsertSchedule(sc);
        }
        [HttpPost]
        [Route("/api/AdminAPI/IsAdmin")]
        public AdminMaster Post(AdminMaster obj)
        {
            return adm.IsAdmin(obj);
        }
        [HttpGet]
        [Route("/api/AdminAPI/LastMonthProfit")]
        [ActionName("Get")]
        public decimal GetLstMProf()
        {
            return adm.LastMnthProfit();
        }

        [HttpGet]
        [Route("/api/AdminAPI/PreferedTypeOfBus")]
        [ActionName("Get")]
        public Bus GetPrefBus()
        {
            return adm.PrefferedTypeOfBus();
        }
        [HttpPost]
        [Route("/api/AdminAPI/RestDetailsOFCust")]
        public List<Booking> Post(DateTime dt)
        {
            return adm.ResDetailsOFCust(dt);
        }

        [HttpGet]
        [Route("/api/AdminAPI/RouteWithMxReservation")]
        [ActionName("Get")]
        public Route GetRtwithMxRes()
        {
            return adm.RouteWithMaxReservation();
        }
        [HttpPut]
        [Route("/api/AdminAPI/updateBus")]
        public bool Put(Bus obj, int bid)
        {
            return adm.UpdateBus(obj, bid);
        }
        [HttpPut]
        [Route("/api/AdminAPI/updateRoute")]
        public bool Put(Route obj, int rid)
        {
            return adm.UpdateRoute(obj, rid);
        }
        [HttpPut]
        [Route("/api/AdminAPI/updateSchedule")]
        public bool Put(Schedule obj, int sid)
        {
            return adm.UpdateSchedule(obj, sid);
        }
    }
}
