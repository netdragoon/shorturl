namespace Canducci.ShortUrl
{
    public abstract class ShortUrlClientFactory
    {
        public static ShortUrlClient Create(ShortUrlProvider Provider)
        {
            return new ShortUrlClient(Provider);
        }        
    }
}
