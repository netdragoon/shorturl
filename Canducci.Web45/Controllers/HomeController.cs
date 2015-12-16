using Canducci.ShortUrl;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Canducci.Web45.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            string url = "http://www.globo.com";

            ShortUrlClient client = new ShortUrlClient(new IsGd(url));

            ShortUrlReceive response = await client.ReceiveAsync();

            client.Dispose();

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