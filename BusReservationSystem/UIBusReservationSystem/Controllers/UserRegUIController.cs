using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UIBusReservationSystem.Controllers
{
    public class UserRegUIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
