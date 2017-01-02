using WJ.MovieWorld.Service.Contracts;
using SimpleInjector;

namespace WJ.MovieWorld.Service
{
    public class ServiceFactory : IServiceFactory
    {
        private readonly Container _container;

        public ServiceFactory(Container container)
        {
            _container = container;
        }

        public TService GetService<TService>()
        {
            return (TService)_container.GetInstance(typeof(TService));
        }
    }
}
