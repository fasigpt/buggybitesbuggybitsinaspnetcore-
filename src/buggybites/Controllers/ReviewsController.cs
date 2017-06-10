using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace buggybites.Controllers
{
    public class ReviewsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {

            Review rev = new Review();
            rev.GenerateReview1();
            //rev.ClearReview();

            Review rev2 = new Review();
            rev2.GenerateReview2();
           
            //rev2.ClearReview();

            ReviewModel model = new ReviewModel();
            model.review = new List<Review>();
            model.review.Add(rev);
            model.review.Add(rev2);

            //rev.ClearReview();
            //rev2.ClearReview();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(string button)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            Review rev = new Review();
            rev.GenerateReview1();
           

            Review rev2 = new Review();
            rev2.GenerateReview2();


            ReviewModel model = new ReviewModel();
            model.review = new List<Review>();
            model.review.Add(rev);
            model.review.Add(rev2);

            //rev.ClearReview();
            //rev2.ClearReview();
            return View(model);


            
        }
    }
}
