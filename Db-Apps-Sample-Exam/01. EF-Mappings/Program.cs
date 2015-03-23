using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Mappings
{
    class Program
    {
        static void Main()
        {
            var db = new GeographyEntities();
            Console.WriteLine(db.Continents.Count());
        }
    }
}
