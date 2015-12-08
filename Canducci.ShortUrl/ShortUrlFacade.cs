using System;
#if NET45
using System.Threading.Tasks;
#endif
namespace Canducci.ShortUrl
{
    public class ShortUrlFacade: IDisposable
    {
        private ShortUrlSend send;
        private ShortUrlClient client;                
        public ShortUrlFacade(string ApiKey, string LongUrl)
        {
            send = ShortUrlSendFactory.Create(LongUrl);                        
            client = ShortUrlClientFactory.Create(ApiKey);            
        }
        public void Dispose()
        {
            send = null;
            client.Dispose();
        }
        public ShortUrlReceive Receive()
        {
            return client.Receive(send);
        }
#if NET45
        public async Task<ShortUrlReceive> ReceiveAsync()
        {
            return await client.ReceiveAsync(send);
        }
#endif
    }
}