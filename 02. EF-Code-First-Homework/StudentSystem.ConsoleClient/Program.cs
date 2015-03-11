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
            var homework1 = new Homework
            {
                Content = "JS Advanced First Homework",
                Type = HomeworkType.ApplicationZip,
                DateSubmitted = DateTime.Parse("2015-03-09")
            };

            var homework2 = new Homework
            {
                Content = "JS Advanced Second Homework",
                Type = HomeworkType.ApplicationZip,
                DateSubmitted = DateTime.Parse("2015-03-11")
            };

            var student = new Student
            {
                FullName = "Stan Roberts",
                PhoneNumber = "09909877",
                RegisterDate = DateTime.Parse("2015-02-21"),
                Birthday = DateTime.Parse("1974-09-25"),
                Homeworks = new List<Homework>
                {
                    homework1,
                    homework2
                }
            };

            var resource1 = new Resource
            {
                Name = "Video for JS Advanced Course",
                Type = ResourceType.Video,
                Link = "JSAdvanced/Resources"
            };

            var resource2 = new Resource
            {
                Name = "Presentation for JS Advanced Course",
                Type = ResourceType.Presentation,
                Link = "JSAdvanced/Resources"
            };

            var course = new Course
            {
                Name = "JS Advanced",
                Description = "JS for advanced programmers",
                StartDate = DateTime.Parse("2015-04-12"),
                EndDate = DateTime.Parse("2015-05-12"),
                Price = 130,
                Resources = new List<Resource>
                {
                    resource1,
                    resource2
                }
            };

            db.Students.Add(student);
            db.Courses.Add(course);
            db.SaveChanges();

            var students = db.Students.Include(s => s.Homeworks).Select(s => new
                  {
                      s.FullName,
                      s.Homeworks
                  });

            foreach (var item in students)
            {
                Console.WriteLine(item.FullName);
                foreach (var homework in student.Homeworks)
                {
                    Console.WriteLine(homework.DateSubmitted);
                }

                Console.WriteLine();
            }
            Console.WriteLine();
            var courses = db.Courses.Include(c => c.Resources).Select(c => new
                {
                    c.Name,
                    c.Resources
                });
                

            foreach (var item in courses)
            {
                Console.WriteLine(item.Name);
                foreach (var resource in item.Resources)
                {
                    Console.WriteLine(resource.Name);
                }

                Console.WriteLine();
            }
        }
    }
}