using AnimeDemoWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnimeDemoWeb.Controllers
{
    public class AnimeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ErrorLoad()
        {
            ViewData["Message"] = "Unable to load page";
            return View();
        }

        [HttpGet("random")]
        public async Task<IActionResult> Index(FormattedAnime f)
        {
            AnimeRequest request = new AnimeRequest();
            AnimeModel? anime = await request.GenerateAnime();
            FormattedAnime result = new FormattedAnime(anime);
            return View(result);
        }
    }
}
