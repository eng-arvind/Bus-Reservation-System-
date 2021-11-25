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
        IAdmin admin = new AdminImpl();
        BRSDBContext db = new();
    }
}
