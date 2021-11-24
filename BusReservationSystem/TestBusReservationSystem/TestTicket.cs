using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusReservationSystem.DAL;
using BusReservationSystem.Models;
using BusReservationSystem.Exceptions;

namespace TestBusReservationSystem
{
    class TestTicket
    {
        static ITicket ticket = new TicketImpl();
        static IAdmin admin = new AdminImpl();
        static IAuthUser authUser = new AuthUserImpl();

        public static void SearchBus(string arrive, string dest, DateTime jrnyDate)
        {
            List<Bus> buses = ticket.SearchBusByLoc(arrive, dest, jrnyDate);
            if (buses != null && buses.Count > 0)
            {
                foreach (Bus bus in buses)
                {
                    Console.WriteLine($"{bus.BusId}. {bus.BusName}");
                }
            }
        }

        public static void CancelTicket(int bookid)
        {
            string email = "Deepu@gmail.com";
            UserReg user = ticket.GetUserByEmail(email);
            if (user == null)
            {
                Console.WriteLine("Before cancelling the ticket u must have to register");
                return;
            }
            List<Seat> seats = ticket.GetSeatsByBookId(bookid);
            if (ticket.RemoveSeats(seats)) Console.WriteLine("Removed all the seats");
            else Console.WriteLine("seats are not get deleted");

            Schedule schedule = ticket.GetScheduleBySchId(1);
            schedule.SeatAvl += seats.Count();
            if (admin.UpdateSchedule(schedule,1)) Console.WriteLine("Cancelled Seats added to schedule table");
            else Console.WriteLine("There is a prblm while updating the available seats");

            Payment payment = ticket.GetPaymentByBookiId(bookid);
            if (authUser.AddMoneyWallet(user, (decimal)payment.TotalAmt)) Console.WriteLine("refunded successfully");
            else Console.WriteLine("Refund not successfull");

            if (ticket.CancelTicket(bookid)) Console.WriteLine("Finally cancelled the ticket");
            else Console.WriteLine("Ticket cancellation not successfull");


        }

        public static void BusReserve()
        {
            Booking booking = new();
            booking.ScheduleId = 1;
            booking.UserEmail = "Deepu@gmail.com";
            booking.UserMob = "8277398667";
            booking.Npassengers = 1;
            Schedule sch = ticket.GetScheduleBySchId(1);
            booking.Tcharge = sch.Fare * booking.Npassengers;
            booking.IdProof = "KUS654321009";
            Booking booking1 = ticket.BookTicket(booking);
            if (booking1 != null)
                Console.WriteLine("Before making payment -> " + booking1.BookStatus);
            Payment payment = new();
            Seat seat = new();
            seat.SeatId = 13;
            seat.BookId = booking1.BookId;
            payment.BookId = booking1.BookId;
            payment.UserEmail = booking1.UserEmail;
            payment.TotalAmt = booking1.Tcharge;
            payment.PayMode = "Wallet";
            if (payment.PayMode == "Wallet")
            {
                var user = ticket.GetUserByEmail(booking.UserEmail);
                if (user != null)
                {
                    if (user.Wallet >= payment.TotalAmt)
                    {
                        authUser.AddMoneyWallet(user, (decimal)(0 - payment.TotalAmt));
                        booking1.BookStatus = "Booked";
                        booking1 = ticket.UpdateTicket(booking1, booking1.BookId);
                        ticket.MakePayment(payment);
                        ticket.InsertSeat(seat);
                        if (booking1 != null) Console.WriteLine("Booked");
                    }
                    else
                    {
                        Console.WriteLine("Not much money avail");
                    }
                }
                else
                {
                    Console.WriteLine("Not registered");
                }
            }
            else
            {
                ticket.MakePayment(payment);
                booking1.BookStatus = "Booked";
                ticket.InsertSeat(seat);
                ticket.UpdateTicket(booking1, booking1.BookId);
                Console.WriteLine("Booked");
            }

        }

        public static void UpdateSchedule()
        {
            if (ticket.UpdateSchedule(3,10)) Console.WriteLine("Updated");
            else Console.WriteLine("Not updated");
        }

        public static void GetTicketDet(int bookId)
        {
            var bookDet = ticket.GetTicketDetails(bookId);
            if (bookDet != null)
            {
                Console.WriteLine($"{bookDet.BookId}. booked for {bookDet.Npassengers} passengers");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}
