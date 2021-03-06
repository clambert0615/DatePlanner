﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DateNight.Models
{
    public class ZipCode
    {
        public string[] zip_codes { get; set; }
    }
    public class CityState
    {
        public string zip_code { get; set; }
        public float lat { get; set; }
        public float lng { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public Timezone timezone { get; set; }
        public Acceptable_City_Names[] acceptable_city_names { get; set; }
        public int[] area_codes { get; set; }
    }

    public class Timezone
    {
        public string timezone_identifier { get; set; }
        public string timezone_abbr { get; set; }
        public int utc_offset_sec { get; set; }
        public string is_dst { get; set; }
    }

    public class Acceptable_City_Names
    {
        public string city { get; set; }
        public string state { get; set; }
    }

}

