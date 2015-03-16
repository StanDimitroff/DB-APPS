namespace DeleteAlbums
{
    using System;
    using System.Xml;
    class TestProgram
    {
        // Using the DOM parser write a program to delete from catalog.xml all albums having price > 20.
        // Save the result in a new file cheap-albums-catalog.xml.
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalog.xml");
            XmlNode rootNode = doc.DocumentElement;
            XmlNodeList albums = rootNode.SelectNodes("album");
            foreach (XmlNode node in albums)
            {
                if (decimal.Parse(node["price"].InnerText) > 20m)
                {
                    rootNode.RemoveChild(node);
                }
            }

            doc.Save("../../../cheap-albums-catalog.xml");
        }
    }
}