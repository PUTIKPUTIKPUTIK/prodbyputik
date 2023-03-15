using Microsoft.AspNetCore.Mvc;

namespace prodbyputik.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
