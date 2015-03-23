namespace Export_Rivers_As_JSON
{
    using System.Linq;
    using System.IO;
    using Newtonsoft.Json;
    using EF_Mappings;

    public class RiversAsJson
    {
        static void Main()
        {
            var db = new GeographyEntities();
            var rivers = db.Rivers.OrderByDescending(r => r.Length).Select(r => new
                {
                    r.RiverName,
                    r.Length,
                    Countries = r.Countries.OrderBy(c => c.CountryName).Select(c => c.CountryName)
                });

            var serializedRivers = JsonConvert.SerializeObject(rivers);
            File.WriteAllText("../../rivers.json", serializedRivers);
        }
    }
}