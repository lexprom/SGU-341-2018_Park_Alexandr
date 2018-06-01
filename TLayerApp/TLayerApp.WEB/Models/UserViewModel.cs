using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TLayerApp.BLL.DTO;

namespace TLayerApp.WEB.Models
{
    public class UserViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Date { get; set; }
        public string Town { get; set; }
        public string Street { get; set; }
        public int HomeNumber { get; set; }
        public ICollection<MedalDTO> Medals { get; set; }
        public int MedalID { get; set; }
    }
}