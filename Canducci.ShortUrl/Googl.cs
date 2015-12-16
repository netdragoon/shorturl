using System;
using System.Net;
using System.Text;
#if NET45
using System.Threading.Tasks;
#endif
namespace Canducci.ShortUrl
{
    [Serializable()]
    public class Googl : ShortUrlProvider
    {
        protected string ApiKey { get; set; }
        internal ShortUrlSendGoogl Send { get; set; }

        public Googl(string key, string url)
        {
            Validation.IsUrl(url, Message.MessageUrlIsInvalid);
            Validation.IsNullOrEmpty(key, Message.MessageKeyIsEmpty);
            Send = new ShortUrlSendGoogl(url);
            Url = new Uri(url, UriKind.RelativeOrAbsolute);
            ApiKey = key;
            Client = new WebClient();
            Client.Headers.Add(HttpRequestHeader.ContentType, "application/json");            
            Client.Encoding = Encoding.UTF8;
            Client.Headers.Add("x-api-key", ApiKey);
            Address = string.Format("https://www.googleapis.com/urlshortener/v1/url?key={0}", ApiKey);
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

#if NET45
        public override async Task<string> ContentAsync()
        {
            string json = Send.ToJson();
            string content = await Client.UploadStringTaskAsync(Address, "POST", json);
            return NormalizeContent(content);
        }
#endif
    }
}
