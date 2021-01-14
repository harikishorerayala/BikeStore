using DataModel;
using DataModel.Interfaces;
using System.Web.Http;
using Unity;
using Unity.Extension;
using Unity.Lifetime;
using Unity.WebApi;

namespace BikeStore
{
    public static class UnityConfig
    {       
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IBrandModel, BrandModel>();
            container.AddNewExtension<DependencyInjectionExtension>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
           


        }
    }
}