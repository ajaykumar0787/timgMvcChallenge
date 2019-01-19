using System.Web.Mvc;

namespace OrderViewer.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Orders()
        {
            ViewBag.Message = "Client Orders";

            return View();
        }
    }
}