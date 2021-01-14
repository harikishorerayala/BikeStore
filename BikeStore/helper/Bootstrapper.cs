using DataModel;
using DataModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BikeStore.helper
{
    public static class Bootstrapper
    {
        public static void Init()
        {
            DependencyInjector.Register<IDataProjModel, DataProjModel>();
        }
    }
}