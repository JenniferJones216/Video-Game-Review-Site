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
        public VideoGameController(VideoGameRepository videoGameRepo)
        {
            this.videoGameRepo = videoGameRepo;
        }
        public ViewResult Index()
        {
            return View(videoGameRepo.GetAll());
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
