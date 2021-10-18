using Microsoft.AspNetCore.Mvc;
using ReviewsSite.Models;
using ReviewsSite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Controllers
{
    public class VideoGameController : Controller
    {
        public VideoGameRepository videoGameRepo;
        public VideoGameContext db;
        public VideoGameController(VideoGameRepository videoGameRepo, VideoGameContext db)
        {
            this.videoGameRepo = videoGameRepo;
            this.db = db;
        }
        public ViewResult Index()
        {
            var videoGames = db.VideoGames.ToList();

            foreach(var game in videoGames)
            {
                game.GetAverage();
            }

            return View(videoGames);
        }
        public ViewResult Details(int id)
        {
            return View(videoGameRepo.GetByID(id));
        }
        public IActionResult Create()
        {
            return View(new VideoGame());
        }
    }
}
