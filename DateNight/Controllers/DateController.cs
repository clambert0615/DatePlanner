using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DateNight.Models;
using Microsoft.AspNetCore.Mvc;

namespace DateNight.Controllers
{
    public class DateController : Controller
    {
        private readonly DateDbContext _context;
        private readonly JokeDAL jd = new JokeDAL();
        private readonly TriviaDAL td = new TriviaDAL();
        public DateController(DateDbContext Context)
        {
            _context = Context;
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
    }
}
