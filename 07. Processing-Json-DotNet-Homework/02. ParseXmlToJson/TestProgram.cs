namespace ParseXmlToJson
{
    using System;
    using Newtonsoft.Json;
    using System.Xml.Linq;
    using System.IO;

    class TestProgram
    {
        static void Main()
        {
            // Parse the XML from the feed to JSON

            var doc = XDocument.Load("../../../softuni-rss.xml");
            // write document to new .json file
            using (FileStream stream = File.Open("../../../softuni-rss.json", FileMode.CreateNew))
            using (StreamWriter writer = new StreamWriter(stream))
            using (JsonWriter jw = new JsonTextWriter(writer))
            {
                jw.Formatting = Formatting.Indented;
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(jw, doc);
            }

            string json = JsonConvert.SerializeXNode(doc, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}