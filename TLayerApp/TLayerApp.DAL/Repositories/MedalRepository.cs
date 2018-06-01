using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLayerApp.DAL.EF;
using TLayerApp.DAL.Entities;
using TLayerApp.DAL.Interfaces;

namespace TLayerApp.DAL.Repositories
{
    public class MedalRepository : IRepository<Medal>
    {
        private UserContext db;

        public MedalRepository(UserContext context)
        {
            db = context;
        }

        public void Create(Medal item)
        {
            db.Medal.Add(item);
        }

        public void Delete(int id)
        {
            Medal medal = db.Medal.Find(id);
            if(medal != null)
            {
                db.Medal.Remove(medal);
            }
        }

        public IEnumerable<Medal> Find(Func<Medal, bool> predicate)
        {
            return db.Medal.Include(o => o.Users).Where(predicate).ToList();
        }

        public Medal Get(int id)
        {
            return db.Medal.Find(id);
        }

        public IEnumerable<Medal> GetAll()
        {
            return db.Medal.Include(o => o.Users);
        }

        public void Update(Medal item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
