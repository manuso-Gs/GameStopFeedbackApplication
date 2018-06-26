using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameStopFeedbackApplication.Models;
using GameStopFeedbackApplication.ViewModels;

namespace GameStopFeedbackApplication.Controllers
{
    public class SurveyController : Controller
    {
        private ApplicationDbContext _context;

        public SurveyController()
        {
            _context = new ApplicationDbContext();
        }
        
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        
        // GET: Survey
        public ActionResult Index()
        {
            var questions = new Feedback();
            return View(questions);
        }

        [HttpPost]
        public ActionResult Submit(Feedback questions)
        {

            if (!ModelState.IsValid)
            {
                var view = questions;

                return View("Index", view);
            }
            else
            { 
                _context.Feedback.Add(questions);
                _context.SaveChanges();
                return View("ThankYou");
            }
        }

    }
}