namespace JsonToPoco
{
    using Newtonsoft.Json;

    class Item
    {
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}