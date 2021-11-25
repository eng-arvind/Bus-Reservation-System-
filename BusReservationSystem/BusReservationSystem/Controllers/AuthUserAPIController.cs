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

        public AuthUserAPIController(IAuthUser ua, BRSDBContext db)
        {
            this.ua = ua;
            this.db = db;
        }

        [HttpPost]
        [Route("/api/AuthUserAPI/Login/{email}/{password}")]
        public UserReg Login(String email, string password)
        {
            return ua.Login(email, password);
        }
        [HttpPost]
        [Route("/api/AuthUserAPI/AddMoneyWallet/{amt}")]

        public bool AddMoneyWallet(UserReg user, decimal amt)
        {
            return ua.AddMoneyWallet(user, amt);
        }
        [HttpGet]
        [Route("/api/AuthUserAPI/GetLastReservations")]

        public List<Booking> GetLastReservations(UserReg user)
        {
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





