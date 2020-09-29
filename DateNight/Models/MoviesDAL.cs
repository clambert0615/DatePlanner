using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DateNight.Models
{
    public class MoviesDAL
    {
        private readonly string APIKey;
        public MoviesDAL(IConfiguration Configuration)
        {
            APIKey = Configuration.GetSection("ApiKeys")["Movie"];
        }

        public HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://data.tmsapi.com/v1.1/movies/");
            return client;
        }

        public async Task<Movie[]> GetMovies(string zip, string date)
        {
            HttpClient client = GetClient();
            var response = await client.GetAsync($"showings?startDate={date}&zip={zip}&api_key={APIKey}");
            Movie[] movies = await response.Content.ReadAsAsync<Movie[]>();
            return movies;
        }
    }
}
