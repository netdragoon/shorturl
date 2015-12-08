using System;
using System.Net;
using System.Text;
#if NET45
using System.Threading.Tasks;
#endif
namespace Canducci.ShortUrl
{
    [Serializable()]
    public sealed class ShortUrlClient: IDisposable
    {
        private WebClient client;
        private ShortUrlSend request;
        private string apiKey;
        private const string address = "https://tr.im/links";        
        public ShortUrlClient(string ApiKey)
        {
            Validation.IsNullOrEmpty(ApiKey, "Api Key invalid ou empty.");            
            apiKey = ApiKey;
            client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.Encoding = Encoding.UTF8;
            client.Headers.Add("x-api-key", apiKey);
        }
        public ShortUrlReceive Receive(ShortUrlSend Request)
        {
            request = Request;            
            return receive();
        }
        public ShortUrlReceive Receive(string LongUrl)
        {            
            request = ShortUrlSendFactory.Create(LongUrl);
            return receive();
        }
        private ShortUrlReceive receive()
        {
            try
            {
                string json = request.ToJson();
                string content = client.UploadString(address, "POST", json);
                return ShortUrlReceiveFactory.Create(content, request.LongUrl);
            }
            catch (WebException ex)
            {
                throw ex;
            }
        }
#if NET45
        public async Task<ShortUrlReceive> ReceiveAsync(ShortUrlSend Request)
        {
            request = Request;            
            return await receiveAsync();
        }
        public async Task<ShortUrlReceive> ReceiveAsync(string LongUrl)
        {            
            request = ShortUrlSendFactory.Create(LongUrl);              
            return await receiveAsync();
        }
        private async Task<ShortUrlReceive> receiveAsync()
        {
            try
            {
                string json = request.ToJson();
                string content = await client.UploadStringTaskAsync(address, "POST", json);
                return ShortUrlReceiveFactory.Create(content, request.LongUrl);
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
            if (client != null)
            {
                client.Dispose();
            }
            request = null;
        }
        #endregion

    }
}