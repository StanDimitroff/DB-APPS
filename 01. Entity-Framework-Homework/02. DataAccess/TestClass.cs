namespace _02.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using _01.SoftUniDbContext;

    class TestClass
    {
        public static void Main()
        {
            var employee = new Employee
            {
                FirstName = "Steve",
                MiddleName = "Ivan",
                LastName = "Dimitrov",
                JobTitle = "Front-End Developer",
                DepartmentID = 7,
                ManagerID = 16,
                HireDate = DateTime.Parse("2015-02-21"),
                Salary = 1280,
                AddressID = 102
            };

            DataAccessMethods.InsertEmployee(employee);
            DataAccessMethods.DeleteEmployee(23);
            DataAccessMethods.UpdateEmployee(44, "FirstName", "Ceco");
        }
    }
}