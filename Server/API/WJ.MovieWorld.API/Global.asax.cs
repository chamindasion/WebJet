using System.Web.Http;
using WJ.MovieWorld.API.App_Start;

namespace WJ.MovieWorld.API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            SimpleInjectorConfig.RegisterComponents();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
