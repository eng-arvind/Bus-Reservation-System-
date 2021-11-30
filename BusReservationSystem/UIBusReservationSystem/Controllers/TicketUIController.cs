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
        public IActionResult SearchBus(string arrive, string dest, string jrnyDate, string UserId="", int BookId=0)
        {
            var buses = Helper.GetBusScheduleJoins(arrive, dest, jrnyDate);
            ViewData["UserID"] = UserId;
            if (UserId != "")
            {
                ViewData["User"] = Helper.GetUserById(UserId);
            }
            ViewData["BookId"] = BookId;
           
            Booking booking = Helper.GetBookingByBookId(BookId);
            if (booking != null)
            {
                buses = buses.Where(x => x.SeatAvail >= booking.Npassengers).ToList();
                if (buses == null || buses.Count == 0) ModelState.AddModelError("", "No buses available with required number of seats");
            }
            
            return View(buses);
        }
        
        public IActionResult Book(int schId, string UserId)
        {
            ViewData["UserID"] = UserId;
            if (UserId != "")
            {
                ViewData["User"] = Helper.GetUserById(UserId);
            }
            return View(schId);
        }
        [HttpPost]
        public IActionResult Book()
        {
            string userId = Request.Form["UserId"];
            Booking Book = new();
            Book.UserEmail = Request.Form["Useremail"];
            Book.UserMob = Request.Form["Mobile"];
            Book.ScheduleId = Convert.ToInt32(Request.Form["schId"]);
            Book.Npassengers = Convert.ToInt32(Request.Form["nPassengers"]);
            Book.IdProof = Request.Form["Id"];
            var schedule = Helper.GetScheduleById((int)Book.ScheduleId);
            Book.Tcharge = schedule.Fare * Book.Npassengers;
            var res = Helper.InsertBook(Book);
            if (res)
            {
                return RedirectToAction("SelectSeats", new { UserId = userId });
            }
            return View();
        }
        public IActionResult SelectSeats(string UserID)
        {
            int bookId = Helper.GetLastBookId();
            Booking book = Helper.GetBookingByBookId(bookId);
            List<Booking> bookings = Helper.GetBookingsBySchId((int)book.ScheduleId);
            List<Seat> seats = new();
            foreach (Booking booking in bookings)
            {
                List<Seat> seat = Helper.GetSeatsByBookId((int)booking.BookId);
                if(seat!=null && seat.Count!=0)
                    seats = seats.Concat(seat).ToList();
            }
            ViewData["UserID"] = UserID;
            if (UserID != "")
            {
                ViewData["User"] = Helper.GetUserById(UserID);
            }
            return View(seats);
        }
        [HttpPost]
        public IActionResult SelectSeats()
        {
            string userID = Request.Form["UserID"];
            int bookId = Helper.GetLastBookId();
            Booking book = Helper.GetBookingByBookId(bookId);
            string seats = Request.Form["Seats"];
            string[] SplitSeats = seats.Split(",");
            if (seats != "")
            {
                foreach(string str in SplitSeats)
                {
                    Seat seat = new();
                    seat.SeatId = Convert.ToInt32(str);
                    seat.BookId = bookId;
                    bool inserted = Helper.InsertSeat(seat);
                    if (!inserted) return View(book);
                }
                return RedirectToAction("DirectPayment", new { UserId = userID });
            }
            ModelState.AddModelError("","Please select the seat before submitting");
            return View(book);
        }
        public IActionResult DirectPayment(string UserID)
        {
            int bookId = Helper.GetLastBookId();
            Booking book = Helper.GetBookingByBookId(bookId);
            ViewData["UserID"] = UserID;
            if (UserID != "")
            {
                ViewData["User"] = Helper.GetUserById(UserID);
            }
            return View(book);
        }

        [HttpPost]
        public IActionResult DirectPayment()
        {
            int bookId = Helper.GetLastBookId();
            Booking book = Helper.GetBookingByBookId(bookId);
            string mode = Request.Form["Mode"];
            string userId = Request.Form["UserId"];
            Payment payment = new();
            payment.BookId = book.BookId;
            payment.PayMode = mode;
            payment.UserEmail = userId;
            payment.TotalAmt = book.Tcharge;
            UserReg user = Helper.GetUserById(userId);
            ADJ adj = new();
            adj.user = user;
            adj.amt = (decimal)(0 -book.Tcharge);
            if (userId !="" && mode == "Wallet")
            {
                if (user.Wallet >= book.Tcharge)
                {
                    bool paid = Helper.AddMoneyToWallet(adj);
                    if (paid) { Helper.InsertPayment(payment); book.BookStatus="Booked"; book = Helper.UpdateTicket(book, bookId); return RedirectToAction("GenerateTicket", new { BookId = bookId, UserId=userId }); }
                    return View(userId);
                }
                ModelState.AddModelError("", "Not much money available in your account");
                return View(userId);
            }
            else
            {
                Helper.InsertPayment(payment);
                book.BookStatus = "Booked";
                Helper.UpdateTicket(book, bookId);
                return RedirectToAction("GenerateTicket", new { BookId = bookId });
            }
        }
        public IActionResult GenerateTicket(int BookId, string UserId)
        {
            ViewData["UserID"] = UserId;
            if (UserId != "")
            {
                ViewData["User"] = Helper.GetUserById(UserId);
            }
            Booking book = Helper.GetBookingByBookId(BookId);
            Schedule schedule = Helper.GetScheduleById((int)book.ScheduleId);
            ViewData["Email"] = book.UserEmail;
            Route route = Helper.GetRouteById((int)schedule.RouteId);
            ViewData["Mob"] = book.UserMob;
            ViewData["From"] = route.Arrive;
            ViewData["To"] = route.Dest;
            ViewData["Date"] = schedule.JrnyDate;
            Bus bus = Helper.GetBusById((int)schedule.BusId);
            ViewData["BusName"] = bus.BusName;
            ViewData["amt"] = book.Tcharge;
            ViewData["Status"] = book.BookStatus;
            schedule.SeatAvl -= book.Npassengers;
            Helper.UpdateSeatAvailability(schedule, schedule.ScheduleId);
            return View();
        }
    }
}
