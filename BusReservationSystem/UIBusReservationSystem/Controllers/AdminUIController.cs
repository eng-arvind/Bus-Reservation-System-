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
            ViewData["allbuses"] = null;
            ViewData["allroutes"] = null;
            ViewData["allschedule"] = null;
           
            using (var client = new HttpClient())
            {
                List<Bus> blast = new List<Bus>();
                client.BaseAddress = new Uri("http://localhost:5863/api/");
                var responsedata = client.GetAsync("AdminAPI/showAllbuses");
                responsedata.Wait();
                var result = responsedata.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readresult = result.Content.ReadAsAsync<List<Bus>>();
                    readresult.Wait();
                    blast = readresult.Result;
                    ViewData["allbuses"] = blast;

                }
            }
            using (var client = new HttpClient())
            {
                List<Route> rtlast = new List<Route>();
                client.BaseAddress = new Uri("http://localhost:5863/api/");
                var responsedata = client.GetAsync("AdminAPI/showAllroute");
                responsedata.Wait();
                var result = responsedata.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readresult = result.Content.ReadAsAsync<List<Route>>();
                    readresult.Wait();
                    rtlast = readresult.Result;
                    ViewData["allroutes"] = rtlast;

                }
            }
            using (var client = new HttpClient())
            {
                List<Schedule> schlast = new List<Schedule>();
                client.BaseAddress = new Uri("http://localhost:5863/api/");
                var responsedata = client.GetAsync("AdminAPI/showAllschedule");
                responsedata.Wait();
                var result = responsedata.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readresult = result.Content.ReadAsAsync<List<Schedule>>();
                    readresult.Wait();
                    schlast = readresult.Result;
                    ViewData["allschedule"] = schlast;

                }
            }

            return View();
        }
<<<<<<< HEAD
        [HttpPost]
        public IActionResult AdminDashboard(string command,Bus B,Route R, Schedule S)
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
            if(command== "Insert Bus")
            {
                B.BusName = Request.Form["busname"];
                B.TotalSeats =Convert.ToInt32(Request.Form["totalseat"]);
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5863/api/");
                    var postdata = client.PostAsJsonAsync<Bus>("AdminAPI/insertBus",B);
                    postdata.Wait();
                    var result = postdata.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        ModelState.AddModelError("", "New Bus Created");
                    }
                    else
                    {
                        ModelState.AddModelError("", "No Bus Created");
                    }
                }
            }

            if (command == "Insert Route")
            {
                R.Arrive = Request.Form["arrival"];
                R.Dest = Request.Form["dest"];
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5863/api/");
                    var postdata = client.PostAsJsonAsync<Route>("AdminAPI/insertRoute", R);
                    postdata.Wait();
                    var result = postdata.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        ModelState.AddModelError("", "New Route Created");
                    }
                    else
                    {
                        ModelState.AddModelError("", "No Route Created");
                    }
                }
            }
            if (command == "Insert Schedule")
            {
                S.RouteId = Convert.ToInt32(Request.Form["routeid"]);
                S.JrnyDate = Convert.ToDateTime(Request.Form["datetime"]);
                S.BusId = Convert.ToInt32(Request.Form["bussid"]);
                S.SeatAvl = Convert.ToInt32(Request.Form["seatavl"]);
                S.Fare = Convert.ToDecimal(Request.Form["farecharge"]);
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5863/api/");
                    var postdata = client.PostAsJsonAsync<Schedule>("AdminAPI/insertSch", S);
                    postdata.Wait();
                    var result = postdata.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        ModelState.AddModelError("", "New Schedule Created");
                    }
                    else
                    {
                        ModelState.AddModelError("", "No Schedule Created");
                    }
                }
            }
            return View();
        }
        public IActionResult EditBus(int ID)
        {
            Bus busobj = Helper.GetBusById(ID);

            return View(busobj);
        }
        [HttpPost]
        public IActionResult EditBus()
        {
            return View();
        }
        public IActionResult DeleteBus(int ID)
        {

            Bus busobj = Helper.GetBusById(ID);

            return View(busobj);
        }
        [HttpDelete]
        public IActionResult DeleteBus()
        {
            return View();
        }
        public IActionResult EditRoute(int ID)
        {
            Route rtobj = Helper.GetRouteById(ID);

            return View(rtobj);
        }
        [HttpPost]
        public IActionResult EditRoute()
        {
            return View();
        }
        public IActionResult DeleteRoute(int ID)
        {
            Route rtobj = Helper.GetRouteById(ID);

            return View(rtobj);
        }
        [HttpDelete]
        public IActionResult DeleteRoute()
        {
            return View();
        }
        public IActionResult EditSch(int ID)
        {
            Schedule schobj = Helper.GetScheduleById(ID);

            return View(schobj);
        }
        [HttpPost]
        public IActionResult EditSch()
        {
            return View();
        }
        public IActionResult DeleteSch(int ID)
        {
            Schedule schobj = Helper.GetScheduleById(ID);

            return View(schobj);
        }
        [HttpDelete]
        public IActionResult DeleteSch()
        {
            return View();
        }

=======
>>>>>>> 342cda93ebc3a5e31d91dc4e8fd585cc2954ee3b
    }
}
