namespace PrintAllQuestionTitles
{
    using System;
    using System.IO;
    using System.Linq;
    using Newtonsoft.Json.Linq;

    class TestProgram
    {
        static void Main()
        {
            // Using LINQ-to-JSON select all the question titles and print them to the console.

            // read the previously saved file
            var json = File.ReadAllText("../../../softuni-rss.json");
            JObject jsonObject = JObject.Parse(json);

            var titles = jsonObject.Descendants()
                     .OfType<JProperty>()
                     .Where(p => p.Name == "item")
                        .Descendants().OfType<JProperty>()
                        .Where(p => p.Name == "title");

            foreach (var title in titles)
            {
                Console.WriteLine(title.Value);
            }
        }
    }
}