namespace Canducci.ShortUrl
{
    public abstract class ShortUrlSendFactory
    {
        public static ShortUrlSend Create(string LongUrl)
        {
            return new ShortUrlSend(LongUrl);
        }
        public static ShortUrlSend Create(string LongUrl, string Seed, string Keyword, string VanityDomain)
        {
            return new ShortUrlSend(LongUrl, Seed, Keyword, VanityDomain);
        }
    }
}
