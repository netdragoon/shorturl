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
            //TinyUrl timurl = new TinyUrl("http://www.baboo.com.br");
            //ShortUrlClient client2 = new ShortUrlClient(timurl);
            //ShortUrlReceive receive2 = client2.Receive();

            //token: bc6da10fdeaf9464d82cdf475cfb3b19c1a506ca
            //api-key: R_057081cc837e4819aee73a8314c261d5
            //Bitly bitly = new Bitly("bc6da10fdeaf9464d82cdf475cfb3b19c1a506ca", "http://www.ig.com.br");
            //ShortUrlClient client3 = new ShortUrlClient(bitly);
            //ShortUrlReceive receive3 = client3.Receive();
            //string json = receive3.ToJson();

            //MigreMe migreme = new MigreMe("http://www.ig.com.br");
            //ShortUrlClient client = ShortUrlClientFactory.Create(migreme);
            //ShortUrlReceive receive = client.Receive();
            //https://www.googleapis.com/urlshortener/v1/url?shortUrl=http%3A%2F%2Fwww.gmail.com&projection=FULL&key={YOUR_API_KEY}
            //https://developers.google.com/url-shortener/v1/getting_started

            //Googl googl = new Googl("AIzaSyD8UPkwOX2SZJGBFKazFZ1wFIJeVu6UWMA", "http://www.youtube.com");
            //ShortUrlClient clientg = new ShortUrlClient(googl);
            //ShortUrlReceive receive = clientg.Receive();

            //string json = receive.ToJson();

            Googl googl = new Googl("AIzaSyD8UPkwOX2SZJGBFKazFZ1wFIJeVu6UWMA", "http://www.youtube.com");
            ShortUrlFacade facade = new ShortUrlFacade(googl);
            ShortUrlReceive receive = facade.Receive();

        }
    }
}
