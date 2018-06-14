namespace Canducci.ShortUrl
{
    internal abstract class ShortUrlReceiveFactory
    {
        internal static ShortUrlReceive Create(string content, string url, Provider provider)
        {
            return new ShortUrlReceive(content, url, provider);
        }
    }
}
