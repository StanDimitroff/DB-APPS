using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SoftUniDbContext
{
    class Program
    {
        static void Main(string[] args)
        {
            SoftUniEntities s = new SoftUniEntities();
            foreach (var item in s.Employees)
            {
                Console.WriteLine(item.FirstName);
            }
        }
    }
}
