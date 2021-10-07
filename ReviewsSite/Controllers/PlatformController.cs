using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Controllers
{
    public class PlatformController : Controller
    {
        public VideoGameContext db;
        public PlatformController (VideoGameContext db)
        {
           this.db = db;
        }

        public IActionResult Index()
        {
            return View(db.Platforms.ToList());
        }
    }
}
