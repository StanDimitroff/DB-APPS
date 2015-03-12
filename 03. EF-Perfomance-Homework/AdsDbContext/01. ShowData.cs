namespace AdsDbContext
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShowData
    {
        static void Main()
        {
            var adsWithoutUnclude = GetAdsWithoutInclude();
            foreach (var ad in adsWithoutUnclude)
            {
                Console.WriteLine(ad.Title + " " + ad.AdStatus + " " + "  " + ad.Category + " " + ad.Town + " " + ad.AspNetUser);
                Console.WriteLine();
            }
        }

        private static List<Ad> GetAdsWithoutInclude()
        {
            var db = new AdsEntities();
            return db.Ads.ToList();
            
        }
    }
}
