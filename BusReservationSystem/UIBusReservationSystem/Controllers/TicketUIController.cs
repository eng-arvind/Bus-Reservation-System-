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
    public class TicketUIController : Controller
    {
        public IActionResult HomePage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult HomePage(int i = 0)
        {
            string Arrive = Request.Form["from"];
            string Dest = Request.Form["to"];
            DateTime JrnyDate = Convert.ToDateTime(Request.Form["jrnyDate"]);
            string jrnyDate = $"{JrnyDate.Month}-{JrnyDate.Day}-{JrnyDate.Year}";
            return RedirectToAction("SearchBus", new { arrive = Arrive, dest=Dest, jrnydate = jrnyDate});
        }

        public IActionResult SearchBus(string arrive, string dest, string jrnyDate)
        {
            var buses = Helper.GetBusScheduleJoins(arrive, dest, jrnyDate);
            return View(buses);
        }
    }
}
