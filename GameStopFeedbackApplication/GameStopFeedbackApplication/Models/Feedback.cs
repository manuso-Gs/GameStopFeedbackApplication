using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStopFeedbackApplication.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public byte LookingFor { get; set; }
        public byte ProductRange { get; set; }
        public byte CheckoutEasy { get; set; }
        public byte OverallExperience { get; set; }
        public string MostLiked { get; set; }
        public string MostDisliked { get; set; }
        public string MostLikeToSee { get; set; }
        public Users User { get; set;}
        public int UserId { get; set; }

        public List<string> Value = new List<string> { "1", "2", "3", "4", "5" };

    }
}