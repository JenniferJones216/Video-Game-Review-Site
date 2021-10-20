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
        public ReviewRepository reviewRepo;

        public ReviewController(ReviewRepository reviewRepo)
        {
            this.reviewRepo = reviewRepo;
        }
        public ViewResult Index(int? id)
        {
            if(id == null)
            {
                return View(reviewRepo.GetAllOrdered());
            } 
            else
            {
                return View(reviewRepo.GetByGameId((int)id));
            }
            
        }

        public IActionResult Create(int id)             //id = videogameid to our knowledge
        {
            //if(VideoGameId != null)
            //{
            //    ViewBag.Disabled = "disabled";
            //}
            //ViewBag.VideoGames = reviewRepo.get

            Review myReview = new Review();
            myReview.VideoGameId = id;

            return View(myReview);
        }
        [HttpPost]
        public IActionResult Create(Review review)
        {
            reviewRepo.Create(review);

            return RedirectToAction("Details", "VideoGame", new { id = review.VideoGameId });
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        /*public IActionResult Edit(int id)
        {
            var review = reviewRepo.GetByID(id);
            return View(review);
        }

        [HttpPost]
        public IActionResult Edit(Review review)
        {
            reviewRepo.Update(review);
            return RedirectToAction("Details", "VideoGame");
        }*/
    }
}
