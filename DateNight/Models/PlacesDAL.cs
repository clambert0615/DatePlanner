using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DateNight.Models
{
    public class PlacesDAL
    {
        private readonly string APIKey;
        public PlacesDAL(IConfiguration configuration)
        {
            APIKey = configuration.GetSection("ApiKeys")["Google"];
        }

        public HttpClient GetHttpClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://maps.googleapis.com/maps/api/place/");
            return client;
        }

        public async Task<Places>GetPlaces(float latitude, float longitude, string keyword)
        {
            HttpClient client = GetHttpClient();
            HttpResponseMessage response = await client.GetAsync($"nearbysearch/json?keyword={keyword}&key={APIKey}&location={latitude},{longitude}&radius=15000");
            Places places = await response.Content.ReadAsAsync<Places>();
            return places;
        }

        public async Task<PlaceDetails> GetDetails(string id)
        {
            HttpClient client = GetHttpClient();
            HttpResponseMessage response = await client.GetAsync($"details/json?place_id={id}&fields=name,formatted_address,photo,place_id,vicinity,website,rating,review&key={APIKey}");
            PlaceDetails details = await response.Content.ReadAsAsync<PlaceDetails>();
            details.apiKey = APIKey;
            return details;
        }

        public async Task<Places> MorePlaces(string pagetoken)
        {
            HttpClient client = GetHttpClient();
            HttpResponseMessage response = await client.GetAsync($"nearbysearch/json?pagetoken={pagetoken}&key={APIKey}");
            Places places = await response.Content.ReadAsAsync<Places>();
            return places;
        }
        public async Task<Places> GetRestaurants(float latitude, float longitude, string cuisine)
        {
            HttpClient client = GetHttpClient();
            HttpResponseMessage response = await client.GetAsync($"nearbysearch/json?type=restaurant&keyword={cuisine}&key={APIKey}&location={latitude},{longitude}&radius=15000");
            Places places = await response.Content.ReadAsAsync<Places>();
            return places;
        }
    }
}
