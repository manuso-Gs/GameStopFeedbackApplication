using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStopFeedbackApplication.Models
{
    public class Users
    {
        public int Id {get; set;}
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public byte Age { get; set; }
        public bool Gender { get; set; }

    }
}