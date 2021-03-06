﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DateNight.Models
{
    public class JokeDAL
    {
        public HttpClient GetHttpClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://icanhazdadjoke.com/");
            return client;
        }

        public async Task<Jokes> GetRandomJokes()
        {
            HttpClient client = GetHttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            var response = await client.GetAsync("search");
            Jokes jokes = await response.Content.ReadAsAsync<Jokes>();
            return jokes;
        }

        public async Task<Jokes> GetTermJoke(string term)
        {
            HttpClient client = GetHttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            var response = await client.GetAsync($"search?term={term}");
            Jokes jokes = await response.Content.ReadAsAsync<Jokes>();
            return jokes;
        }
        public async Task<Jokes> GetMore(int nextPage, string term)
        {
            HttpClient client = GetHttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            if (term == null)
            {
                var response = await client.GetAsync($"search?page={nextPage}");
                Jokes jokes = await response.Content.ReadAsAsync<Jokes>();
                return jokes;
            }
            else
            {
                var response = await client.GetAsync($"search?page={nextPage}&term={term}");
                Jokes jokes = await response.Content.ReadAsAsync<Jokes>();
                return jokes;
            }

        }
    }
}
