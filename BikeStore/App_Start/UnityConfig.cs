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
            //register all your DataModel objects
            container.RegisterType<IBrandModel, BrandModel>();
            container.RegisterType<IAuthenticationModel, AuthenticationModel>();

            //this will register the DataManager Layer using extension class in DataModel layer.
            container.AddNewExtension<DependencyInjectionExtension>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
           


        }
    }
}