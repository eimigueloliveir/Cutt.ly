using Newtonsoft.Json;
using System;

namespace Cutt_ly
{
    public class Deserializer
    {
        public Deserializer()
        {
            this.url = new url();
        }
        [JsonProperty(PropertyName = "url")]
        public url url { get; set; }
    }
    public class url
    {
        [JsonProperty(PropertyName = "shortLink")]
        public string shortLink { get; set; }
        [JsonProperty(PropertyName = "status")]
        public string status { get; set; }
        [JsonProperty(PropertyName = "fullLink")]
        public string fullLink { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string title { get; set; }
    }
}
