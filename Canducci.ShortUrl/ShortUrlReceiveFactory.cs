namespace Canducci.ShortUrl
{
    public abstract class ShortUrlReceiveFactory
    {
        public static ShortUrlReceive Create(string Content, string Url)
        {
            return new ShortUrlReceive(Content, Url);
        }
    }
}
