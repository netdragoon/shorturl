namespace Canducci.ShortUrl
{
    public abstract class ShortUrlFactory
    {
        public static ShortUrlFacade Create(string ApiKey, string LongUrl)
        {
            return new ShortUrlFacade(ApiKey, LongUrl);
        }
    }
}
