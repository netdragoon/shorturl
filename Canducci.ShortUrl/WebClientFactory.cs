using System.Net;
using System.Text;
namespace Canducci.ShortUrl
{

    internal class WebClientFactory
    {

        public static WebClient Create()
        {
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            return client;
        }

        public static WebClient Create(WebHeaderCollection Headers)
        {
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            client.Headers = Headers;
            return client;
        }

    }

}
