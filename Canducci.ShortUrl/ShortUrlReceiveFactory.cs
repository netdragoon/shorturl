namespace Canducci.ShortUrl
{
    internal abstract class ShortUrlReceiveFactory
    {
        internal static ShortUrlReceive Create(string Content, string Url)
        {
            return new ShortUrlReceive(Content, Url);
        }
    }
}
