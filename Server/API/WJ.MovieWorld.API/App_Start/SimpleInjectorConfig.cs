using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using System.Web.Http;
using WJ.MovieWorld.Service;
using WJ.MovieWorld.Service.Contracts;

namespace WJ.MovieWorld.API.App_Start
{
    public static class SimpleInjectorConfig
    {
        public static void RegisterComponents()
        {
            var container = new Container();

            container.Options.PropertySelectionBehavior = new ImportPropertySelectionBehavior();
            //container.RegisterWebApiFilterProvider(GlobalConfiguration.Configuration);

            #region Shared Utilities

            container.RegisterWebApiRequest<IServiceFactory, ServiceFactory>();
            container.RegisterWebApiRequest<IMovieService, MovieService>();

            #endregion Shared Utilities

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
            container.Verify();
            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }
    }
}