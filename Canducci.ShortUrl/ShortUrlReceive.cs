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

        public ShortUrlReceive(string content, string url, Provider provider)
        {
            Validation.IsNullOrEmpty(content, Message.MessageIsNummOrEmpty);
            Validation.IsJson(content, Message.MessageJsonIsInvalid);
            Validation.IsUrl(url, Message.MessageUrlIsInvalid);
            ShortUrlReceive rep = JsonData.ToObject<ShortUrlReceive>(content);
            ShortUrl = rep.ShortUrl;
            Keyword = rep.Keyword;
            LongUrl = new Uri(url);
            Provider = provider;
        }
                
        [JsonProperty("url")]                
        [JsonRequired()]               
        public Uri ShortUrl { get; private set; }
                
        [JsonProperty("keyword")]
        [JsonRequired()]
        public string Keyword { get; private set; }

        [JsonProperty("longurl")]
        public Uri LongUrl { get; private set; }

        [JsonProperty("provider")]
        public Provider Provider { get; private set; }

        public string ToJson()
        {            
            return JsonData.ToJson(this);
        }
        
    }
}