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
        public IRepository<VideoGame> videoGameRepo;
        public VideoGameContext db;
        public VideoGameController(IRepository<VideoGame> videoGameRepo, VideoGameContext db)
        {
            this.videoGameRepo = videoGameRepo;
            this.db = db;
        }
        public ViewResult Index()
        {
            var videoGames = db.VideoGames.ToList();

            foreach(var game in videoGames)
            {
                game.SetAverage();
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
