using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationSystem.Models;
using BusReservationSystem.Exceptions;
namespace BusReservationSystem.DAL
{
    public class TicketImpl : ITicket
    {
        BRSDBContext db = new BRSDBContext();

        //this will Insert Booking to booking table
        public Booking BookTicket(Booking book)
        {
            db.Add(book);
            var res = db.SaveChanges();
            if (res == 1)
                return db.Bookings.Where(x => x.BookId == db.Bookings.Max(x => x.BookId)).FirstOrDefault();
            return null;
        }

        //This method will remove Booking using bookId
        public bool CancelTicket(int bookId)
        {
            Booking booking = db.Bookings.Where(x => x.BookId == bookId).FirstOrDefault();
            db.Remove(booking); //Finally deleting the booking from booking table
            return db.SaveChanges() > 0;

        }

        public Payment GetPaymentByBookiId(int bookId)
        {
            return db.Payments.Where(x => x.BookId == bookId).FirstOrDefault();
        }

        //This method will return Schedule by using schedule Id
        public Schedule GetScheduleBySchId(int schId)
        {
            return db.Schedules.Where(x => x.ScheduleId == schId).FirstOrDefault();
        }

        //this method will return Seat by using seatId
        public Seat GetSeatBySeatId(int seatid)
        {
            Seat seat = db.Seats.Where(x => x.SeatId == seatid).FirstOrDefault();
            return seat;
        }

        //this method will return list of seats by using bookId
        public List<Seat> GetSeatsByBookId(int bookId)
        {
            return db.Seats.Where(x => x.BookId == bookId).ToList();
        }

        //this method will return booking by using bookId
        public Booking GetTicketDetails(int bookID)
        {
            return db.Bookings.Where(x => x.BookId == bookID).FirstOrDefault();
        }

        //this method will return User using email Id
        public UserReg GetUserByEmail(string email)
        {
            UserReg user = db.UserRegs.Where(x => x.UserEmail == email).FirstOrDefault();
            if (user == null) throw new UserNotFound($"The user with {email} email id is not regestered");
            return user;
        }

        //This method will insert the seat to seat table
        public bool InsertSeat(Seat seat)
        {
            db.Add(seat);
            return db.SaveChanges() > 0;
        }

        //This method will insert Payment to payment table
        public bool MakePayment(Payment pay)
        {
            db.Add(pay);
            return db.SaveChanges() > 0;
        }

        //this will remove the given list of seats
        public bool RemoveSeats(List<Seat> seats)
        {
            foreach (Seat seat in seats)
                db.Remove(seat);
            return db.SaveChanges() > 0;
        }

        //this will return List of buses travel from the given arrive loc to dest loc, on and after journeyDate
        public List<Bus> SearchBusByLoc(string arrive, string Dest, DateTime journeyDate)
        {
            Route route = db.Routes.Where(x => x.Arrive == arrive && x.Dest == Dest).FirstOrDefault();
            if (route == null) throw new BusNotFound("Route not found");
            int routeId = route.RouteId;
            var buses = from bus in db.buses
                        join sch in db.Schedules on bus.BusId equals sch.BusId
                        where sch.RouteId == routeId && sch.JrnyDate >= journeyDate
                        select new { b = bus, Sch = sch };
            List<Bus> buses1 = new();
            foreach (var bus in buses)
            {
                buses1.Add(bus.b);
            }
            if (buses1 == null) throw new BusNotFound($"No bus is scheduled to {Dest} from {arrive} on {journeyDate}");
            return buses1;

        }

        //this will update the journey date
        public bool UpdateSchedule(int schId, int bookId)
        {
            //Changing the schedule id on booking table
            //int? prevSchId = db.Bookings.Where(x => x.ScheduleId == schId).FirstOrDefault().ScheduleId;
            //int? updtSchId = db.Schedules.Where(x => x.ScheduleId == schId).FirstOrDefault().ScheduleId;
            //int? prevRtId = db.Schedules.Where(x => x.ScheduleId == prevSchId).FirstOrDefault().RouteId;
            //int? updtRtId = db.Schedules.Where(x => x.ScheduleId == updtSchId).FirstOrDefault().RouteId;
            //if (prevRtId != updtRtId) throw new RouteNotMatching("U selected different route");
            db.Bookings.Where(x => x.BookId == bookId).FirstOrDefault().ScheduleId = schId;
            return db.SaveChanges() > 0;
        }

        public Booking UpdateTicket(Booking book, int bookId)
        {
            var booking = db.Bookings.Where(x => x.BookId == bookId).FirstOrDefault();
            booking.BookStatus = book.BookStatus;
            db.SaveChanges();
            return booking;
        }
    }
}
