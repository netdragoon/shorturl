using Canducci.ShortUrl;
using System.Threading.Tasks;
using System.Web.Mvc;
namespace Canducci.Web451.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {

            TinyUrl turl = new TinyUrl("http://www.gmail.com");

            ShortUrlClient client = ShortUrlClientFactory.Create(turl);

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