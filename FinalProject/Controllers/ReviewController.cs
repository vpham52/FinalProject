using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinalProject.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IReviewRepository repo;

        public ReviewController(IReviewRepository repo)
        {
            this.repo = repo;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var reviews = repo.GetAllReviews();
            return View(reviews);
        }

        public IActionResult ViewProperty(int reviewID)
        {
            var review = repo.GetSingleReview(reviewID);
            return View(review);
        }

        public IActionResult Search(string searchString)
        {
            var searchResults = repo.SearchReviews(searchString);
            return View(searchResults); 
        }

     
    }
}

