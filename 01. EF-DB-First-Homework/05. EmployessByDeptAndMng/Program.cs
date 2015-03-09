namespace _05.EmployessByDeptAndMng
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
            var employees = GetEmployees("Engineering", "Roberto", "Tamburello");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }
        }

        private static List<Employee> GetEmployees(string departmentName, string managerFName, string managerLName)
        {
            var db = new SoftUniEntities();
            return db.Employees.Where(e => e.Department.Name == departmentName && e.Employee1.FirstName == managerFName && e.Employee1.LastName == managerLName).ToList();
        }
    }
}
