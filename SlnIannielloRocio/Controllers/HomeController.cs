using Microsoft.AspNetCore.Mvc;

namespace SlnIannielloRocio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
