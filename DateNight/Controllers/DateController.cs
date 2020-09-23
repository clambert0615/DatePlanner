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
            Jokes response = await jd.GetRandomJokes();
            var randomJokes = response.results;
            return View(randomJokes);
        }
    }
}
