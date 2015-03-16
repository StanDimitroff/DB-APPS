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
            Dictionary<string, int> artistsAlbums = new Dictionary<string, int>();
            foreach (XmlNode node in rootNode.ChildNodes)
            {
                //artists.Add(node["artist"].InnerText);
            }
        }
    }
}
