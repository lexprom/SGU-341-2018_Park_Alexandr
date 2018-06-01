﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLayerApp.DAL.Entities;

namespace TLayerApp.BLL.DTO
{
    //Data Transfer Object
    public class MedalDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Material { get; set; }
        public int UserID { get; set; }
        public ICollection<User> Users { get; set; }
    }
}