using Canducci.ShortUrl;
namespace Canducci.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Provider TrIM
            string ApiKey = "36b56b77ac24e5595b626b38c6e00074";
            string Url = "http://www.muchiutt.com.br/loja";
            TrIm tr = new TrIm(ApiKey, Url);
            ShortUrlClient client = new ShortUrlClient(tr);
            ShortUrlReceive receive = client.Receive();

            //Provider IsGD
            IsGd isgd = new IsGd(Url);
            ShortUrlClient client1 = new ShortUrlClient(isgd);
            ShortUrlReceive receive1 = client1.Receive();

            Canducci.ShortUrl.ShortUrlFacade facade = new ShortUrlFacade(isgd);
            ShortUrlReceive c = facade.Receive();

            
        }
    }
}
