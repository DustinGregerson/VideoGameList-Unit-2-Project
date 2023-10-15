using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using VideoGameList.Models;

namespace VideoGameList.Controllers
{
    public class HomeController : Controller
    {
        private videoGameContext context { get; set; }

        public HomeController(videoGameContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            var videoGames = context.videoGames.ToList();
            return View(videoGames);
        }

    }
}