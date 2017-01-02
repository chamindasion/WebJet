
namespace WJ.MovieWorld.Service.Contracts
{
    public interface IServiceFactory
    {
        TService GetService<TService>();
    }
}
