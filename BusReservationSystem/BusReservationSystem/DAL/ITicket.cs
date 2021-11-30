using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationSystem.Models;

namespace BusReservationSystem.DAL
{
    public interface ITicket
    {
        public List<BusScheduleJoin> SearchBusByLoc(string arrive, string dest, string jrnyDate);
        public Seat GetSeatBySeatId(int seatid);
        public bool InsertSeat(Seat seat);
        public Booking BookTicket(Booking book);
        public Booking UpdateTicket(Booking book, int bookId);
        public Route GetRouteById(int routeId);
        public Bus GetBusById(int busId);
        public bool MakePayment(Payment pay);
        public Payment GetPaymentByBookiId(int bookId);
        public List<Seat> GetSeatsByBookId(int bookId);
        public Schedule GetScheduleBySchId(int schId);
        public UserReg GetUserByEmail(string email);
        public bool RemoveSeats(List<Seat> seats);
        public bool CancelTicket(int bookId);
        public Booking GetTicketDetails(int bookID);
        public List<Booking> GetBookingsBySchId(int schId);
        public bool UpdateSchedule(Schedule updateSch, int schId);
        public int GetLastBookId();
    }
}
