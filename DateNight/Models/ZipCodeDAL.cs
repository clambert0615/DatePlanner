using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DateNight.Models
{
    public class ZipCodeDAL
    {
        private readonly string APIKey;
        public ZipCodeDAL(IConfiguration configuration)
        {
            APIKey = configuration.GetSection("ApiKeys")["ZipAPI"];
        }

        public HttpClient GetHttpClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://www.zipcodeapi.com/rest/");
            return client;
        }

        public async Task<ZipCode> GetZip(string city, string state)
        {
            HttpClient client = GetHttpClient();
            HttpResponseMessage response = await client.GetAsync($"{APIKey}/city-zips.json/{city}/{state}");
            ZipCode zip = await response.Content.ReadAsAsync<ZipCode>();
            //var zipjson = await response.Content.ReadAsStringAsync();
            //ZipCode zip = JsonConvert.DeserializeObject<ZipCode>(zipjson);
            return zip;
        }
        public async Task<CityState> GetCity(string zip)
        {
            HttpClient client = GetHttpClient();
            HttpResponseMessage response = await client.GetAsync($"{APIKey}/info.json/{zip}/degrees");
            CityState city = await response.Content.ReadAsAsync<CityState>();
           // var cityjson = await response.Content.ReadAsStringAsync();
            //CityState city = JsonConvert.DeserializeObject<CityState>(cityjson);
            return city;
        }


    }
}

