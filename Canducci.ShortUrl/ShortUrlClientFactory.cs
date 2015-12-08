namespace Canducci.ShortUrl
{
    public abstract class ShortUrlClientFactory
    {
        public static ShortUrlClient Create(string ApiKey)
        {
            return new ShortUrlClient(ApiKey);
        }
        public static ShortUrlClient Instance(string ApiKey)
        {
            return ShortUrlClientSingleton.Instance(ApiKey);
        }
    }
}
