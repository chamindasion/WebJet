
namespace WJ.MovieWorld.Models.DomainObjects
{
    public class MovieDetail : MovieBase
    {
        public string Rated { get; set; }
        public string Released { get; set; }
        public string Runtime { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public int Metascore { get; set; }
        public decimal Rating { get; set; }
        public double Price { get; set; }
    }
}

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
