using DateNight.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;


namespace DateNight.Models
{
    public class EventsDAL
    {
        private readonly string APIKey;
        public EventsDAL(IConfiguration configuration)
        {
            APIKey = configuration.GetSection("ApiKeys")["Eventful"];
        }
        public HttpClient GetHttpClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://api.eventful.com/rest/");
            return client;
        }
        public async Task<search>GetEvents(string location, string keywords)
        {
            string encodedLocation = HttpUtility.UrlEncode(location);
            string encodedKeywords = HttpUtility.UrlEncode(keywords);
            HttpClient client = GetHttpClient();
            var response = await client.GetStringAsync($"events/search?app_key={APIKey}&location={encodedLocation}&keywords={encodedKeywords}&page_size=25");
            var stringReader = new System.IO.StringReader(response);
            var serializer = new XmlSerializer(typeof(search));
            return serializer.Deserialize(stringReader) as search;
        }

        public async Task<Event> GetDetails(string id)
        {
            HttpClient client = GetHttpClient();
            var response = await client.GetStringAsync($"events/get?app_key={APIKey}&id={id}");
            var stringReader = new System.IO.StringReader(response);
            var serializer = new XmlSerializer(typeof(Event));
            return serializer.Deserialize(stringReader) as Event;
        }
    }
}
