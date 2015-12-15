using System;
using System.Net;
using System.Text;
#if NET45
using System.Threading.Tasks;
#endif
namespace Canducci.ShortUrl
{
    public class TrIm : ShortUrlProvider
    {

        protected string ApiKey {get; set;}        

        internal ShortUrlSendTrim Send { get; set; }

        public TrIm(string key, string url)
        {
            Validate(key, url);
            LoadVariable(key, url);
            Send = ShortUrlSendFactory.Create(url);
        }
        public TrIm(string key, string url, string seed, string keyword, string vanitydomain)
        {
            Validate(key, url);
            LoadVariable(key, url);
            Send = ShortUrlSendFactory.Create(url, seed, keyword, vanitydomain);
        }
        protected void Validate(string key, string url)
        {
            Validation.IsUrl(url, "Url invalid");
            Validation.IsNullOrEmpty(key, "Api Key invalid ou empty.");
        }
        protected void LoadVariable(string key, string url)
        {
            Url = new Uri(url, UriKind.RelativeOrAbsolute);
            ApiKey = key;
            Client = new WebClient();
            Client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            Client.Encoding = Encoding.UTF8;
            Client.Headers.Add("x-api-key", ApiKey);
            Address = "https://tr.im/links";
        }
                
        public override string Content()
        {
            string json = Send.ToJson();
            return Client.UploadString(Address, "POST", json);
        }

#if NET45
        public override async Task<string> ContentAsync()
        {
            string json = null;
            return await Client.UploadStringTaskAsync(Address, "POST", json);
        }
#endif
    }
}
