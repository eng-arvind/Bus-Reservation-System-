using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc.Rendering;
using BusReservationSystem.Models;

namespace UIBusReservationSystem.Controllers
{
    public class AdminUIController : Controller
    {
        public IActionResult AdminHome()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdminHome(int i=0)
        {

            AdminMaster adm = new();
            adm.UserName= Request.Form["username"];
            adm.UsrPswd= Request.Form["pass"];
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5863/api/");
                var responsedata = client.PostAsJsonAsync("AdminAPI/IsAdmin",adm);
                responsedata.Wait();
                var result = responsedata.Result;
                if (result.IsSuccessStatusCode)
                {

                   return RedirectToAction("AdminDashboard");
                }
                else
                {
                    ModelState.AddModelError("","You have Entered wrong usename or password");
                }

            }
            return View();
        }
      public IActionResult AdminDashboard()
        {
            return View();
        }
    }
}
