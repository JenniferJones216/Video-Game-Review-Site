using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Properties.Controllers
{
    public class HomeController : Controller
    {
        private VideoGameContext db;
        public HomeController (VideoGameContext db)
        {
            this.db = db;
        }

    public IActionResult Index()
        {
            return View(db.VideoGames.ToList());
        }
    }
}
