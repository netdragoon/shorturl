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

        public ShortUrlSendTrim(string longurl)
        {
            validate(longurl);
            LongUrl = longurl;
        }

        public ShortUrlSendTrim(string longurl, string seed, string keyword, string vanitydomain)
        {
            validate(longurl);      
            LongUrl = longurl;
            Seed = seed;
            Keyword = keyword;
            VanityDomain = vanitydomain;
        }
        
        private void validate(string longurl)
        {
            Validation.IsNullOrEmpty(longurl, Message.MessageUrlIsEmpty);
            Validation.IsUrl(longurl, Message.MessageUrlIsInvalid);
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
