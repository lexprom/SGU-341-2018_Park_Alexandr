using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLayerApp.DAL.Entities;

namespace TLayerApp.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<User> User { get; }
        IRepository<Medal> Medal { get; }
        void Save();
    }
}
