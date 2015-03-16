namespace LinqToXml
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    class TestProgram
    {
        static void Main()
        {
            XDocument doc = XDocument.Load("../../../catalog.xml");
            var albums =
    from album in doc.Descendants("album")
    where int.Parse(album.Element("year").Value) < DateTime.Now.Year - 5
    select new
    {
        Title = album.Element("name").Value,
        Price = album.Element("price").Value
    };
            foreach (var album in albums)
            {
                Console.WriteLine(album);
            }
        }
    }
}