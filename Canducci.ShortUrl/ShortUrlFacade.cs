using System;
#if NET45
using System.Threading.Tasks;
#endif
namespace Canducci.ShortUrl
{
    public class ShortUrlFacade: IDisposable
    {
        private ShortUrlProvider provider;

        private ShortUrlClient client;

        public ShortUrlFacade(ShortUrlProvider provider)
        {
            this.provider = provider;
            client = ShortUrlClientFactory.Create(provider);
        }

        public void Dispose()
        {
            if (provider != null && provider.Client != null)
            {
                provider.Client.Dispose();
            }
            provider = null;
            if (client != null)
            {
                client.Dispose();
            }       
            client = null;            
        }

        public ShortUrlReceive Receive()
        {
            return client.Receive();
        }

#if NET45
        public async Task<ShortUrlReceive> ReceiveAsync()
        {
            return await client.ReceiveAsync();
        }
#endif

    }
}