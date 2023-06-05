using Microsoft.AspNetCore.Mvc;

namespace WeekendlyTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
