namespace _02.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using _01.SoftUniDbContext;
   static class DataAccessMethods
    {
       static SoftUniEntities db = new SoftUniEntities();
        public static void InsertEmployee(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
        }

        public static void UpdateEmployee(int ID, string property, object newValue)
        {
            var employee = db.Employees.FirstOrDefault(e => e.EmployeeID == ID);
            employee.GetType().GetProperty(property).SetValue(employee, newValue);
            db.SaveChanges();
        }

        public static void DeleteEmployee(int ID)
        {
            var employee = db.Employees.FirstOrDefault(e => e.EmployeeID == ID);
            if (employee != null)
            {
                db.Employees.Remove(employee);
                db.SaveChanges();
            }
        }
    }
}