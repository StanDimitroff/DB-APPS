namespace Export_Monasteries_as_XML
{
    using System.Linq;
    using System.Xml.Linq;
    using EF_Mappings;

    class ExportMonasteriesAsXml
    {
        static void Main()
        {
            var db = new GeographyEntities();
            var countries = db.Countries.Where(c => c.Monasteries.Count != 0).OrderBy(c => c.CountryName).Select(c => new
                {
                    Name = c.CountryName,
                    Monasteries = c.Monasteries.OrderBy(m => m.Name).Select(m => m.Name)
                });

            var root = new XElement("monasteries");
            foreach (var country in countries)
            {
                var childCountry = new XElement("country");
                childCountry.Add(new XAttribute("name", country.Name));
                foreach (var monastery in country.Monasteries)
                {
                    var childMonastery = new XElement("monastery", monastery);
                    childCountry.Add(childMonastery);
                }

                root.Add(childCountry);
            }

            var xml = new XDocument(root);
            xml.Save("../../monasteries.xml");
        }
    }
}