using Microsoft.AspNetCore.Mvc;
using ReviewsSite.Models;
using ReviewsSite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Properties.Controllers
{
    public class HomeController : Controller
    {
        private VideoGameContext db;
        public VideoGameRepository videoGameRepo;
        public HomeController (VideoGameContext db)
        {
            this.db = db;
        }

    public IActionResult Index()
    {
        return View(db.VideoGames.ToList());
    }

    public IActionResult Create()
    {
        return View(new VideoGame());
    }
    
    [HttpPost]
    public ActionResult Create(VideoGame game)
    {
        videoGameRepo.Create(game);
        return RedirectToAction("Index");
    }
    
    }
}
