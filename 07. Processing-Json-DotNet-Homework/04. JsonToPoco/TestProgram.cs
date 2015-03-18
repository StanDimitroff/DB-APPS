namespace JsonToPoco
{
    using System;
    using System.IO;
    using Newtonsoft.Json;

    class TestProgram
    {
        // Parse the JSON string to POCO
        static void Main()
        {
            var json = File.ReadAllText("../../../softuni-rss.json");
            
            //var template = new
            //{
            //    rss = string.Empty,
            //    Link = string.Empty,
            //    Description = string.Empty
            //};

            var channel = JsonConvert.DeserializeObject<Channel>(json);

            Console.WriteLine(channel.Title);
        }
    }
}
