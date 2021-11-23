using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationSystem.Models;

namespace BusReservationSystem.DAL
{
    public interface ITicket
    {
        public List<Bus> SearchBusByLoc(string arrive, string Dest);
        public Seat GetSeatBySeatId(int seatid);
        public bool InsertSeat(Seat seat);
        public bool BookTicket(Booking book);
        public bool MakePayment(Payment pay);
        public bool CancelTicket(int seat, int bookId);
        public bool UpdateSchedule(int schId, int bookId);
        public Booking GetTicketDetails(int bookID);
    }
}
