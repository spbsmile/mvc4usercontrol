using System.Web.Mvc;

namespace MVC4UserControl.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        
        public ActionResult Index()
        {
            return View("View1");
        }

    }
}
