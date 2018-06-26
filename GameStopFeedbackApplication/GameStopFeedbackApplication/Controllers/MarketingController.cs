using GameStopFeedbackApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameStopFeedbackApplication.ViewModels;

namespace GameStopFeedbackApplication.Controllers
{
    public class MarketingController : Controller
    {

        private ApplicationDbContext _context;

        public MarketingController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Marketing
        public ActionResult Report()
        {

            var users = _context.Users.ToList();
            var feedback = _context.Feedback.ToList();

            // Average user age
            var avgU = users.Average(u => u.Age);

            // Average of four scales
            var avgLookingFor = feedback.Average(f => f.LookingFor);
            var avgRange = feedback.Average(f => f.ProductRange);
            var avgCheckoutEasy = feedback.Average(f => f.CheckoutEasy);
            var avgOverallExp = feedback.Average(f => f.OverallExperience);

            // Gender distribution
            var male = users.Count(u => u.Gender == "Male");
            var female = users.Count(u => u.Gender == "Female");


            var result = new Report
            {
                AvgUserAge = avgU,
                AvgLookingFor =avgLookingFor,
                AvgCheckoutEasy = avgCheckoutEasy,
                AvgOverallExp = avgOverallExp,
                AvgRange = avgRange,
                Male = male,
                Female = female
            };

            return View(result);
        }

        public ActionResult Responses()
        {
            var list = _context.Feedback.ToList();

            return View(list);
        }
    }
}