namespace Xpath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;

    // Implement the previous using XPath.
    class TheProgram
    {
        static void Main()
        {
            var doc = new XmlDocument();
            doc.Load("../../../catalog.xml");
            string artistQuery = "/albums/album";
            XmlNodeList albums = doc.SelectNodes(artistQuery);
            var artistAlbums = new Dictionary<string, int>();
            foreach (XmlNode album in albums)
            {
                var artist = album["artist"].InnerText;
                if (artistAlbums.ContainsKey(artist))
                {
                    artistAlbums[artist] = artistAlbums[artist] + 1;
                }
                else
                {
                    artistAlbums[artist] = 1;
                }
            }

            foreach (var album in artistAlbums)
            {
                Console.WriteLine("{0} -> {1}", album.Key, album.Value);
            }
        }
    }
}