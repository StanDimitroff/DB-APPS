namespace _04.NativeSqlQuery
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
            }
        }

        private static List<Employee> GetEmployees()
        {
            var db = new SoftUniEntities();
            var query = @"SELECT DISTINCT e.[EmployeeID]
      ,[FirstName]
      ,[LastName]
      ,[MiddleName]
      ,[JobTitle]
      ,[DepartmentID]
      ,[ManagerID]
      ,[HireDate]
      ,[Salary]
      ,[AddressID]
  FROM [SoftUni].[dbo].[Employees] e
  JOIN EmployeesProjects ep ON ep.EmployeeID = e.EmployeeID
  JOIN Projects p ON p.ProjectID = ep.ProjectID
  WHERE DATEPART(YEAR, p.StartDate) = '2002'";

            return db.Database.SqlQuery<Employee>(query).ToList();
        }
    }
}
