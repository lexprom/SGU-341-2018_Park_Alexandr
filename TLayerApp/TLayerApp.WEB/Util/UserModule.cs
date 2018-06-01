using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using TLayerApp.BLL.Interfaces;
using TLayerApp.BLL.Services;

namespace TLayerApp.WEB.Util
{
    public class UserModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMedalService>().To<MedalService>();
        }
    }
}