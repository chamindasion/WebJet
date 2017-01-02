using System.Collections;
using System.Collections.Generic;
using WJ.MovieWorld.Models.Dto;

namespace WJ.MovieWorld.Service.Contracts
{
    public interface IMovieService
    {
        IEnumerable<MovieDto> Get(Hashtable configurations, string searchCriteria);
        MovieDto GetById(Hashtable configurations, string id, string type);
    }
}
