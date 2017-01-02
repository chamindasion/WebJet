
namespace WJ.MovieWorld.Models.Dto
{
    public class MovieDetailDto : BaseDto
    {
        public long MovieId { get; set; }
        public string Title { get; set; }
        public double CWPrice { get; set; }
        public double FWPrice { get; set; }
    }
}
