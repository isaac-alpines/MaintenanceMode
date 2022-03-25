using System.Web.Mvc;

namespace MaintenanceMode.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}