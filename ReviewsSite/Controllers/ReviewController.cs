using Microsoft.AspNetCore.Mvc;
using ReviewsSite.Models;
using ReviewsSite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Controllers
{
    public class ReviewController : Controller
    {
        public IRepository<Review> reviewRepo;

        public ReviewController(IRepository<Review> reviewRepo)
        {
            this.reviewRepo = reviewRepo;
        }
        public ViewResult Index()
        {
            return View(reviewRepo.GetAll());
        }
        public ViewResult Details(int id)
        {
            return View(reviewRepo.GetByID(id));
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
