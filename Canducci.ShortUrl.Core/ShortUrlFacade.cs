using System;
using System.Threading.Tasks;
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

        public async Task<ShortUrlReceive> ReceiveAsync()
        {
            return await client.ReceiveAsync();
        }

    }
}