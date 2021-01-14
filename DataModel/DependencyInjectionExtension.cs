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
            Container.RegisterType<IBrandManager, BrandManager>();
        }
    }
}