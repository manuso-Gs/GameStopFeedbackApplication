using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameStopFeedbackApplication.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        [Required]
        public byte LookingFor { get; set; }
        [Required]
        public byte ProductRange { get; set; }
        [Required]
        public byte CheckoutEasy { get; set; }
        [Required]
        public byte OverallExperience { get; set; }
        [Required]
        public string MostLiked { get; set; }
        [Required]
        public string MostDisliked { get; set; }
        [Required]
        public string MostLikeToSee { get; set; }
        public Users User { get; set;}
        public int UserId { get; set; }

        public List<string> Value = new List<string> { "1", "2", "3", "4", "5" };

    }
}