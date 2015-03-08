namespace _08.InsertProject
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
            var employees = new List<Employee>
            {
                new Employee
                {
                    FirstName = "Mark", 
                    MiddleName = "Clarkson",
                    LastName = "Keller",
                    JobTitle = "Marketing Assistant",
                    DepartmentID = 4,
                    ManagerID = 6,
                    HireDate = DateTime.Parse("2010-05-09"),
                    Salary = 2030,
                    AddressID = 199
                },
                new Employee
                {
                    FirstName = "Ken", 
                    MiddleName = "Harison",
                    LastName = "Smith",
                    JobTitle = "Tool Designer",
                    DepartmentID = 5,
                    ManagerID = 9,
                    HireDate = DateTime.Parse("2011-11-29"),
                    Salary = 1343,
                    AddressID = 21
                },
                 new Employee
                {
                    FirstName = "Jill", 
                    LastName = "Ford",
                    JobTitle = "Design Engineer",
                    DepartmentID = 1,
                    ManagerID = 3,
                    HireDate = DateTime.Parse("2014-09-03"),
                    Salary = 1120,
                    AddressID = 22
                },
                
            };

            var project = new Project()
            {
                Name = "Google Glass",
                Description = "New interactive glasses",
                StartDate = DateTime.Parse("2012-01-03"),
                Employees = employees
            };

            InstertProject(project);
        }

        private static void InstertProject(Project project)
        {
            var db = new SoftUniEntities();
            db.Projects.Add(project);
            db.SaveChanges();
        }
    }
}