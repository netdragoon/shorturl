using Canducci.ShortUrl;
using System;

namespace Canducci.Console.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://www.nuget.org";
            TinyUrl provider = new TinyUrl(url);
            ShortUrlFacade facade = new ShortUrlFacade(provider);
            ShortUrlReceive receive = facade.Receive();
            System.Console.WriteLine(receive.ToJson());
        }
    }
}
