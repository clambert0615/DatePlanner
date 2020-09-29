using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DateNight.Models
{
    public class WeatherDAL
    {
        private readonly string APIKey;

        public WeatherDAL(IConfiguration configuration)
        {
            APIKey = configuration.GetSection("ApiKeys")["WeatherAPI"];
        }

        public HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://api.weatherapi.com/v1/");
            return client;
        }

        public async Task<Weather> GetWeather(string zip)
        {
            HttpClient client = GetClient();
            HttpResponseMessage response = await client.GetAsync($"forecast.json?key={APIKey}&q={zip}&days=3");
            Weather weather = await response.Content.ReadAsAsync<Weather>();
            return weather;

        }
    }
}
