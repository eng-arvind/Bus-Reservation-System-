using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationSystem.Models;

namespace UIBusReservationSystem.Controllers
{
    public class AuthUserUIController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(int i = 0)
        {
            Lgn lgn = new();
            lgn.UserEmail = Request.Form["UserEmail"];
            lgn.Password = Request.Form["Password"];
            var user = Helper.AuthenticateUser(lgn);
            if (user!=null)
            {
                return RedirectToAction("UserHomePage", user);
            }
            ModelState.AddModelError("", "UserEmail or Password is is invalid");
            return View();
        }

    }
}
