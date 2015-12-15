using System;
using System.Net;
using System.Text;
#if NET45
using System.Threading.Tasks;
#endif

namespace Canducci.ShortUrl
{
    public class IsGd : ShortUrlProvider
    {

        public IsGd(string url)
        {
            Validation.IsUrl(url, Validation.MessageUrlInvalid);                   
            Url = new Uri(url);
            Client = new WebClient();
            Client.Encoding = Encoding.UTF8;
            Address = string.Format("http://is.gd/create.php?format=simple&url={0}", url);
        }

        internal override string NormalizeContent(params string[] content)
        {
            return JsonData.Normalize(content[0], "");
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