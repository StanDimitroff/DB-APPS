namespace Mountains_Code_First
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Mountains_Code_First.Migrations;

    class MountainsCodeFirst
    {
        static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MountainsContext, Configuration>());
            var db = new MountainsContext();
            
            var test  = new Country()
            {
                Code = "TT",
                Name = "Test"
            };

            db.Countries.Add(test);
            db.SaveChanges();
        }
    }
}