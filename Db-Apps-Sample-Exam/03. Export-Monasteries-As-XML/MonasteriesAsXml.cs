namespace Export_Monasteries_As_XML
{
    using System.Linq;
    using System.Xml.Linq;
    using EF_Mappings;

    public class MonasteriesAsXml
    {
        static void Main()
        {
            var db =  new GeographyEntities();
            var countries = db.Countries.Where(c => c.Monasteries.Count() != 0).OrderBy(c => c.CountryName).Select(c => new
                {
                    c.CountryName,
                    Monasteries = c.Monasteries.OrderBy(m => m.Name).Select(m => m.Name)
                });

            var rootElement = new XElement("monasteries");
            foreach (var country in countries)
            {
                var countryChild = new XElement("country");
                countryChild.Add(new XAttribute("name", country.CountryName));
                foreach (var monastery in country.Monasteries)
                {
                    var monasteryChild = new XElement("monastery", monastery);
                    countryChild.Add(monasteryChild);
                }

                rootElement.Add(countryChild);
            }

            var xml = new XDocument(rootElement);
            xml.Save("../../monasteries.xml");
        }
    }
}