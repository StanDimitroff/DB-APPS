namespace ExtractAlbumNames
{
    using System;
    using System.Xml;

    class TestProgram
    {
        // Write a program that extracts all album names from catalog.xml. Use the DOM parser.
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalog.xml");
            XmlNode rootNode = doc.DocumentElement;

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                Console.WriteLine("Album name = {0}", node["name"].InnerText);
                
                Console.WriteLine();
            }
        }
    }
}