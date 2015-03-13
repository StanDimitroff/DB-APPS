namespace AdsDbContext
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Data.Entity;

    public class PlayWithToList
    {
        static void Main()
        {
            UnoptimizedVersion();

            Optimized();
        }
       
        private static void UnoptimizedVersion()
        {
            var db = new AdsEntities();
            DateTime starTime = DateTime.Now;

            var ads = db.Ads.ToList().Where(a => a.AdStatus.Status == "Published").Select(a => new
            {
                a.Title,
                a.Category,
                a.Town,
                a.Date
            }).ToList().OrderBy(a => a.Date);
            Console.WriteLine(DateTime.Now - starTime);
        }

        private static void Optimized()
        {
            var db = new AdsEntities();
            DateTime starTime = DateTime.Now;

            var ads = db.Ads.Where(a => a.AdStatus.Status == "Published").OrderBy(a => a.Date).Select(a => new
            {
                a.Title,
                a.Category,
                a.Town,
            }).ToList();
            Console.WriteLine(DateTime.Now - starTime);
        }
    }
}