using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace Cutt_ly
{
    public  class Cutt
    {
        public Value Value = new Value();
        public  string key = "";
        public  void ShortLinkGenerator(string URL)
        {
            if (key == "") 
            {
                throw new Exception("Key must be different from null");
            }
            else if (URL == "")
            {
                throw new Exception("Url must be different from null");
            }
            HttpClient client = new HttpClient();
            string API = $"https://cutt.ly/api/api.php?key={key}&short={URL}";
            try
            {
                var response = client.GetAsync(API).Result;
                var result = response.Content.ReadAsStringAsync().Result;
                Deserializer de = JsonConvert.DeserializeObject<Deserializer>(result);
                Value.ShortLink = de.url.shortLink;
                Value.Status = de.url.status;
                Value.FullLink = de.url.fullLink;
                Value.Title = de.url.title;
            }
            catch
            {
                Console.WriteLine("Could not find results for the requested URL");
            }
        }
    }
}
