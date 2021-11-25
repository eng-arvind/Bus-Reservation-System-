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
        static string localhost = "http://localhost:38245/api/";
        public static List<BusScheduleJoin> GetBusScheduleJoins(string Arrive, string dest, string jrnyDate)
        {
            List<BusScheduleJoin> BusScheduleJoins = new List<BusScheduleJoin>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(localhost);
                var resp = client.GetAsync($"/api/TicketApi/GetBusesByLoc/{Arrive}/{dest}/{jrnyDate}");
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
    }
}
