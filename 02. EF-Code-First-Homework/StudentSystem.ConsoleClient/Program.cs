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
        static StudentSystemDbContext db = new StudentSystemDbContext();
        static void Main()
        {
           
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemDbContext, Configuration>());
            //var db = new StudentSystemDbContext();
            var students = ListStudentsWithHomeworks();
            foreach (var student in students)
            {
                Console.WriteLine(student.FullName + " ");
                foreach (var homework in student.Homeworks)
                {
                    Console.WriteLine(homework.DateSubmitted);
                }
            }


            //var student = new Student()
            //{
            //    FullName = "Steve Jobs",
            //    PhoneNumber = "0986656465",
            //    RegisterDate = DateTime.Parse("2012-11-25"),
            //    Birthday = DateTime.Parse("1986-07-17"),
            //};

            //db.Students.Add(student);
            //db.SaveChanges();
        }

        private static List<Student> ListStudentsWithHomeworks()
        {
            return db.Students.Include(s => s.Homeworks).ToList();
        }
    }
}
