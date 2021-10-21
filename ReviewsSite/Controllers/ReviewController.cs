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
            TempData["ReturnUrl"] = Request.Headers["Referer"].ToString();
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
        public IActionResult Edit(int id)           //THIS IS THE REVIEW ID
        {
            TempData["ReturnUrl"] = Request.Headers["Referer"].ToString();
            var review = reviewRepo.GetByID(id);
            return View(review);
        }

        [HttpPost]
        public IActionResult Edit(Review review)
        {
            reviewRepo.Update(review);
            //return RedirectToAction("Details", "VideoGame", new { id = review.VideoGameId });
            return Redirect(TempData["ReturnUrl"].ToString());
        }

        public IActionResult ConfirmDelete(int id)
        {
            TempData["ReturnUrl"] = Request.Headers["Referer"].ToString();
            return View(reviewRepo.GetByID(id));
        }

        public IActionResult Delete(int id)
        {
            reviewRepo.Delete(reviewRepo.GetByID(id));
            return Redirect(TempData["ReturnUrl"].ToString());
        }
    }
}
