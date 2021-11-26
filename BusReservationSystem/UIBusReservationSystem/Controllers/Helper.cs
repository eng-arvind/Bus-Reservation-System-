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
        public static List<BusScheduleJoin> GetBusScheduleJoins(ADJ adj)
        {
            List<BusScheduleJoin> BusScheduleJoins = new List<BusScheduleJoin>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(localhost);
                var resp = client.GetAsync("TicketApi/GetBusesByLoc/"+adj);
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
    }
}
