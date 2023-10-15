using Microsoft.AspNetCore.Mvc;
using VideoGameList.Models;

namespace VideoGameList.Controllers
{
    public class VideoGameController : Controller
    {
        private videoGameContext context { get; set; }

        public VideoGameController(videoGameContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new videoGame());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var videoGame = context.videoGames.Find(id);
            return View(videoGame);
        }
        [HttpPost]
        public IActionResult Edit(videoGame videoGame)
        {
            if (ModelState.IsValid)
            {
                if (videoGame.videoGameId == 0)
                    context.videoGames.Add(videoGame);
                else
                    context.videoGames.Update(videoGame);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (videoGame.videoGameId == 0) ? "Add" : "Edit";
                return View(videoGame);
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var videoGame = context.videoGames.Find(id);
            return View(videoGame);
        }

        [HttpPost]
        public IActionResult Delete(videoGame videoGame)
        {
            context.videoGames.Remove(videoGame);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
