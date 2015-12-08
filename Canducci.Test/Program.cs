using Canducci.ShortUrl;
namespace Canducci.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //36b56b77ac24e5595b626b38c6e00074

            //ShortUrlSend request = ShortUrlSendFactory.Create("http://www.muchiutt.com.br/loja");

            //ShortUrlClient client = ShortUrlClientFactory.Create("36b56b77ac24e5595b626b38c6e00074");            

            //ShortUrlReceive response = client.Receive(request);

            //client.Dispose();

            ShortUrlFacade facade = ShortUrlFactory.Create("36b56b77ac24e5595b626b38c6e00074", "http://www.muchiutt.com.br/loja");
            ShortUrlReceive receive = facade.Receive();
            string c = receive.ToJson();
            facade.Dispose();
        }
    }
}
