using System;
using System.Net;
using System.Threading.Tasks;

namespace Canducci.ShortUrl
{
    [Serializable()]
    public sealed class TrIm : ShortUrlProvider
    {
        private string Key {get; set;}

        private readonly string address = "https://tr.im/links";

        private ShortUrlSendTrim Send { get; set; }

        public TrIm(string key, string url)
        {
            validate(key, url);
            loadVariable(key, url);
            Send = ShortUrlSendFactory.Create(url);
        }

        public TrIm(string key, string url, string seed, string keyword, string vanitydomain)
        {
            validate(key, url);
            loadVariable(key, url);
            Send = ShortUrlSendFactory.Create(url, seed, keyword, vanitydomain);
        }

        private void validate(string key, string url)
        {
            Validation.IsUrl(url, Message.MessageUrlIsInvalid);
            Validation.IsNullOrEmpty(key, Message.MessageKeyIsEmpty);
        }

        private void loadVariable(string key, string url)
        {
            Url = new Uri(url, UriKind.RelativeOrAbsolute);
            Key = key;

            WebHeaderCollection Headers = new WebHeaderCollection();
            Headers.Add(HttpRequestHeader.ContentType, "application/json");            
            Headers.Add("x-api-key", Key);
            Client = WebClientFactory.Create(Headers);

            Address = address;
            Provider = new Provider("tr.im", new Uri("https://tr.im/"));
        }
                
        public override string Content()
        {
            string json = Send.ToJson();
            return Client.UploadString(Address, "POST", json);
        }

        public override async Task<string> ContentAsync()
        {
            string json = Send.ToJson();
            return await Client.UploadStringTaskAsync(Address, "POST", json);
        }

    }
}
