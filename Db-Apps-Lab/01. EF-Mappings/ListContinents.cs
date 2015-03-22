namespace EF_Mappings
{
    using System;

    class ListContinents
    {
        static void Main()
        {
            var db = new GeographyEntities();
            var continents = db.Continents;
            foreach (var continent in continents)
            {
                Console.WriteLine(continent.ContinentName);
            }
        }
    }
}