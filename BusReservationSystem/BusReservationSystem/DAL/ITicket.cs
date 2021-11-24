using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationSystem.Models;

namespace BusReservationSystem.DAL
{
    public interface ITicket
    {
        public List<Bus> SearchBusByLoc(string arrive, string Dest, DateTime jrnyDate);
        public Seat GetSeatBySeatId(int seatid);
        public bool InsertSeat(Seat seat);
        public Booking BookTicket(Booking book);
        public Booking UpdateTicket(Booking book, int bookId);
        public bool MakePayment(Payment pay);
        public Payment GetPaymentByBookiId(int bookId);
        public List<Seat> GetSeatsByBookId(int bookId);
        public Schedule GetScheduleBySchId(int schId);
        public UserReg GetUserByEmail(string email);
        public bool RemoveSeats(List<Seat> seats);
        public bool CancelTicket(int bookId);
        public bool UpdateSchedule(int schId, int bookId);
        public Booking GetTicketDetails(int bookID);
    }
}
