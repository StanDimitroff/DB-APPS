namespace ExtractArtistsAndAlbums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;

    class TestProgram
    {
        // Write a program that extracts all different artists, which are found in the catalog.xml.
        // For each artist print the number of albums in the catalogue. Use the DOM parser and a Dictionary<string, int>
        //  (use the artist name as key and the number of albums as value in the dictionary).
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalog.xml");
            XmlNode rootNode = doc.DocumentElement;
            Dictionary<string, int> artistAlbums = new Dictionary<string, int>();

            foreach (XmlNode node in rootNode)
            {
                var artist = node["artist"].InnerText;
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