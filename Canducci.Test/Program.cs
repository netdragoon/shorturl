using Canducci.ShortUrl;
namespace Canducci.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //36b56b77ac24e5595b626b38c6e00074

            string ApiKey = "36b56b77ac24e5595b626b38c6e00074";

            string Url = "http://www.muchiutt.com.br/loja";

            //ShortUrlSend request = ShortUrlSendFactory.Create(Url);            

            //ShortUrlClient client = ShortUrlClientFactory.Create("36b56b77ac24e5595b626b38c6e00074");            

            //ShortUrlReceive response = client.Receive(request);

            //client.Dispose();            

            ShortUrlFacade facade = ShortUrlFactory.Create(ApiKey, "http://www.uol.com.br");

            ShortUrlReceive receive = facade.Receive();

            string c = receive.ToJson();

            facade.Dispose();

        }
    }
}
