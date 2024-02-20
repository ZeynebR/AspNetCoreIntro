using AspNetCoreIntro.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreIntro.Controllers
{
    public class HomeController : Controller
    {

        readonly EsignedDbContext _esignedDbContext;

        public HomeController(EsignedDbContext esignedDbContext)
        {
            _esignedDbContext = esignedDbContext;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
