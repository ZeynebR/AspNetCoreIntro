using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreIntro.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
