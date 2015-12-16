using System;
using System.Net;
using System.Text;
#if NET45
using System.Threading.Tasks;
#endif
namespace Canducci.ShortUrl
{
    public class MigreMe : ShortUrlProvider
    {
        public MigreMe(string url)
        {
            Validation.IsUrl(url, Message.MessageUrlIsInvalid);
            Url = new Uri(url);
            Client = new WebClient();
            Client.Encoding = Encoding.UTF8;
            Address = string.Format("http://migre.me/api.txt?url={0}", url);
            Provider = new Provider("Migre.me", new Uri("http://migre.me/"));
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
