using System;
using System.Net;
using System.Text;
#if NET45
using System.Threading.Tasks;
#endif
namespace Canducci.ShortUrl
{
    public class TinyUrl : ShortUrlProvider
    {
        public TinyUrl(string url)
        { 
            Validation.IsUrl(url, Message.MessageUrlIsInvalid);
            Url = new Uri(url);
            Client = new WebClient();
            Client.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
            Client.Encoding = Encoding.Unicode;
            Address = "http://tinyurl.com/create.php";
            Provider = new Provider("tinyurl", "http://tinyurl.com");
        }

        public override string Content()
        {
            string content = Client.UploadString(Address, "POST", string.Format("url={0}", Url.AbsoluteUri));
            return content;
        }

#if NET45
        public override async Task<string> ContentAsync()
        {
            string content = await Client.UploadStringTaskAsync(Address, "POST", string.Format("url={0}", Url.AbsoluteUri));
            return NormalizeContent(content);
        }
#endif
    }
}