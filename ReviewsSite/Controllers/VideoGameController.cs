using Microsoft.AspNetCore.Mvc;
using ReviewsSite.Models;
using ReviewsSite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Controllers
{
    // This may become obsolete *********************************************************************
    public class VideoGameController : Controller
    {
        public IRepository<VideoGame> videoGameRepo;
        public VideoGameController(IRepository<VideoGame> videoGameRepo)
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
