using Datos.Repository;
using Datos;
using System.Data.Entity;
using System.Web.Http;
using Unity;
using Unity.Lifetime;
using Unity.WebApi;
using ApiNET.Model;

namespace ApiNET
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
            container.RegisterType<DbContext, ContextPosJava>(new HierarchicalLifetimeManager());

            // Registro del repositorio genérico
            container.RegisterType(typeof(IRepository<>), typeof(Repository<>), new HierarchicalLifetimeManager());

            // Registro del repositorio específico
            container.RegisterType<CategoryRepository>(new HierarchicalLifetimeManager());

            // Configurar el Dependency Resolver de Web API para usar Unity
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}