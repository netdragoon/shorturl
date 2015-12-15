namespace Canducci.ShortUrl
{
    internal abstract class ShortUrlSendFactory
    {
        internal static ShortUrlSendTrim Create(string longurl)
        {
            return new ShortUrlSendTrim(longurl);
        }
        internal static ShortUrlSendTrim Create(string longurl, string seed, string keyword, string vanitydomain)
        {
            return new ShortUrlSendTrim(longurl, seed, keyword, vanitydomain);
        }
    }
}
