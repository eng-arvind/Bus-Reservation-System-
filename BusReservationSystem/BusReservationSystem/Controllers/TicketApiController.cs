using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationSystem.DAL;
using BusReservationSystem.Models;

namespace BusReservationSystem.Controllers
{
    [Route("api/TicketApi")]
    [ApiController]
    public class TicketApiController : ControllerBase
    {
        readonly ITicket it;
        readonly BRSDBContext db;

        public TicketApiController(ITicket it, BRSDBContext db)
        {
            this.it = it;
            this.db = db;
        }

        [HttpPost]
        [Route("/api/TicketApi/BookTicket")]
        public bool PostBook(Booking booking)
        {
            Booking book = it.BookTicket(booking);
            return book != null;
        }

        [HttpPost]
        [Route("/api/TicketApi/MakePayment")]
        public bool PostPayment(Payment payment)
        {
            return it.MakePayment(payment);
        }

        [HttpPost]
        [Route("/api/TicketApi/InsertSeat")]
        public bool PostSeat(Seat seat)
        {
            return it.InsertSeat(seat);
        }

        [HttpGet]
        [Route("/api/TicketApi/GetSeatBySeatId/{seatId}")]
        public Seat GetSeat(int seatId)
        {
            return it.GetSeatBySeatId(seatId);
        }

        [HttpGet]
        [Route("/api/TicketApi/GetSeatsByBookId/{bookId}")]
        public List<Seat> GetSeats(int bookId)
        {
            return it.GetSeatsByBookId(bookId);
        }

        [HttpGet]
        [Route("/api/TicketApi/GetBusesByLoc/{arrive}/{dest}/{jrnyDate}")]
        public List<Bus> GetBuses(string arrive, string dest, DateTime jrnyDate)
        {
            return it.SearchBusByLoc(arrive, dest, jrnyDate);
        }

        [HttpGet]
        [Route("/api/TicketApi/GetPaymentByBookId/{bookId}")]
        public Payment GetPayment(int bookId)
        {
            return it.GetPaymentByBookiId(bookId);
        }

        [HttpGet]
        [Route("/api/TicketApi/GetScheduleBySchId/{schId}")]
        public Schedule GetSchedule(int schId)
        {
            return it.GetScheduleBySchId(schId);
        }

        [HttpGet]
        [Route("/api/TicketApi/GetUserByEmail/{email}")]
        public UserReg GetUser(string email)
        {
            return it.GetUserByEmail(email);
        }

        [HttpGet]
        [Route("/api/TicketApi/GetBookingByBookId/{bookId}")]
        public Booking GetBooking(int bookId)
        {
            return it.GetTicketDetails(bookId);
        }

        [HttpPut]
        [Route("/api/TicketApi/UpdateTicket/{bookId}")]
        public Booking UpdateTicket(Booking uptdTicket, int bookId)
        {
            return it.UpdateTicket(uptdTicket, bookId);
        }

        [HttpPut]
        [Route("/api/TicketApi/PostponeSchedule/{schID}/{bookId}")]
        public bool PostponeSchedule(int schId, int bookId)
        {
            return it.UpdateSchedule(schId, bookId);
        }

        [HttpDelete]
        [Route("/api/TicketApi/DeleteSeats")]
        public bool DeleteSeats(List<Seat> seats)
        {
            return it.RemoveSeats(seats);
        }

        [HttpDelete]
        [Route("/api/TicketApi/DeleteTicket/{bookId}")]
        public bool DeleteTicket(int bookId)
        {
            return it.CancelTicket(bookId);
        }
    }
}
