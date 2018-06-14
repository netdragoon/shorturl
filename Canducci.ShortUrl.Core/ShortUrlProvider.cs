using System;
using System.Net;
using System.Threading.Tasks;
namespace Canducci.ShortUrl
{
    [Serializable()]
    public abstract class ShortUrlProvider
    {
        public Uri Url { get; set; }

        public WebClient Client { get; set; }

        public string Address { get; set; }

        internal virtual string NormalizeContent(params string[] contents)
        {
            return string.Empty;
        }

        public virtual Provider Provider { get; set; }

        abstract public string Content();

        abstract public Task<string> ContentAsync();
    }
}
