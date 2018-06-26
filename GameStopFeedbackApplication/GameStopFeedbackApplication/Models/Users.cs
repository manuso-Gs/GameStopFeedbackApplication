using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GameStopFeedbackApplication.Models
{
    public class Users
    {
        public int Id {get; set;}
        [Required]
        [StringLength(70)]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string EmailAddress { get; set; }
        [Required]
        public byte Age { get; set; }
        [Required]
        public string Gender { get; set; }

    }
}