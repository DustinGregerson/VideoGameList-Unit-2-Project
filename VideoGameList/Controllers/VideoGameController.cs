using Microsoft.AspNetCore.Mvc;
using VideoGameList.Models;
//Author Dustin Gregerson
//Date 10/15/2023
//Description:
/*
 * Directs the traffic from the index page to the edit or delete pages depending on what button is clicked.
 * Each button is set to target the correct page and if required carries the model’s id so the data base will
 * know which record to update or delete from the Video Games table.

 */
namespace VideoGameList.Controllers
{
    public class VideoGameController : Controller
    {
        private videoGameContext context { get; set; }

        public VideoGameController(videoGameContext ctx)
        {
            context = ctx;
        }

        //Creates a new video game and increments the id by 1 for the new record
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new videoGame());
        }
        //Gets the id for the Video Game from the index page to alter the record in question in the edit page.
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var videoGame = context.videoGames.Find(id);
            return View(videoGame);
        }
        //When passed a video game if that games id is not equal 0 a new game is created
        //if that games id is not equal to 0 then the game is updated
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
        //Returns the delete view
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var videoGame = context.videoGames.Find(id);
            return View(videoGame);
        }
        //Findes the video game in the video games table and deletes it from the data base
        [HttpPost]
        public IActionResult Delete(videoGame videoGame)
        {
            context.videoGames.Remove(videoGame);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
