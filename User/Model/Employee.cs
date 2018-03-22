using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    class Employee : User
    {
        private string position;

        public uint Work_Hours { get; set; }
        public string Position {get { return position ?? throw new ArgumentNullException(); } set { position = value ?? throw new ArgumentNullException(); }}

        public Employee(string name, string sec_name, string mid_name,string bh, uint age,string pos,uint wh) : base(name, sec_name, mid_name,bh, age)
        {
            Position = pos;
            Work_Hours = wh;
        }
    }
}
