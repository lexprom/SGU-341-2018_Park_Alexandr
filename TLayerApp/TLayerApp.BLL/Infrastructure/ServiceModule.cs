using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject.Modules;
using System.Threading.Tasks;
using TLayerApp.DAL.Interfaces;
using TLayerApp.DAL.Repositories;

namespace TLayerApp.BLL.Infrastructure
{
    public class ServiceModule : NinjectModule
    {
        private string connectionString;

        public ServiceModule(string connection)
        {
            connectionString = connection;
        }

        public override void Load()
        {
            Bind<IUnitOfWork>().To<EFUnitOfWork>().WithConstructorArgument(connectionString);
        }
    }
}
