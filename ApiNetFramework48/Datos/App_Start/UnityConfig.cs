using System.Web.Http;
using Unity;
using Unity.WebApi;
using Unity.Lifetime;
using Datos.Interface;
using Datos.Repository;

namespace Datos
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<ICategoryRepository, CategoryRepository>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}