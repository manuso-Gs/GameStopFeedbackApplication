using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStopFeedbackApplication.Models
{
    public class FeedbackModel
    {
        public byte LookingFor { get; set; }
        public byte ProductRange { get; set; }
        public byte CheckoutEasy { get; set; }
        public byte OverallExperience { get; set; }
        public string MostLiked { get; set; }
        public string MostDisliked { get; set; }
        public string MostLikeToSee { get; set; }


    }
}