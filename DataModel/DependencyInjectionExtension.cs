using DataManager;
using DataManager.Interfaces;
using Unity.Extension;
using Unity;

namespace DataModel
{
    public class DependencyInjectionExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {
            //Register all your Manager  Interfaces with its concrete types here
            Container.RegisterType<IBrandManager, BrandManager>();
        }
    }
}