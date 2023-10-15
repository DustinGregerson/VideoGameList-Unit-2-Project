using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VideoGameList.Models;

namespace VideoGameList.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}