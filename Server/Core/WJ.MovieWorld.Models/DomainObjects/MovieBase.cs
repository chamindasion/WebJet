﻿using System.Collections.Generic;

namespace WJ.MovieWorld.Models.DomainObjects
{
    public class MovieBase : BaseDomainObject
    {
        public long MovieId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string ID { get; set; }
        public string Type { get; set; }
        public string Poster { get; set; }
    }

    public class MovieSummary
    {
        public List<MovieBase> movies { get; set; }
    }
}


/*
  "Movies": [
        {
            "Title": "Star Wars: Episode IV - A New Hope",
            "Year": "1977",
            "ID": "fw0076759",
            "Type": "movie",
            "Poster": "http://ia.media-imdb.com/images/M/MV5BOTIyMDY2NGQtOGJjNi00OTk4LWFhMDgtYmE3M2NiYzM0YTVmXkEyXkFqcGdeQXVyNTU1NTfwOTk@._V1_SX300.jpg"
        },       
 */

/*
 {
    "Title": "Star Wars: Episode IV - A New Hope",
    "Year": "1977",
    "Rated": "PG",
    "Released": "25 May 1977",
    "Runtime": "121 min",
    "Genre": "Action, Adventure, Fantasy",
    "Director": "George Lucas",
    "Writer": "George Lucas",
    "Actors": "Mark Hamill, Harrison Ford, Carrie Fisher, Peter Cushing",
    "Plot": "Luke Skywalker joins forces with a Jedi Knight, a cocky pilot, a wookiee and two droids to save the galaxy from the Empire's world-destroying battle-station, while also attempting to rescue Princess Leia from the evil Darth Vader.",
    "Language": "English",
    "Country": "USA",
    "Poster": "http://ia.media-imdb.com/images/M/MV5BOTIyMDY2NGQtOGJjNi00OTk4LWFhMDgtYmE3M2NiYzM0YTVmXkEyXkFqcGdeQXVyNTU1NTfwOTk@._V1_SX300.jpg",
    "Metascore": "92",
    "Rating": "8.7",
    "Votes": "915,459",
    "ID": "fw0076759",
    "Type": "movie",
    "Price": "29.5"
}
*/