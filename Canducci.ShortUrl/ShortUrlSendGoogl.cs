using Newtonsoft.Json;
using System;
namespace Canducci.ShortUrl
{
    [JsonObject()]
    [Serializable()]
    internal class ShortUrlSendGoogl : IJson
    {
        [JsonConstructor()]
        protected ShortUrlSendGoogl() { }

        public ShortUrlSendGoogl(string url)
        {
            Validation.IsNullOrEmpty(url, Message.MessageUrlIsInvalid);
            LongUrl = url;
        }

        [JsonProperty("longUrl")]
        public string LongUrl { get; set; }

        public string ToJson()
        {
            return JsonData.ToJson(this);
        }
    }

}
