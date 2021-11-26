using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationSystem.Models;
using BusReservationSystem.DAL;

namespace BusReservationSystem.Controllers
{
    [Route("api/UserRegApi")]
    [ApiController]
    public class UserRegApiController : ControllerBase
    {
        readonly iUserRegistration iUser;
        readonly BRSDBContext db;

        public UserRegApiController(iUserRegistration iUser, BRSDBContext db)
        {
            this.iUser = iUser;
            this.db = db;
        }
        [HttpPost]
        [Route("/api/UserRegApi/RegisterUser")]
        public bool Post(UserReg user)
        {
            return iUser.Register(user);
        }

    }

}
