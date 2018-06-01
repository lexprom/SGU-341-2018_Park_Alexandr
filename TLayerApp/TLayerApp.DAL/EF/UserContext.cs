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
        public DbSet<User> User { get; set; }
        public DbSet<Medal> Medal { get; set; }

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
                db.Medal.Add(new Medal { ID = 1, Material = "Gold", Name = "FP" });
                db.Medal.Add(new Medal { ID = 2, Material = "Silver", Name = "SP" });
                db.Medal.Add(new Medal { ID = 3, Material = "Bronze", Name = "TP" });
                db.User.Add(new User { ID=1, Name = "John", LastName = "Wick", Date = new DateTime(1972, 12, 1), Town = "Chicago", Street = "American st.", HomeNumber = 12 });
                db.User.Add(new User { ID=2, Name = "Jackie", LastName = "Chan", Date = new DateTime(1969, 6, 12), Town = "Hong-Kong", Street = "Chinese st.", HomeNumber = 1 });
                db.User.Add(new User { ID=3, Name = "Conor", LastName = "McGregor", Date = new DateTime(1980, 1, 24), Town = "Dublin", Street = "Irish st.", HomeNumber = 25 });
                db.SaveChanges();
            }
        }
    }
}
