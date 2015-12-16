using System;
using System.Net;
using System.Text;
#if NET45
using System.Threading.Tasks;
#endif
namespace Canducci.ShortUrl
{
    [Serializable()]
    public sealed class Bitly : ShortUrlProvider
    {
        private string Token { get; set; }

        private string address = "https://api-ssl.bitly.com/v3/shorten?access_token={0}&longUrl={1}&format=txt";

        public Bitly(string token, string url)
        {
            Validation.IsNotNull(token, Message.MessageKeyIsEmpty);
            Validation.IsUrl(url, Message.MessageUrlIsInvalid);

            Url = new Uri(url);
            Token = token;

            WebHeaderCollection Headers = new WebHeaderCollection();
            Headers.Add("token", token);
            Client = WebClientFactory.Create(Headers);

            Address = string.Format(address, token, url);
            Provider = new Provider("bitly", new Uri("https://bitly.com/"));
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
