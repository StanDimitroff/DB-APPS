namespace OldAlbums
{
    using System;
    using System.Xml;
    class TestProgram
    {
        // Write a program, which extract from the file catalog.xml the titles and prices for all albums, published 5 years ago or earlier.
        // Use XPath query.
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalog.xml");

            string xPathQuery = "/albums/album";

            XmlNodeList albums = doc.SelectNodes(xPathQuery);
            foreach (XmlNode album in albums)
            {
                if (int.Parse(album["year"].InnerText) < DateTime.Now.Year - 5)
                {
                    Console.WriteLine("Title = {0}, Price = {1}", album.SelectSingleNode("name").InnerText, album.SelectSingleNode("price").InnerText);
                }
                
            }
        }
    }
}