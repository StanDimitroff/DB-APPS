namespace Export_Rivers_as_JSON
{
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using System.Web.Script.Serialization;
    using EF_Mappings;

    class ExportRiversAsJson
    {
        static void Main()
        {
            var db = new GeographyEntities();
            var rivers = db.Rivers.OrderByDescending(r => r.Length).Select(r => new
                {
                    Name = r.RiverName,
                    Length = r.Length,
                    Countries = r.Countries.OrderBy(c => c.CountryName).Select(c => c.CountryName)
                }).ToList();

            var serializer = new JavaScriptSerializer();
            var json = serializer.Serialize(rivers);

            File.WriteAllText("../../rivers.json", json);
        }
    }
}