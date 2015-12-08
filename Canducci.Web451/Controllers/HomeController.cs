using Canducci.ShortUrl;
using System.Threading.Tasks;
using System.Web.Mvc;
namespace Canducci.Web451.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            string ApiKey = ""; // digite o api key
            string Url = ""; // digite o endereço

            ShortUrlFacade facade = ShortUrlFactory.Create(ApiKey, Url);

            ShortUrlReceive response = await facade.ReceiveAsync();

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