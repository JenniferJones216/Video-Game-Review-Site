using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using ReviewsSite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Controllers
{
    public class PlatformController : Controller
    {
        public PlatformRepository platformRepo;
        public PlatformController(PlatformRepository platformRepo)
        {
            this.platformRepo = platformRepo;
        }
        public VideoGameContext db;
        public PlatformController(VideoGameContext db)
        {
           this.db = db;
        }
        public ViewResult Index()
        {
            return View(platformRepo.GetAll());
        }
        public ViewResult Details(int id)
        {
            return View(platformRepo.GetByID(id));
        }
        //public IActionResult Index()
        // {
        //    return View(db.Platforms.ToList());
        // }
    }
}
