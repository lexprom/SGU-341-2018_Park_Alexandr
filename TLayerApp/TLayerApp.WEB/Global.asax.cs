using Ninject;
using Ninject.Modules;
using Ninject.Web.Mvc;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TLayerApp.BLL.Infrastructure;
using TLayerApp.WEB.Util;

namespace TLayerApp.WEB
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //injection dependecies

            NinjectModule userModule = new UserModule();
            NinjectModule serviceModule = new ServiceModule(@"Data Source=LEX\SQLSERVEREXP;Integrated Security=SSPI;Initial Catalog=Athlets");
            var kernel = new StandardKernel(userModule,serviceModule);
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}
