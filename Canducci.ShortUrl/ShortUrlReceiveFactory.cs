namespace Canducci.ShortUrl
{
    internal abstract class ShortUrlReceiveFactory
    {
        internal static ShortUrlReceive Create(string content, string url)
        {
            return new ShortUrlReceive(content, url);
        }
    }
}
