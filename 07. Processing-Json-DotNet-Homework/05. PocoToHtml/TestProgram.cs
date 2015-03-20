namespace PocoToHtml
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using JsonToPoco;
    using System.IO;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    class TestProgram
    {
        static void Main()
        {
            var json = File.ReadAllText("../../../softuni-rss.json");
            JObject jsonObject = JObject.Parse(json);

            var news = jsonObject["rss"]["channel"]["item"].ToList();
            var items = news.Select(item => JsonConvert.DeserializeObject<Item>(item.ToString())).ToList();
          
            var result = new StringBuilder();
            result.Append("<!DOCTYPE html ><html><head><meta charset=\"utf-8\"></head><body>");
            foreach (var question in items)
            {
                result.Append(question.ToString());
            }

            result.Append("</body></html>");
            File.WriteAllText("../../questions.html", result.ToString());
        }
    }
}