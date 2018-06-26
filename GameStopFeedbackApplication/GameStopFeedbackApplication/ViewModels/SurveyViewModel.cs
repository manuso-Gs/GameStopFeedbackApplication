using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GameStopFeedbackApplication.Models;

namespace GameStopFeedbackApplication.ViewModels
{
    public class SurveyViewModel
    {
        public List<Users> Users { get; set; }
        public List<Feedback> Feedback { get; set; }
    }
}