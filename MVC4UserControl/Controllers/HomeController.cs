using System.Linq;
using System.Web.Mvc;
using MVC4UserControl.Models;

namespace MVC4UserControl.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        private EmployeeContext db = new EmployeeContext();


        public ActionResult Index()
        {
            var model = new TableEmployeeEntities1();
            var list = model.TableEmployees.ToList();
            return View(list);
        }

        public ActionResult Details(int id)
        {
            var model = new TableEmployeeEntities1();
            var targetEmployee = model.TableEmployees.Single(x => x.Id == id);

            return View(targetEmployee);
        }
    }
}
