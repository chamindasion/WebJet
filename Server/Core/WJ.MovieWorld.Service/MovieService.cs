using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using WJ.MovieWorld.Models;
using WJ.MovieWorld.Models.DomainObjects;
using WJ.MovieWorld.Models.Dto;
using WJ.MovieWorld.Service.Contracts;

namespace WJ.MovieWorld.Service
{
    public class MovieService : IMovieService
    {
        public IEnumerable<MovieDto> Get(Hashtable configurations, string searchCriteria)
        {
            var url = Convert.ToString(configurations[WJConfigurations.MovieUrl]);
            var token = Convert.ToString(configurations[WJConfigurations.MovieToken]);
            var fwName = Convert.ToString(configurations[WJConfigurations.FilmWorldName]);
            var cwName = Convert.ToString(configurations[WJConfigurations.CinemaWorldName]);

            //Get records from filmworld            
            var filmWorldSummaryResult = GetMovies(url, null, token, fwName);

            var cinemaWorldSummaryResult = GetMovies(url, null, token, cwName);

            var finalResult = new List<MovieDto>();
            var currentBulkMovies = (cinemaWorldSummaryResult.movies == null ? 0 : cinemaWorldSummaryResult.movies.Count) >
                (filmWorldSummaryResult.movies == null ? 0 : filmWorldSummaryResult.movies.Count)
                ? cinemaWorldSummaryResult.movies
                : filmWorldSummaryResult.movies;

            if (currentBulkMovies != null && currentBulkMovies.Count > 0)
            {
                if (!string.IsNullOrWhiteSpace(searchCriteria))
                    currentBulkMovies = currentBulkMovies.Where(p => new Regex(searchCriteria.ToLower())
                        .IsMatch(p.Title.ToLower())).ToList();

                foreach (var currentMovie in currentBulkMovies)
                {
                    var tempMovieDto = currentMovie.BasicConvertTo<MovieDto>();
                    tempMovieDto.ID = tempMovieDto.ID.Substring(2);
                    finalResult.Add(tempMovieDto);
                }
            }
            return finalResult;
        }

        public MovieDto GetById(Hashtable configurations, string id, string type)
        {
            var url = Convert.ToString(configurations[WJConfigurations.MovieUrl]);
            var token = Convert.ToString(configurations[WJConfigurations.MovieToken]);
            var fwName = Convert.ToString(configurations[WJConfigurations.FilmWorldName]);
            var cwName = Convert.ToString(configurations[WJConfigurations.CinemaWorldName]);
            var cwPrefix = Convert.ToString(configurations[WJConfigurations.CinemaWorldPrefix]);

            //Get records from filmworld                        
            var cinemaName = type.ToLower().Equals(cwPrefix) ? cwName : fwName;

            var movieDetailResult = GetMovieDetail(url, null, token, cinemaName, type, id);
            var tempMovieDto = new MovieDto();
            if (movieDetailResult != null)
            {
                tempMovieDto = movieDetailResult.BasicConvertTo<MovieDto>();
            }
            return tempMovieDto;
        }


        private MovieSummary GetMovies(string url, string urlParameters, string token, string cinemaName)
        {
            using (var client = new HttpClient { BaseAddress = new Uri(url + cinemaName + "/movies") })
            {
                var response = GetHttpResponseMessage(urlParameters, token, client);
                if (response.IsSuccessStatusCode)
                {
                    var des = (MovieSummary)Newtonsoft.Json.JsonConvert.DeserializeObject
                        (response.Content.ReadAsStringAsync().Result, typeof(MovieSummary));
                    return des;
                }
                return new MovieSummary();
            }
        }

        private MovieDetail GetMovieDetail(string url, string urlParameters, string token, string cinemaName, string cinemaPrefix, string movieId)
        {
            using (var client = new HttpClient { BaseAddress = new Uri(url + cinemaName + "/movie/" + cinemaPrefix + movieId) })
            {
                var response = GetHttpResponseMessage(urlParameters, token, client);
                if (response.IsSuccessStatusCode)
                {
                    var des = (MovieDetail)Newtonsoft.Json.JsonConvert.DeserializeObject
                        (response.Content.ReadAsStringAsync().Result, typeof(MovieDetail));
                    return des;
                }
                return new MovieDetail();
            }
        }

        private static HttpResponseMessage GetHttpResponseMessage(string urlParameters, string token, HttpClient client)
        {
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("x-access-token", token);

            var response = client.GetAsync(urlParameters).Result;
            return response;
        }
    }
}
