using Newtonsoft.Json;
using System;
namespace Canducci.ShortUrl
{
    [JsonObject()]    
    [Serializable()]
    public class ShortUrlReceive: IJson
    {
        [JsonConstructor()]
        protected ShortUrlReceive() { }

        public ShortUrlReceive(string Content, string Url)
        {
            Validation.IsNullOrEmpty(Content, "Content invalid");
            Validation.IsJson(Content, "Format Json Invalid.");
            Validation.IsUrl(Url, "Url invalid");
            ShortUrlReceive rep = JsonData.ToObject<ShortUrlReceive>(Content);
            ShortUrl = rep.ShortUrl;
            Keyword = rep.Keyword;
            this.Url = new Uri(Url);
        }
                
        [JsonProperty("url")]
        [JsonRequired()]               
        public Uri ShortUrl { get; private set; }
                
        [JsonProperty("keyword")]
        [JsonRequired()]
        public string Keyword { get; private set; }

        [JsonProperty("urlfull")]
        public Uri Url { get; private set; }
        public string ToJson()
        {            
            return JsonData.ToJson(this);
        }
    }
}