using Canducci.ShortUrl;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Canducci.Web45.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            ShortUrlSend request = ShortUrlSendFactory.Create("http://www.muchiutt.com.br/");

            ShortUrlClient client = ShortUrlClientFactory.Create("36b56b77ac24e5595b626b38c6e00074");

            ShortUrlReceive response = await client.ReceiveAsync(request);

            ViewBag.Url = response.ShortUrl;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}