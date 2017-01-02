
using System.Collections.Generic;

namespace WJ.MovieWorld.Models.Dto
{
    public class RecordLocatorDto : BaseDto
    {
        public string Name { get; set; }
        public IList<PassengerDto> Passengers { get; set; }
    }
}
