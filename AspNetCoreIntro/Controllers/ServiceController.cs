using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreIntro.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
