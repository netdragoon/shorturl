using Newtonsoft.Json;
using System;
namespace Canducci.ShortUrl
{
    [JsonObject()]    
    [Serializable()]
    internal class ShortUrlSendTrim: IJson
    {
        [JsonConstructor()]
        protected ShortUrlSendTrim() { }
        public ShortUrlSendTrim(string LongUrl)
        {
            Validation.IsNullOrEmpty(LongUrl, "LongUrl is empty.");
            Validation.IsUrl(LongUrl, "Url invalid.");
            this.LongUrl = LongUrl;
        }
        public ShortUrlSendTrim(string LongUrl, string Seed, string Keyword, string VanityDomain)
        {
            Validation.IsNullOrEmpty(LongUrl, "LongUrl is empty.");
            Validation.IsUrl(LongUrl, "Url invalid.");            
            this.LongUrl = LongUrl;
            this.Seed = Seed;
            this.Keyword = Keyword;
            this.VanityDomain = VanityDomain;
        }
        
        [JsonRequired()]
        [JsonProperty("long_url")]
        public string LongUrl { get; private set; }
        
        [JsonProperty("seed")]
        public string Seed { get; private set; }
        
        [JsonProperty("keyword")]
        public string Keyword { get; private set; }
        
        [JsonProperty("vanity_domain")]
        public string VanityDomain { get; private set; }

        public string ToJson()
        {
            return JsonData.ToJson(this);
        }
    }
}
