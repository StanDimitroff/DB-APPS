namespace JsonToPoco
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    class Channel
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("lastBuildDate")]
        public string LastDate { get; set; }

        [JsonProperty("item")]
        public List<Item> Items { get; set; }
    }
}