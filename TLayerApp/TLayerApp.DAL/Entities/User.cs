﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLayerApp.DAL.Entities
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Date { get; set; }
        public string Town { get; set; }
        public string Street { get; set; }
        public int HomeNumber { get; set; }
        public ICollection<Medal> Medals { get; set; }
    }
}