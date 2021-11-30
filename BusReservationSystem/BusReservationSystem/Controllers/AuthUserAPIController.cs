using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationSystem.DAL;
using BusReservationSystem.Models;

namespace BusReservationSystem.Controllers
{
    [Route("api/AuthUserAPI")]
    [ApiController]
    public class AuthUserAPIController : ControllerBase
    {
        readonly IAuthUser ua;
        readonly BRSDBContext db;
        readonly ITicket it;

        public AuthUserAPIController(IAuthUser ua, BRSDBContext db, ITicket it)
        {
            this.it = it;
            this.ua = ua;
            this.db = db;
        }

        [HttpPost]
        [Route("/api/AuthUserAPI/Login")]
        public UserReg Login(Lgn lg)
        {
            return ua.Login(lg);
        }
        [HttpPut]
        [Route("/api/AuthUserAPI/AddMoneyWallet")]

        public bool AddMoneyWallet(ADJ adj)
        {
            return ua.AddMoneyWallet(adj);
        }
        [HttpGet]
        [Route("/api/AuthUserAPI/GetLastReservations/{userId}")]

        public List<Booking> GetLastReservations(string userId)
        {
            UserReg user = it.GetUserByEmail(userId);
            return ua.GetLastReservations(user);
        }
        [HttpPut]
        [Route("/api/AuthUserAPI/UpdateProfile/{email}")]

        public bool UpdateProfile(UserReg updated, string email)
        {
            return ua.UpdateProfile(updated, email);
        }
        [HttpGet]
        [Route("/api/AuthUserAPI/GetProfile")]


        public UserReg GetProfile(UserReg user)
        {
            return ua.GetProfile(user);
        }
        [HttpPut]
        [Route("/api/AuthUserAPI/ResetPassword/{email}")]

        public bool ResetPassword(UserReg updated, string email)
        {
            return ua.ResetPassword(updated, email);
        }

    }
}





