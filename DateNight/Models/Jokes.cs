using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DateNight.Models
{
    public class Jokes
    {

            public int current_page { get; set; }
            public int limit { get; set; }
            public int next_page { get; set; }
            public int previous_page { get; set; }
            public Result[] results { get; set; }
            public string search_term { get; set; }
            public int status { get; set; }
            public int total_jokes { get; set; }
            public int total_pages { get; set; }
     }

        public class Result
        {
            public string id { get; set; }
            public string joke { get; set; }
        }

    }

