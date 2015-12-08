using Canducci.ShortUrl;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Canducci.Web45.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {

            string ApiKey = ""; //digite o api key

            string Url = ""; //digite a url

            ShortUrlSend request = ShortUrlSendFactory.Create(Url);

            ShortUrlClient client = ShortUrlClientFactory.Create(ApiKey);

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