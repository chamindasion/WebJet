using System.Collections;
using System.Collections.Generic;
using System.Web.Configuration;
using System.Web.Http;
using WJ.MovieWorld.Models;
using WJ.MovieWorld.Models.Dto;
using WJ.MovieWorld.Service.Contracts;

namespace WJ.MovieWorld.API.Controllers
{
    [RoutePrefix("api")]
    public class MovieController : ApiController
    {
        private readonly IMovieService _movieService;
        private readonly Hashtable _configurations;

        public MovieController(IServiceFactory serviceFactory)
        {
            _movieService = serviceFactory.GetService<IMovieService>();
            _configurations = new Hashtable
            {
                {WJConfigurations.MovieUrl, WebConfigurationManager.AppSettings[WJConfigurations.MovieUrl]},
                {WJConfigurations.MovieToken, WebConfigurationManager.AppSettings[WJConfigurations.MovieToken]},
                {WJConfigurations.FilmWorldName, WebConfigurationManager.AppSettings[WJConfigurations.FilmWorldName]},
                {
                    WJConfigurations.CinemaWorldName, WebConfigurationManager.AppSettings[WJConfigurations.CinemaWorldName]
                },
                {
                    WJConfigurations.FilmWorldPrefix, WebConfigurationManager.AppSettings[WJConfigurations.FilmWorldPrefix]
                },
                {
                    WJConfigurations.CinemaWorldPrefix,
                    WebConfigurationManager.AppSettings[WJConfigurations.CinemaWorldPrefix]
                }
            };
        }

        [Route("movies")]
        public IEnumerable<MovieDto> Get(string searchCriteria = "")
        {
            return _movieService.Get(_configurations, !string.IsNullOrWhiteSpace(searchCriteria) ? searchCriteria.ToLower() : searchCriteria);
        }

        [Route("movie")]
        public MovieDto GetById(string id, string type)
        {
            return _movieService.GetById(_configurations, id, type);
        }
    }
}
