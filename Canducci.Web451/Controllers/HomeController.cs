using Canducci.ShortUrl;
using System.Threading.Tasks;
using System.Web.Mvc;
namespace Canducci.Web451.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {

            ShortUrlFacade facade = ShortUrlFactory.Create("36b56b77ac24e5595b626b38c6e00074", "http://www.muchiutt.com.br/");

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