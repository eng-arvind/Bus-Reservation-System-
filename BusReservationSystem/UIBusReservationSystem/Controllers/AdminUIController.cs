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
        [HttpPost]
        public IActionResult AdminDashboard(string command)
        {
            if(command== "GetRegUserNotBookedYet")
            {
                ViewData["usernotreg"] = null;
                List<UserReg> ulast = new List<UserReg>();
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5863/api/");
                    var responsedata = client.GetAsync("AdminAPI/GetRegUNotBookedYet");
                    responsedata.Wait();
                    var result = responsedata.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readresult = result.Content.ReadAsAsync<List<UserReg>>();
                        readresult.Wait();
                        ulast = readresult.Result;
                        ViewData["usernotreg"] = ulast;

                    }
                }
            }
            if (command == "LastMnthProfit")
            {
                ViewData["lastmonthp"] = null;
               
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5863/api/");
                    var responsedata = client.GetAsync("AdminAPI/LastMonthProfit");
                    responsedata.Wait();
                    var result = responsedata.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readresult = result.Content.ReadAsStringAsync();
                        readresult.Wait();
                        ViewData["lastmonthp"] = readresult.Result;

                    }
                }
            }
            if (command == "PrefferedTypeOfBus")
            {
                ViewData["prefbus"] = null;
                Bus newBus = new();
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5863/api/");
                    var responsedata = client.GetAsync("AdminAPI/PreferedTypeOfBus");
                    responsedata.Wait();
                    var result = responsedata.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readresult = result.Content.ReadAsAsync<Bus>();
                        readresult.Wait();
                        newBus = readresult.Result;
                        ViewData["prefbus"] = newBus;

                    }
                }
            }
            if (command == "ResDetailsOFCust")
            {
                DateTime dt = Convert.ToDateTime(Request.Form["jdate"]);
                ViewData["resdetails"] = null;
                List<Booking> blast = new List<Booking>();
                string dat = $"{dt.Month}-{dt.Day}-{dt.Year}";
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5863/api/");
                    var responsedata = client.GetAsync("AdminAPI/RestDetailsOFCust/"+dat);
                    responsedata.Wait();
                    var result = responsedata.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readresult = result.Content.ReadAsAsync<List<Booking>>();
                        readresult.Wait();
                        blast = readresult.Result;
                        ViewData["resdetails"] = blast;

                    }
                }
            }
            if (command == "RouteWithMaxReservation")
            {
                ViewData["maxres"] = null;
                Route newrt = new();
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5863/api/");
                    var responsedata = client.GetAsync("AdminAPI/RouteWithMxReservation");
                    responsedata.Wait();
                    var result = responsedata.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readresult = result.Content.ReadAsAsync<Route>();
                        readresult.Wait();
                        newrt = readresult.Result;
                        ViewData["maxres"] = newrt;

                    }
                }
            }
            return View();
        }
    }
}
