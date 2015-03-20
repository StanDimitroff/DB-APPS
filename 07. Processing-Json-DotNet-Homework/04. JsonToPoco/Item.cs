namespace JsonToPoco
{
    using Newtonsoft.Json;
    using System;

    public class Item
    {
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("a10:updated")]
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return string.Format("<div><a href = {0}>Link</a><h3>{1}</h3><p>{2}</p><date>{3}</date</div>",
                this.Link,
                this.Title,
                this.Description,
                this.Date);
        }
    }
}