namespace _09.CallStoreProcedure
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
            var projectsNames = GetEmployeeProjects("Gail", "Erickson");
            foreach (var name in projectsNames)
            {
                Console.WriteLine(name);
            }
        }

        private static List<string> GetEmployeeProjects(string firstName, string lastName)
        {
            var db = new SoftUniEntities();
            return db.usp_getProjectsByEmployee(firstName, lastName).ToList();
        }
    }
}