
using System.Web.Mvc;

namespace Clockwork.Web.Controllers
{
    public class LogsController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Api = System.Configuration.ConfigurationManager.AppSettings["Api"];
            return View();
        }
    }
}