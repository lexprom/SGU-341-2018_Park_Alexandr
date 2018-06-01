using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TLayerApp.BLL.DTO;

namespace TLayerApp.WEB.Models
{
    public class MedalViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Material { get; set; }
        public int UserID { get; set; }
        public ICollection<UserDTO> Users { get; set; }
    }
}