namespace Import_Rivers_from_XML
{
    using System.Linq;
    using System.Xml.Linq;
    using System.Xml.XPath;
    using EF_Mappings;

    public class RiversFromXml
    {
        static void Main()
        {
            var doc = XDocument.Load("../../rivers.xml");
            var riverNodes = doc.XPathSelectElements("/rivers/river");
            foreach (var riverNode in riverNodes)
            {
                string riverName = riverNode.Element("name").Value;
                int riverLength = int.Parse(riverNode.Element("length").Value);
                string riverOutflow = riverNode.Element("outflow").Value;
                int? drainageArea = null;
                if (riverNode.Element("drainage-area") != null)
                {
                    drainageArea = int.Parse(riverNode.Element("drainage-area").Value);
                }

                int? avgDischarge = null;
                if (riverNode.Element("average-discharge") != null)
                {
                    avgDischarge = int.Parse(riverNode.Element("average-discharge").Value);
                }

                var river = new River()
                {
                    RiverName = riverName,
                    Length = riverLength,
                    DrainageArea = drainageArea,
                    Outflow = riverOutflow,
                    AverageDischarge = avgDischarge
                };

                var db = new GeographyEntities();
                db.Rivers.Add(river);
                db.SaveChanges();

                var countryNodes = riverNode.XPathSelectElements("countries/country");
                var countryNames = countryNodes.Select(c => c.Value);
                foreach (var countryName in countryNames)
                {
                    var country = db.Countries.FirstOrDefault(c => c.CountryName == countryName);
                    river.Countries.Add(country);
                    db.SaveChanges();
                }
            }
        }
    }
}