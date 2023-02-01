using Microsoft.AspNetCore.Mvc;
using System;

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
