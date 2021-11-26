using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationSystem.Models;

namespace UIBusReservationSystem.Controllers
{
    public class UserRegUIController : Controller
    {
        public IActionResult RegisterPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterPage(int i = 0)
        {
            UserReg newuser = new();
            newuser.FirstName = Request.Form["Firstname"];
            newuser.LastName = Request.Form["Secondname"];
            newuser.UserEmail = Request.Form["Useremail"];
            newuser.UserMob = Request.Form["Mobile"];
            newuser.UsrAddress = Request.Form["Address"];
            newuser.Pswd = Request.Form["Password"];
            bool registered = Helper.RegisterUser(newuser);
            if (registered)
                return RedirectToAction("Login");
            return View();
        }
    }
}
