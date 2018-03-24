using System;
using System.Linq;

namespace User
{
    public class Employee : User
    {
        private string position;

        public Employee(string name, string sec_name, string mid_name, string bh, uint age, string pos, uint wh) : base(name, sec_name, mid_name, bh, age)
        {
            Position = pos;
            Work_Hours = wh;
        }

        public uint Work_Hours { get; set; }
        public string Position {
            get
            {
                return position ?? throw new ArgumentNullException();
            }

            set
            {
                if (value != null && !value.Any(char.IsDigit))
                {
                    position = value;
                }
                else throw new Exception("Inccorect position");
            }
        }


        public override string ToString()
        {
            string user = base.ToString();
            return  $"{user}Work Hours = {Work_Hours}{Environment.NewLine}Position = {Position}{Environment.NewLine}";

        }
    }
}
