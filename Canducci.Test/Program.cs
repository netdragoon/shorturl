using Canducci.ShortUrl;
namespace Canducci.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Provider TrIM            
            //TrIm tr = new TrIm("36b56b77ac24e5595b626b38c6e00074", "http://www.muchiutt.com.br/loja");
            //ShortUrlClient client0 = new ShortUrlClient(tr);
            //ShortUrlReceive receive0 = client0.Receive();

            //Provider IsGD
            //IsGd isgd = new IsGd("http://www.globo.com");
            //ShortUrlClient client1 = new ShortUrlClient(isgd);
            //ShortUrlReceive receive1 = client1.Receive();

            //ShortUrlFacade facade0 = new ShortUrlFacade(isgd);
            //ShortUrlReceive c0 = facade0.Receive();

            //Provider t
            TinyUrl timurl = new TinyUrl("http://www.uol.com.br");
            ShortUrlClient client2 = new ShortUrlClient(timurl);
            ShortUrlReceive receive2 = client2.Receive();
        }
    }
}
