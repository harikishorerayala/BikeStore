using DataManager;
using DataManager.Interfaces;
using Unity;
using Unity.Extension;

namespace DataModel
{
    public class DependencyOfDependencyExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IBrandManager, BrandManager>();
        }
    }
}