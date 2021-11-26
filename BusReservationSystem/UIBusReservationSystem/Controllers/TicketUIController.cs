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
            ADJ adj = new();
            adj.Arrive = Request.Form["from"];
            adj.Dest = Request.Form["to"];
            DateTime JrnyDate = Convert.ToDateTime(Request.Form["jrnyDate"]);
            adj.JrnyDate = $"{JrnyDate.Month}-{JrnyDate.Day}-{JrnyDate.Year}";
            return RedirectToAction("SearchBus", adj);
        }

        public IActionResult SearchBus(ADJ adj)
        {
            var buses = Helper.GetBusScheduleJoins(adj);
            return View(buses);
        }
    }
}
