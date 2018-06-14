using System;
using System.Net;
using System.Threading.Tasks;
namespace Canducci.ShortUrl
{
    [Serializable()]
    public sealed class Googl : ShortUrlProvider
    {
        private string ApiKey { get; set; }

        private readonly string address = "https://www.googleapis.com/urlshortener/v1/url?key={0}";

        internal ShortUrlSendGoogl Send { get; set; }

        public Googl(string key, string url)
        {
            Validation.IsUrl(url, Message.MessageUrlIsInvalid);
            Validation.IsNullOrEmpty(key, Message.MessageKeyIsEmpty);

            Send = new ShortUrlSendGoogl(url);
            Url = new Uri(url, UriKind.RelativeOrAbsolute);
            ApiKey = key;

            WebHeaderCollection Headers = new WebHeaderCollection();
            Headers.Add(HttpRequestHeader.ContentType, "application/json");
            Headers.Add("key", ApiKey);
            Client = WebClientFactory.Create(Headers);

            Address = string.Format(address, ApiKey);
            Provider = new Provider("goo.gl", new Uri("https://www.googleapis.com/"));
        }

        internal override string NormalizeContent(params string[] contents)
        {
            dynamic value = JsonData.ToObject(contents[0]);            
            return JsonData.Normalize(value.id.ToString(), "");
        }

        public override string Content()
        {
            string json = Send.ToJson();
            string content = Client.UploadString(Address, "POST", json);
            return NormalizeContent(content);
        }

        public override async Task<string> ContentAsync()
        {
            string json = Send.ToJson();
            string content = await Client.UploadStringTaskAsync(Address, "POST", json);
            return NormalizeContent(content);
        }

    }
}
