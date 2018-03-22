using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Steve", "Jobs", "Stivenson","12.01.1203", 13, "iOS Developer", 0);
            Console.WriteLine(emp);
        }
    }
}
