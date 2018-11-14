using Incentive.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Incentive.Services
{
    public class ClienteService
    {
        
        
            private const string BASE = "http://www.incentive.cl";
            private const int PORT = 8004;


            public static async System.Threading.Tasks.Task<List<Cliente>> GetAllAsync(string path)
            {

                using (var httpClient = new HttpClient())
                {
                    var json = await httpClient.GetStringAsync($"{BASE}:{PORT}/{path}");
                    return JsonConvert.DeserializeObject<List<Cliente>>(json);
                }
            }

            public static async System.Threading.Tasks.Task<Cliente> GetOneAsync(string path, int id)
            {

                using (var httpClient = new HttpClient())
                {
                    var json = await httpClient.GetStringAsync($"{BASE}:{PORT}/{path}?id={id}");
                    return JsonConvert.DeserializeObject<Cliente>(json);
                }
            }
    }
}

