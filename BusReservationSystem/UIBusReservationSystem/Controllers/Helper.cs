using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using BusReservationSystem.Models;

namespace UIBusReservationSystem.Controllers
{
    public class Helper
    {
        static string localhost = "http://localhost:5863/api/";
        public static List<BusScheduleJoin> GetBusScheduleJoins(string arrive, string dest, string jrnyDate)
        {
            List<BusScheduleJoin> BusScheduleJoins = new List<BusScheduleJoin>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(localhost);
                var resp = client.GetAsync($"TicketApi/GetBusesByLoc/{arrive}/{dest}/{jrnyDate}");
                resp.Wait();
                if (resp.Result.IsSuccessStatusCode)
                {
                    var readres = resp.Result.Content.ReadAsAsync<List<BusScheduleJoin>>();
                    readres.Wait();
                    BusScheduleJoins = readres.Result;
                }
            }
            return BusScheduleJoins;
        }

        public static UserReg AuthenticateUser(Lgn lg)
        {
            UserReg isUser = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(localhost);
                var resp = client.PostAsJsonAsync($"AuthUserAPI/Login",lg);
                resp.Wait();
                if (resp.Result.IsSuccessStatusCode)
                {
                    var readres = resp.Result.Content.ReadAsAsync<UserReg>();
                    readres.Wait();
                    isUser = readres.Result;
                }
            }
            return isUser;
        }

        public static bool RegisterUser(UserReg user)
        {
            bool registered = false;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(localhost);
                var resp = client.PostAsJsonAsync("UserRegApi/RegisterUser", user);
                resp.Wait();
                if (resp.Result.IsSuccessStatusCode)
                {
                    var readres = resp.Result.Content.ReadAsAsync<bool>();
                    readres.Wait();
                    registered = readres.Result;
                }
            }
            return registered;
        }

        public static Schedule GetScheduleById(int sch)
        {
            Schedule schedule = new();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(localhost);
                var resp = client.GetAsync($"TicketApi/GetScheduleBySchId/{sch}");
                resp.Wait();
                if (resp.Result.IsSuccessStatusCode)
                {
                    var readres = resp.Result.Content.ReadAsAsync<Schedule>();
                    readres.Wait();
                    schedule = readres.Result;
                }
            }
            return schedule;
        }

        public static bool InsertBook(Booking booking)
        {
            bool inserted = false;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(localhost);
                var resp = client.PostAsJsonAsync("TicketApi/BookTicket", booking);
                resp.Wait();
                if (resp.Result.IsSuccessStatusCode)
                {
                    var readres = resp.Result.Content.ReadAsAsync<bool>();
                    readres.Wait();
                    inserted = readres.Result;
                }
            }
            return inserted;
        }

        public static List<Booking> GetBookingsBySchId(int schId)
        {
            List<Booking> bookings = new();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(localhost);
                var resp = client.GetAsync($"TicketApi/GetBookingsBySchId/{schId}");
                resp.Wait();
                if (resp.Result.IsSuccessStatusCode)
                {
                    var readres = resp.Result.Content.ReadAsAsync<List<Booking>>();
                    readres.Wait();
                    bookings = readres.Result;
                }
            }
            return bookings;
        }

        public static bool InsertPayment(Payment payment)
        {
            bool Added = false;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(localhost);
                var resp = client.PostAsJsonAsync("TicketApi/MakePayment", payment);
                resp.Wait();
                if (resp.Result.IsSuccessStatusCode)
                {
                    var readres = resp.Result.Content.ReadAsAsync<bool>();
                    readres.Wait();
                    Added = readres.Result;
                }
            }
            return Added;
        }

        public static Booking UpdateTicket(Booking book, int bookId)
        {
            Booking booking = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(localhost);
                var resp = client.PutAsJsonAsync($"TicketApi/UpdateTicket/{bookId}", book);
                resp.Wait();
                if (resp.Result.IsSuccessStatusCode)
                {
                    var readres = resp.Result.Content.ReadAsAsync<Booking>();
                    readres.Wait();
                    booking = readres.Result;
                }
            }
            return booking;
        }

        public static bool AddMoneyToWallet(ADJ adj)
        {
            bool Added = false;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(localhost);
                var resp = client.PutAsJsonAsync("AuthUserAPI/AddMoneyWallet", adj);
                resp.Wait();
                if (resp.Result.IsSuccessStatusCode)
                {
                    var readres = resp.Result.Content.ReadAsAsync<bool>();
                    readres.Wait();
                    Added = readres.Result;
                }
            }
            return Added;
        }

        public static UserReg GetUserById(string userId)
        {
            UserReg user = new();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(localhost);
                var resp = client.GetAsync($"TicketApi/GetUserByEmail/{userId}");
                resp.Wait();
                if (resp.Result.IsSuccessStatusCode)
                {
                    var readres = resp.Result.Content.ReadAsAsync<UserReg>();
                    readres.Wait();
                    user = readres.Result;
                }
            }
            return user;
        }

        public static List<Seat> GetSeatsByBookId(int bookId)
        {
            List<Seat> seats = new();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(localhost);
                var resp = client.GetAsync($"TicketApi/GetSeatsByBookId/{bookId}");
                resp.Wait();
                if (resp.Result.IsSuccessStatusCode)
                {
                    var readres = resp.Result.Content.ReadAsAsync<List<Seat>>();
                    readres.Wait();
                    seats = readres.Result;
                }
            }
            return seats;
        }

        public static int GetLastBookId()
        {
            int bookId = 0;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(localhost);
                var resp = client.GetAsync($"TicketApi/GetLastBookId");
                resp.Wait();
                if (resp.Result.IsSuccessStatusCode)
                {
                    var readres = resp.Result.Content.ReadAsAsync<int>();
                    readres.Wait();
                    bookId = readres.Result;
                }
            }
            return bookId;
        }

        public static Booking GetBookingByBookId(int bookId)
        {
            Booking booking = new();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(localhost);
                var resp = client.GetAsync($"TicketApi/GetBookingByBookId/{bookId}");
                resp.Wait();
                if (resp.Result.IsSuccessStatusCode)
                {
                    var readres = resp.Result.Content.ReadAsAsync<Booking>();
                    readres.Wait();
                    booking = readres.Result;
                }
            }
            return booking;
        }

        public static bool InsertSeat(Seat seat)
        {
            bool inserted = false;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(localhost);
                var resp = client.PostAsJsonAsync("TicketApi/InsertSeat", seat);
                resp.Wait();
                if (resp.Result.IsSuccessStatusCode)
                {
                    var readres = resp.Result.Content.ReadAsAsync<bool>();
                    readres.Wait();
                    inserted = readres.Result;
                }
            }
            return inserted;
        }

        public static Route GetRouteById(int routeId)
        {
            Route route = new();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(localhost);
                var resp = client.GetAsync($"TicketApi/GetRouteById/{routeId}");
                resp.Wait();
                if (resp.Result.IsSuccessStatusCode)
                {
                    var readres = resp.Result.Content.ReadAsAsync<Route>();
                    readres.Wait();
                    route = readres.Result;
                }
            }
            return route;
        }
        public static Bus GetBusById(int busId)
        {
            Bus bus = new();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(localhost);
                var resp = client.GetAsync($"TicketApi/GetBusById/{busId}");
                resp.Wait();
                if (resp.Result.IsSuccessStatusCode)
                {
                    var readres = resp.Result.Content.ReadAsAsync<Bus>();
                    readres.Wait();
                    bus = readres.Result;
                }
            }
            return bus;
        }
        public static bool EditProfile(UserReg user, string userId)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(localhost);
                var resp = client.PutAsJsonAsync($"AuthUserAPI/UpdateProfile/{userId}", user);
                resp.Wait();
                if (resp.Result.IsSuccessStatusCode)
                {
                    var readres = resp.Result.Content.ReadAsAsync<bool>();
                    readres.Wait();
                    return readres.Result;
                }
            }
            return false;
        }
        public static bool ResetPass(UserReg user, string userId)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(localhost);
                var resp = client.PutAsJsonAsync($"AuthUserAPI/ResetPassword/{userId}",user);
                resp.Wait();
                if (resp.Result.IsSuccessStatusCode)
                {
                    var readres = resp.Result.Content.ReadAsAsync<bool>();
                    readres.Wait();
                    return readres.Result;
                }
            }
            return false;
        }
        public static List<Booking> GetReservations(UserReg user)
        {
            List<Booking> bookings = new();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(localhost);
                var resp = client.GetAsync($"AuthUserAPI/GetLastReservations/{user.UserEmail}");
                resp.Wait();
                if (resp.Result.IsSuccessStatusCode)
                {
                    var readres = resp.Result.Content.ReadAsAsync<List<Booking>>();
                    readres.Wait();
                    bookings = readres.Result;
                }
            }
            return bookings;
        }

        public static Payment GetPayment(int bookId)
        {
            Payment payment = new();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(localhost);
                var resp = client.GetAsync($"TicketApi/GetPaymentByBookId/{bookId}");
                resp.Wait();
                if (resp.Result.IsSuccessStatusCode)
                {
                    var readres = resp.Result.Content.ReadAsAsync<Payment>();
                    readres.Wait();
                    payment = readres.Result;
                }
            }
            return payment;
        }

        public static bool RemoveSeats(List<Seat> seats)
        {
            bool removed = false;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(localhost);
                var resp = client.PutAsJsonAsync($"TicketApi/DeleteSeats",seats);
                resp.Wait();
                if (resp.Result.IsSuccessStatusCode)
                {
                    var readres = resp.Result.Content.ReadAsAsync<bool>();
                    readres.Wait();
                    return readres.Result;
                }
            }
            return removed;
        }
        public static bool UpdateSeatAvailability(Schedule schedule, int schId)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(localhost);
                var resp = client.PutAsJsonAsync($"TicketApi/UpdateSchedule/{schId}",schedule);
                resp.Wait();
                if (resp.Result.IsSuccessStatusCode)
                {
                    var readres = resp.Result.Content.ReadAsAsync<bool>();
                    readres.Wait();
                    return readres.Result;
                }
            }
            return false;
        }
        public static bool RemoveBooking(int bookId)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(localhost);
                var resp = client.DeleteAsync($"TicketApi/DeleteTicket/{bookId}");
                resp.Wait();
                if (resp.Result.IsSuccessStatusCode)
                {
                    var readres = resp.Result.Content.ReadAsAsync<bool>();
                    readres.Wait();
                    return readres.Result;
                }
            }
            return false;
        }
    }
}
