using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DateNight.Models
{
    public class TriviaDAL
    {
        public HttpClient GetHttpClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://opentdb.com/api.php");
            return client;
        }

        public async Task<Trivia> GetTrivia()
        {
            HttpClient client = GetHttpClient();
            var response = await client.GetAsync("?amount=10");
            Trivia trivia = await response.Content.ReadAsAsync<Trivia>();
            return trivia;
        }
        public async Task<Trivia> GetCategory(string category)
        {
            HttpClient client = GetHttpClient();
            var response = await client.GetAsync($"?amount=10&category={category}");
            Trivia trivia = await response.Content.ReadAsAsync<Trivia>();
            return trivia;
        }
    }
}
