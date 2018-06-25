using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GameStopFeedbackApplication.Models;

namespace GameStopFeedbackApplication.ViewModels
{
    public class SurveyViewModel
    {
        public Users User { get; set; }
        public Feedback Feedback { get; set; }
    }
}