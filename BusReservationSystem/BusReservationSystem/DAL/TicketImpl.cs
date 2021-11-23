using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationSystem.Models;

namespace BusReservationSystem.DAL
{
    public class TicketImpl : ITicket
    {
        BRSDBContext db = new BRSDBContext();
        public bool BookTicket(Booking book)
        {
            db.Add(book);
            return db.SaveChanges() == 1;
        }

        public bool CancelTicket(int bookId)
        {
            Booking booking = db.Bookings.Where(x => x.BookId == bookId).FirstOrDefault();
            List<Seat> seats = db.Seats.Where(x => x.BookId == bookId).ToList(); //getting all seats with the given bookId
            foreach (Seat seat in seats)
                db.Remove(seat); //removing every seat from seat table
            string userEmail = booking.UserEmail;
            UserReg user = db.UserRegs.Where(x => x.UserEmail == userEmail).FirstOrDefault(); //getting user
            if (user != null) //checking wether the user is registered or not
            {
                user.Wallet += booking.Tcharge; //Adding refund to wallet
                db.Update(user); //Making the changes updated
            }
            Schedule schedule = db.Schedules.Where(x => x.ScheduleId == booking.ScheduleId).FirstOrDefault(); //getting schedule
            schedule.SeatAvl += booking.Npassengers; //seat available after cancelling the tickets
            db.Update(schedule); //Making the changes updated
            db.Remove(booking); //Finally deleting the booking from booking table
            return db.SaveChanges() == 1;

        }

        public Seat GetSeatBySeatId(int seatid)
        {
            Seat seat = db.Seats.Where(x => x.SeatId == seatid).FirstOrDefault();
            return seat;
        }

        public Booking GetTicketDetails(int bookID)
        {
            return db.Bookings.Where(x => x.BookId == bookID).FirstOrDefault();
        }

        public bool InsertSeat(Seat seat)
        {
            db.Add(seat);
            return db.SaveChanges() == 1;
        }

        public bool MakePayment(Payment pay)
        {
            db.Add(pay);
            return db.SaveChanges() == 1;
        }

        public List<Bus> SearchBusByLoc(string arrive, string Dest, DateTime journeyDate)
        {
            //joining the route table and schedule table on the basis of routeId and selecting the joined table where journey date is greater than given date and again joing to the bus table on the basis of busID 
            List<Bus> buses = (from r in db.Routes
                             join s in db.Schedules on r.RouteId equals s.RouteId
                             where s.JrnyDate >= journeyDate
                             join b in db.buses on s.BusId equals b.BusId
                             select b).ToList();
            return buses;

        }

        public bool UpdateSchedule(int schId, int bookId)
        {
            //Changing the schedule id on booking table
            db.Bookings.Where(x => x.BookId == bookId).FirstOrDefault().ScheduleId = schId;
            return db.SaveChanges() == 1;
        }
    }
}
