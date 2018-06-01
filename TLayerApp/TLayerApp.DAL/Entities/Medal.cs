using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLayerApp.DAL.Entities
{
    public class Medal
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Material { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
