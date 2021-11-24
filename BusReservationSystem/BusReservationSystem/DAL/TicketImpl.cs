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

        //This method will remove Booking using bookId
        public bool CancelTicket(int bookId)
        {
            Booking booking = db.Bookings.Where(x => x.BookId == bookId).FirstOrDefault();
            db.Remove(booking); //Finally deleting the booking from booking table
            return db.SaveChanges() == 1;

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
            return db.UserRegs.Where(x => x.UserEmail == email).FirstOrDefault();
        }

        //This method will insert the seat to seat table
        public bool InsertSeat(Seat seat)
        {
            db.Add(seat);
            return db.SaveChanges() == 1;
        }

        //This method will insert Payment to payment table
        public bool MakePayment(Payment pay)
        {
            db.Add(pay);
            return db.SaveChanges() == 1;
        }

        //this will remove the given list of seats
        public bool RemoveSeats(List<Seat> seats)
        {
            foreach (Seat seat in seats)
                db.Remove(seat);
            return db.SaveChanges() == 1;
        }

        //this will return List of buses travel from the given arrive loc to dest loc, on and after journeyDate
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

        //this will update the journey date
        public bool UpdateSchedule(int schId, int bookId)
        {
            //Changing the schedule id on booking table
            db.Bookings.Where(x => x.BookId == bookId).FirstOrDefault().ScheduleId = schId;
            return db.SaveChanges() == 1;
        }
    }
}
