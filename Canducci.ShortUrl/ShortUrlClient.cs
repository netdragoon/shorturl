using System;
using System.Net;
#if NET45
using System.Threading.Tasks;
#endif
namespace Canducci.ShortUrl
{
    [Serializable()]
    public sealed class ShortUrlClient: IDisposable
    {
        private ShortUrlProvider provider;              
        public ShortUrlClient(ShortUrlProvider Provider)
        {            
            provider = Provider;
        }
        public ShortUrlReceive Receive()
        {
            try
            {
                string content = provider.Content();
                return ShortUrlReceiveFactory.Create(content, provider.Url.AbsoluteUri, provider.Provider);
            }
            catch (WebException ex)
            {
                throw ex;
            }
        }
#if NET45
        public async Task<ShortUrlReceive> ReceiveAsync()
        {
            try
            {                
                string content = await provider.ContentAsync();
                return ShortUrlReceiveFactory.Create(content, provider.Url.AbsoluteUri, provider.Provider);
            }
            catch (WebException ex)
            {
                throw ex;
            }
        }
#endif

        #region Dispose
        public void Dispose()
        {
            if (provider != null)
            {
                if (provider.Client != null)
                {
                    provider.Client.Dispose();
                }
                provider.Client = null;
                provider = null;
            }
        }
        #endregion

    }
}