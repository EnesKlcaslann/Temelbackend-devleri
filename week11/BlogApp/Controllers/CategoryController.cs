using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class CategoryController : Controller
    {
        // GET: CategoryController
        public ActionResult Index()
        {
            ViewBag.Deneyimlerim = "Deneyimlerim";

            return View();
        }

    }
}
