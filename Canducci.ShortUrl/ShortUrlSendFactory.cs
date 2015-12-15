namespace Canducci.ShortUrl
{
    internal abstract class ShortUrlSendFactory
    {
        internal static ShortUrlSendTrim Create(string LongUrl)
        {
            return new ShortUrlSendTrim(LongUrl);
        }
        internal static ShortUrlSendTrim Create(string LongUrl, string Seed, string Keyword, string VanityDomain)
        {
            return new ShortUrlSendTrim(LongUrl, Seed, Keyword, VanityDomain);
        }
    }
}
