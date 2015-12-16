using System;
using System.Net;
using System.Text;
#if NET45
using System.Threading.Tasks;
#endif
namespace Canducci.ShortUrl
{
    [Serializable()]
    public sealed class IsGd : ShortUrlProvider
    {
        private string address = "http://is.gd/create.php?format=simple&url={0}";

        public IsGd(string url)
        {
            Validation.IsUrl(url, Message.MessageUrlIsInvalid);                   
            Url = new Uri(url);
            Client = WebClientFactory.Create();
            Address = string.Format(address, url);
            Provider = new Provider("is.gd", new Uri("http://is.gd/"));
        }

        internal override string NormalizeContent(params string[] contents)
        {
            return JsonData.Normalize(contents[0], "");
        }

        public override string Content()
        {
            string content = Client.DownloadString(Address);
            return NormalizeContent(content);
        }

#if NET45
        public override async Task<string> ContentAsync()
        {            
            string content = await Client.DownloadStringTaskAsync(Address);
            return NormalizeContent(content);
        }
#endif

    }
}