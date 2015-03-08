namespace _06.ConcurencyDbChanges
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using _01.SoftUniDbContext;

    class Program
    {
        static void Main()
        {
            var db = new SoftUniEntities();
            var dbCon = new SoftUniEntities();

            db.Towns.FirstOrDefault(t => t.Name == "Detroit").Name = "Tokio";
            dbCon.Towns.FirstOrDefault(t => t.Name == "Detroit").Name = "Sofia";

            db.SaveChanges();
            dbCon.SaveChanges();
        }
    }
}