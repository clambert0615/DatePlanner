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
        public DateController(DateDbContext Context, IConfiguration configuration)
        {
            _context = Context;
            ed = new EventsDAL(configuration);
            md = new MoviesDAL(configuration);
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

        public async Task<IActionResult> Movies(string zip, DateTime date)
        {
            string dateConvert = date.ToString("yyyy-MM-dd");
            Movie[] movies = await md.GetMovies(zip, dateConvert);
            return View(movies);
        }
    }
}
