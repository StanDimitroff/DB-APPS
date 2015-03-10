namespace StudentSystem.ConsoleClient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using StudentSystem.Data;
    using StudentSystem.Data.Migrations;
    using StudentSystem.Models;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;



    class Program
    {
        static void Main()
        {
           
           Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemDbContext, Configuration>());
            

             StudentSystemDbContext db = new StudentSystemDbContext();

                var student = new Student()
                {
                    FullName = "Steve Jobs",
                    PhoneNumber = "0986656465",
                    RegisterDate = DateTime.Parse("2012-11-25"),
                    Birthday = DateTime.Parse("1986-07-17"),
                };

                db.Students.Add(student);
                db.SaveChanges();
        }
    }
}
