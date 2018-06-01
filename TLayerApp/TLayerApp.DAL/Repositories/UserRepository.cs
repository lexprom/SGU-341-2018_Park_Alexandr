using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using TLayerApp.DAL.EF;
using TLayerApp.DAL.Entities;
using TLayerApp.DAL.Interfaces;

namespace TLayerApp.DAL.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private UserContext db;

        public UserRepository(UserContext context)
        {
            db = context;
        }

        public IEnumerable<User> GetAll()
        {
            return db.User;
        }

        public User Get(int id)
        {
            return db.User.Find(id);
        }

        public IEnumerable<User> Find(Func<User, bool> predicate)
        {
            return db.User.Where(predicate).ToList();
        }

        public void Create(User item)
        {
            db.User.Add(item);
        }

        public void Update(User item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            User user = db.User.Find(id);
            if(user != null)
            {
                db.User.Remove(user);
            }
        }
    }
}
