using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using VideoGameList.Models;


//Author Dustin Gregerson
//Date 10/15/2023
//Description:
/*
 * This is the home controller for the site. It passes the index page to the browser
 * it also compiles a list of video game models that are derived from the video games data table
 */
namespace VideoGameList.Controllers
{
    public class HomeController : Controller
    {
        private videoGameContext context { get; set; }

        public HomeController(videoGameContext ctx)
        {
            context = ctx;
        }
        //when this method is called every record in the videoGames table will be stored in a videoGame model list
        //this list is then passed to the index page.
        public IActionResult Index()
        {
            var videoGames = context.videoGames.ToList();
            return View(videoGames);
        }

    }
}