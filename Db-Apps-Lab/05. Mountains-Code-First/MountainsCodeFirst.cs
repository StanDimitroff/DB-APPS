namespace Mountains_Code_First
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MountainsCodeFirst
    {
        static void Main()
        {
            Database.SetInitializer(new MountainsMigrationStrategy());
            var db = new MountainsContext();

            var country = new Country
            {
                Code = "AB",
                Name = "Absurdistan",
            };

            var mountain = new Mountain
            {
                Name = "Absurdistan Hills",
            };

            mountain.Peaks.Add(new Peak
                {
                    Name = "Great Peak",
                    Mountain = mountain
                });
            mountain.Peaks.Add(new Peak
                {
                    Name = "Small Peak",
                    Mountain = mountain
                });

            country.Mountains.Add(mountain);
            db.Countries.Add(country);
            db.SaveChanges();

            var countries = db.Countries.Select(c => new
                {
                    CountryName = c.Name,
                    Mountains = c.Mountains.Select(m => new
                    {
                        MountainName = m.Name,
                        Peaks = m.Peaks
                    })
                });

            foreach (var con in countries)
            {
                Console.WriteLine("Country: " + con.CountryName);
                foreach (var moun in con.Mountains)
                {
                    Console.WriteLine(" Moutain: " + moun.MountainName);
                    foreach (var p in moun.Peaks)
                    {
                        Console.WriteLine("\t{0} ({1})", p.Name, p.Elevation);
                    }
                }
            }
        }
    }
}