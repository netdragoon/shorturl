using Canducci.ShortUrl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Canducci.Web451.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost()]
        public async Task<JsonResult> GetBitLy(string url)
        {
            string token = "bc6da10fdeaf9464d82cdf475cfb3b19c1a506ca";
            Bitly provider = new Bitly(token, url);
            ShortUrlClient client = ShortUrlClientFactory.Create(provider);
            return Json(await client.ReceiveAsync(), JsonRequestBehavior.DenyGet);
        }

        [HttpPost()]
        public async Task<JsonResult> GetGoogl(string url)
        {
            string key = "AIzaSyD8UPkwOX2SZJGBFKazFZ1wFIJeVu6UWMA";
            Googl provider = new Googl(key, url);
            ShortUrlClient client = ShortUrlClientFactory.Create(provider);
            return Json(await client.ReceiveAsync(), JsonRequestBehavior.DenyGet);
        }

        [HttpPost()]
        public async Task<JsonResult> GetIsGd(string url)
        {
            IsGd provider = new IsGd(url);
            ShortUrlClient client = ShortUrlClientFactory.Create(provider);
            return Json(await client.ReceiveAsync(), JsonRequestBehavior.DenyGet);
        }

        [HttpPost()]
        public async Task<JsonResult> GetMigreMe(string url)
        {            
            MigreMe provider = new MigreMe(url);
            ShortUrlClient client = ShortUrlClientFactory.Create(provider);
            return Json(await client.ReceiveAsync(), JsonRequestBehavior.DenyGet);
        }

        [HttpPost()]
        public async Task<JsonResult> GetTinyUrl(string url)
        {            
            TinyUrl provider = new TinyUrl(url);
            ShortUrlClient client = ShortUrlClientFactory.Create(provider);
            return Json(await client.ReceiveAsync(), JsonRequestBehavior.DenyGet);
        }

        [HttpPost()]
        public async Task<JsonResult> GetTrIm(string url)
        {
            string key = "36b56b77ac24e5595b626b38c6e00074";
            TrIm provider = new TrIm(key, url);
            ShortUrlClient client = ShortUrlClientFactory.Create(provider);
            return Json(await client.ReceiveAsync(), JsonRequestBehavior.DenyGet);
        }

    }
}