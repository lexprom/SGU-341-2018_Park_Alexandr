using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User
{
    class User
    {
        private string name;
        private string sec_name;
        private string mid_name;
        private string birth_day;

        public string Name
        {
            get { return name ?? throw new ArgumentNullException(); }
            set { name = value ?? throw new ArgumentNullException(); }
        }

        public string Sec_Name
        {
            get { return sec_name ?? throw new ArgumentNullException(); }
            set { sec_name = value ?? throw new ArgumentNullException(); }
        }

        public string Mid_Name
        {
            get { return mid_name ?? throw new ArgumentNullException(); }
            set { mid_name = value ?? throw new ArgumentNullException(); }
        }

        public string Birth_Day
        {
            get { return birth_day ?? throw new ArgumentNullException(); }
            set
            {
                string pattern = @"(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](1[0-9]|0[0-9])\d\d";
                Match m = Regex.Match(value, pattern);
                birth_day = m.Success ? value : throw new Exception("Inccorect date");
            }
        }

        public uint Age{ get;set; }

        public User(string name, string sec_name, string mid_name,string bh, uint age)
        {
            Name = name;
            Sec_Name = sec_name;
            Mid_Name = mid_name;
            Birth_Day = bh;
            Age = age;
        }

        public override string ToString()
        {
            return Name + " " + Sec_Name + " " + Mid_Name + " " + Birth_Day + " " + Age; 
        }
    }
}
