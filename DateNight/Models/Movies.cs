using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DateNight.Models
{
    public class Rootobject
    {
       public Movie[] Property1 { get; set; }
    }

    public class Movie
    {
        public string tmsId { get; set; }
        public string rootId { get; set; }
        public string subType { get; set; }
        public string title { get; set; }
        public int releaseYear { get; set; }
        public string releaseDate { get; set; }
        public string titleLang { get; set; }
        public string descriptionLang { get; set; }
        public string entityType { get; set; }
        public string[] genres { get; set; }
        public string longDescription { get; set; }
        public string shortDescription { get; set; }
        public string[] topCast { get; set; }
        public string[] directors { get; set; }
        public Rating[] ratings { get; set; }
        public string[] advisories { get; set; }
        public string runTime { get; set; }
        public Preferredimage preferredImage { get; set; }
        public Showtime[] showtimes { get; set; }
        public string officialUrl { get; set; }
        public Qualityrating qualityRating { get; set; }
        public string audience { get; set; }
        public string animation { get; set; }
        public string Key { get; set; }
    }

    public class Preferredimage
    {
        public string width { get; set; }
        public string height { get; set; }
        public Caption caption { get; set; }
        public string uri { get; set; }
        public string category { get; set; }
        public string text { get; set; }
        public string primary { get; set; }
    }

    public class Caption
    {
        public string content { get; set; }
        public string lang { get; set; }
    }

    public class Qualityrating
    {
        public string ratingsBody { get; set; }
        public string value { get; set; }
    }

    public class Rating
    {
        public string body { get; set; }
        public string code { get; set; }
    }

    public class Showtime
    {
        public Theatre theatre { get; set; }
        public string dateTime { get; set; }
        public string quals { get; set; }
        public bool barg { get; set; }
        public string ticketURI { get; set; }
    }

    public class Theatre
    {
        public string id { get; set; }
        public string name { get; set; }
    }




}
