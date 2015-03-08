namespace _03.EmployessProjects
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
            var employees = GetEmployees();
           
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
                foreach (var project in employee.Projects)
                {
                    Console.WriteLine(project.StartDate.Year);
                }

                Console.WriteLine();
            }
        }

        private static List<Employee> GetEmployees()
        {
            var db = new SoftUniEntities();
            return db.Employees.Where(e => e.Projects.Any(p => p.StartDate.Year == 2002)).ToList();
        }
    }
}