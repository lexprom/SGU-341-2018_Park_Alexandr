using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace User
{
    public class User
    {
        const string pattern = @"^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](1[0-9]|0[0-9])\d\d$";
        private string name;
        private string sec_name;
        private string mid_name;
        private string birth_day;

        public User(string name, string secName, string midName, string birthDay, uint age)
        {
            Name = name;
            Sec_Name = secName;
            Mid_Name = midName;
            Birth_Day = birthDay;
            Age = age;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value != null && !value.Any(char.IsDigit))
                {
                    name = value;
                }
                else throw new Exception("Inccorect name");
            }
        }

        public string Sec_Name
        {
            get { return sec_name; }
            set
            {
                if (value != null && !value.Any(char.IsDigit))
                {
                    sec_name = value;
                }
                else throw new Exception("Inccorect sec name");
            }
        }

        public string Mid_Name
        {
            get { return mid_name; }
            set
            {
                if (value != null && !value.Any(char.IsDigit))
                {
                    mid_name = value;
                }
                else throw new Exception("Inccorect mid name");
            }
        }

        public string Birth_Day
        {
            get { return birth_day; }
            set
            {
                Match m = Regex.Match(value, pattern);
                birth_day = m.Success 
                    ? value 
                    : throw new Exception("Inccorect date");
            }
        }

        public uint Age{ get;set; }

        public override string ToString()
        {
            return string.Format($"Name = {Name} {Environment.NewLine}Second Name = {Sec_Name} {Environment.NewLine}Mid Name = {Mid_Name}{Environment.NewLine}Birthday = {Birth_Day}{Environment.NewLine}Age = {Age}{Environment.NewLine}");
        }
    }
}
