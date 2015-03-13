namespace AdsDbContext
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Data.Entity;

   public class Selections
    {
        static void Main()
        {
            SelectEverything();
            SelectCertainColumn();
        }
        private static void SelectEverything()
        {
            var db = new AdsEntities();
            DateTime starTime = DateTime.Now;
            var ad = db.Ads.ToList().FirstOrDefault().Title;
            Console.WriteLine(DateTime.Now - starTime);
        }

        private static void SelectCertainColumn()
        {
            var db = new AdsEntities();
            DateTime starTime = DateTime.Now;
            var ads = db.Ads.Select(a => a.Title).FirstOrDefault();
            Console.WriteLine(DateTime.Now - starTime);
        }
    }
}