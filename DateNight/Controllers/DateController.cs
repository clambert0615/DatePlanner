using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DateNight.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;


namespace DateNight.Controllers
{
    public class DateController : Controller
    {
        private readonly DateDbContext _context;
        private readonly JokeDAL jd = new JokeDAL();
        private readonly TriviaDAL td = new TriviaDAL();
        private readonly EventsDAL ed;
        private readonly MoviesDAL md;
        private readonly ZipCodeDAL zd;
        private readonly PlacesDAL pd;
        private readonly WeatherDAL wd;
        public DateController(DateDbContext Context, IConfiguration configuration)
        {
            _context = Context;
            ed = new EventsDAL(configuration);
            md = new MoviesDAL(configuration);
            zd = new ZipCodeDAL(configuration);
            pd = new PlacesDAL(configuration);
            wd = new WeatherDAL(configuration);
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult IceBreakers()
        {
            return View();
        }
        public async Task<IActionResult> RandomJokes()
        {
            Jokes jokes = await jd.GetRandomJokes();
            return View(jokes);
        }
        public async Task<IActionResult> TermJokes(string term)
        {
            Jokes termJokes = await jd.GetTermJoke(term);
            termJokes.search_term = term;
            return View(termJokes);
        }
        public async Task<IActionResult> MoreJokes(int next, string term)
        {
            
            Jokes moreJokes = await jd.GetMore(next, term);
            return View(moreJokes);
     
        }
        public async Task<IActionResult> RandomTrivia()
        {
            Trivia trivia = await td.GetTrivia();
            return View(trivia);
        }
        public async Task<IActionResult> CategoryTrivia(string trivcategory)
        {
            Trivia trivia = await td.GetCategory(trivcategory);
            Results result = new Results();
            result.category = trivcategory;
            TriviaResults tr = new TriviaResults();
            tr.Trivia = trivia;
            tr.Results = result;
            return View(tr);
        }
        public IActionResult EventIndex()
        {
            return View();
        }
        public async Task<IActionResult> Events(string location, string keyword)
        {
            
            search events = await ed.GetEvents(location, keyword);
            return View(events);
        }
        public async Task<IActionResult> EventDetails(string id)
        {
            Event eventDetails = await ed.GetDetails(id);
            return View(eventDetails);
        }

        public IActionResult MovieIndex()
        {
            return View();
        }
        public async Task<IActionResult> Movies(string zip, DateTime date)
        {
            string dateConvert = date.ToString("yyyy-MM-dd");
            Movie[] movies = await md.GetMovies(zip, dateConvert);
            return View(movies);
        }
        public IActionResult ActivityIndex()
        {
            return View();
        }
        public async Task<IActionResult> Places(string zip, string keyword)
        {
            CityState location = await zd.GetCity(zip);
            float latitude = location.lat;
            float longitude = location.lng;
            Places places = await pd.GetPlaces(latitude, longitude, keyword);
            return View(places);
        }
        
        public async Task<IActionResult> PlaceDetails(string id)
        {
            PlaceDetails details = await pd.GetDetails(id);
            return View(details);
        }

        public async Task<IActionResult> GetMorePlaces(string token)
        {
            var morePlaces = await pd.MorePlaces(token);
            return View(morePlaces);
        }
        public IActionResult RestaurantIndex()
        {
            return View();
        }
        public async Task<IActionResult> Restaurants(string zip, string cuisine)
        {
            CityState location = await zd.GetCity(zip);
            float latitude = location.lat;
            float longitude = location.lng;
            Places places = await pd.GetRestaurants(latitude, longitude, cuisine);
            return View(places);
        }
        public IActionResult WeatherIndex()
        {
            return View();
        }
        public async Task<IActionResult> Weather(string zip)
        {
            Weather weather = await wd.GetWeather(zip);
            return View(weather);
        }

        public IActionResult Quiz()
        {
            return View();
        }
        public IActionResult StyleQuiz()
        {
            return View();
        }
    }
}
