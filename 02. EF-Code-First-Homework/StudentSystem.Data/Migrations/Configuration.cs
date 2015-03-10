namespace StudentSystem.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using StudentSystem.Data;
    using StudentSystem.Models;

    public sealed class Configuration : DbMigrationsConfiguration<StudentSystem.Data.StudentSystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            this.ContextKey = "StudentSystem.Data.StudentSystemDbContext";
        }

        protected override void Seed(StudentSystemDbContext context)
        {
            context.Students.AddOrUpdate(new Student
            {
                FullName = "Dan Nickalls",
                PhoneNumber = "555589899",
                RegisterDate = DateTime.Parse("2013-09-23"),
                Birthday = DateTime.Parse("1988-09-12")
            });

            context.Students.AddOrUpdate(new Student
            {
                FullName = "Pam Clears",
                PhoneNumber = "89879987",
                RegisterDate = DateTime.Parse("2011-01-13"),
                Birthday = DateTime.Parse("1982-02-22")
            });

            context.Students.AddOrUpdate(new Student
            {
                FullName = "Ben Sturn",
                PhoneNumber = "6552815511",
                RegisterDate = DateTime.Parse("2010-11-09"),
                Birthday = DateTime.Parse("1981-10-16")
            });

            context.Courses.AddOrUpdate(new Course
            {
                Name = "C# Basics",
                Description = "Begginers programming course",
                StartDate = DateTime.Parse("2015-03-25"),
                EndDate = DateTime.Parse("2015-04-25"),
                Price = 150
            });

            context.Courses.AddOrUpdate(new Course
            {
                Name = "Advanced JavaScript",
                Description = "JS for advanced students",
                StartDate = DateTime.Parse("2015-04-01"),
                Price = 120
            });

            context.Courses.AddOrUpdate(new Course
            {
                Name = "LESS CSS",
                Description = "Learn to write LESS",
                StartDate = DateTime.Parse("2015-05-01"),
                Price = 130,
            });











            //context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
