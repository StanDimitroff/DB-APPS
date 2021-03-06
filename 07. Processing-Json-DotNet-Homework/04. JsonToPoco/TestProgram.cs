﻿namespace JsonToPoco
{
    using System;
    using System.IO;
    using Newtonsoft.Json;
    using System.Linq;
    using Newtonsoft.Json.Linq;

    class TestProgram
    {
        // Parse the JSON string to POCO
        static void Main()
        {
            var json = File.ReadAllText("../../../softuni-rss.json");
            JObject jsonObject = JObject.Parse(json);

            var news = jsonObject["rss"]["channel"]["item"].ToList();
            var items = news.Select(item => JsonConvert.DeserializeObject<Item>(item.ToString())).ToList();
            foreach (var item in items)
            {
                Console.WriteLine(item.Title);
            }
        }
    }
}