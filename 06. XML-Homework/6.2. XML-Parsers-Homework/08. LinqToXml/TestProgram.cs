namespace LinqToXml
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    class TestProgram
    {
        // Write a program, which extract from the file catalog.xml the titles and prices for all albums, published 5 years ago or earlier.
        // Use XDocument and LINQ to XML query.
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
                Console.WriteLine("Title = {0}, Price = {1}", album.Title, album.Price);
            }
        }
    }
}