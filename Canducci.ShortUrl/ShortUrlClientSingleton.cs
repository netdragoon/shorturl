namespace Canducci.ShortUrl
{
    internal class ShortUrlClientSingleton
    {
        private static ShortUrlClient instance;
        private static object syncRoot = new object();
        private ShortUrlClientSingleton() { }
        public static ShortUrlClient Instance(string ApiKey)
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = ShortUrlClientFactory.Create(ApiKey);
                    }
                }
            }
            return instance;
        }
    }
}