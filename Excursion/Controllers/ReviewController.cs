using Excursion.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Excursion.Controllers
{
    public class ReviewController : Controller
    {
        private ApplicationContext _context;
        public ReviewController(ApplicationContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            List<Review> reviews = _context.Reviews.ToList();
            return View(reviews);
        }
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Review review)
        {
            Review newReview = new Review { ParticipantName = review.ParticipantName, ParticipantReview = review.ParticipantReview, ReviewTime = DateTime.Now };
            _context.Reviews.Add(newReview);
            await _context.SaveChangesAsync();

            //await Authenticate(user); // аутентифікация

            return RedirectToAction("Index");

        }
      
    }
}
