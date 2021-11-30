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
                return RedirectToAction("DashBoard", user);
            }
            ModelState.AddModelError("", "UserEmail or Password is is invalid");
            return View();
        }
        public IActionResult DashBoard(UserReg user)
        {
            return View(user);
        }
        public IActionResult Profile(UserReg user)
        {
            return View(user);
        }
        [HttpPost]
        public IActionResult Profile(UserReg user, int i = 0)
        {
            user.FirstName = Request.Form["Firstname"];
            user.LastName = Request.Form["Secondname"];
            user.UserEmail = Request.Form["Useremail"];
            user.UserMob = Request.Form["Mobile"];
            user.UsrAddress = Request.Form["Address"];
            Helper.EditProfile(user, user.UserEmail);
            return View(user);
        }

        public IActionResult Wallet(UserReg user)
        {
            return View(user);
        }
        [HttpPost]
        public IActionResult Wallet(UserReg user, int i = 0)
        {
            decimal amt = Convert.ToDecimal(Request.Form["Amount"]);
            ADJ adj = new();
            adj.user = user;
            adj.amt = amt;
            if (amt > 0)
            {
                Helper.AddMoneyToWallet(adj);
            }
            UserReg User = Helper.GetUserById(user.UserEmail);
            return View(User);
        }

        public IActionResult ResetPass(UserReg user)
        {
            string oldPass = Request.Form["Oldpass"];
            if (oldPass == user.Pswd)
            {
                string newPass = Request.Form["Newpass"];
                string confPass = Request.Form["Confpass"];
                if (newPass == confPass)
                {
                    user.Pswd = newPass;
                    Helper.ResetPass(user, user.UserEmail);
                    ModelState.AddModelError("", "Password reset successful");
                }
                else
                {
                    ModelState.AddModelError("", "New password and confirm password not matching");
                }
            }
            else
            {
                ModelState.AddModelError("", "Old password is wrong");
            }
            return View(user);
        }

        public IActionResult GetReserves(UserReg user)
        {
            ViewData["FirstName"] = user.FirstName;
            List<Booking> bookings = Helper.GetReservations(user);
            List<Schedule> schedules = new();
            List<Route> routes = new();
            if (bookings.Count() > 0)
            {
                foreach (var book in bookings)
                {
                    Schedule schedule = Helper.GetScheduleById((int)book.ScheduleId);
                    schedules.Add(schedule);
                    routes.Add(Helper.GetRouteById((int)schedule.RouteId));
                }
                ViewData["Schedules"] = schedules;
                ViewData["Routes"] = routes;
                ViewData["Bookings"] = bookings;
            }
            return View(user);
        }

        public IActionResult Cancel(int bookId)
        {
            Booking booking = Helper.GetBookingByBookId(bookId);
            Schedule schedule = Helper.GetScheduleById((int)booking.ScheduleId);
            UserReg user = Helper.GetUserById(booking.UserEmail);
            List<Seat> seats = Helper.GetSeatsByBookId(bookId);
            Payment payment = Helper.GetPayment(bookId);
            Helper.RemoveSeats(seats);
            schedule.SeatAvl += seats.Count;
            Helper.UpdateSeatAvailability(schedule, schedule.ScheduleId);
            ADJ adj = new();
            adj.user = user;
            adj.amt = (decimal)booking.Tcharge;
            Helper.AddMoneyToWallet(adj);
            Helper.RemoveBooking(bookId);
            return RedirectToAction("GetReserves", user);
        }
    }
}
