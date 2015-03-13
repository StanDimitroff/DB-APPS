namespace AdsDbContext
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Data.Entity;

    public class ShowData
    {
        static void Main()
        {
            GetAdsWithoutInclude();

            GetAdsWithInclude();
        }

        private static void GetAdsWithoutInclude()
        {
            var db = new AdsEntities();
            var ads = db.Ads.ToList();
            DateTime starTime = DateTime.Now;
            foreach (var ad in ads)
            {
                string adCategory = ad.Category != null ? ad.Category.Name : "no category";
                string adTown = ad.Town != null ? ad.Town.Name : "no town";
                Console.WriteLine(ad.Title + " " + ad.AdStatus.Status + " - " + adCategory + " - " + adTown + " - " + ad.AspNetUser.Name);
                Console.WriteLine();
            }

            Console.WriteLine(DateTime.Now - starTime);
        }

        private static void GetAdsWithInclude()
        {
            var db = new AdsEntities();
            DateTime starTime = DateTime.Now;
            var ads = db.Ads.Include(a => a.Category).Include(a => a.AdStatus).Include(a => a.Town).Include(a => a.AspNetUser).ToList();
            foreach (var ad in ads)
            {
                string adCategory = ad.Category != null ? ad.Category.Name : "no category";
                string adTown = ad.Town != null ? ad.Town.Name : "no town";
                Console.WriteLine(ad.Title + " " + ad.AdStatus.Status + " - " + adCategory + " - " + adTown + " - " + ad.AspNetUser.Name);
                Console.WriteLine();
            }

            Console.WriteLine(DateTime.Now - starTime);
        }
    }
}