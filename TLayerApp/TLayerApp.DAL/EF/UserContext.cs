using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLayerApp.DAL.Entities;

namespace TLayerApp.DAL.EF
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Medal> Medals { get; set; }

        static UserContext()
        {
            Database.SetInitializer<UserContext>(new StoreDbInitializer());
        }

        public UserContext(string connectionString) : base(connectionString)
        {
        }

        public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<UserContext>
        {
            protected override void Seed(UserContext db)
            {
                db.Users.Add(new User { Name = "John", LastName = "Wick", Date = new DateTime(1972, 12, 1), Town = "Chicago", Street = "American st.", HomeNumber = 12 });
                db.Users.Add(new User { Name = "Jackie", LastName = "Chan", Date = new DateTime(1969, 6, 12), Town = "Hong-Kong", Street = "Chinese st.", HomeNumber = 1 });
                db.Users.Add(new User { Name = "Conor", LastName = "McGregor", Date = new DateTime(1980, 1, 24), Town = "Dublin", Street = "Irish st.", HomeNumber = 25 });
                db.SaveChanges();
            }
        }

    }
}
