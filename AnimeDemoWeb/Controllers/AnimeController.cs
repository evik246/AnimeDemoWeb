using Microsoft.AspNetCore.Mvc;

namespace AnimeDemoWeb.Controllers
{
    public class AnimeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
