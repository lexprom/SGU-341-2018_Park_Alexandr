using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLayerApp.DAL.EF;
using TLayerApp.DAL.Entities;
using TLayerApp.DAL.Interfaces;

namespace TLayerApp.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private UserContext db;
        private UserRepository userRepository;
        private MedalRepository medalRepository;

        public EFUnitOfWork(string connectionString)
        {
            db = new UserContext(connectionString);
        }

        public IRepository<User> Users
        {
            get
            {
                if(userRepository == null)
                {
                    userRepository = new UserRepository(db);
                }
                return userRepository;
            }
        }

        public IRepository<Medal> Medals
        {
            get
            {
                if(medalRepository == null)
                {
                    medalRepository = new MedalRepository(db);
                }
                return medalRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}