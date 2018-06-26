using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStopFeedbackApplication.Models
{
    public class Report
    {

        public double AvgUserAge { get; set; }
        public double AvgLookingFor { get; set; }
        public double AvgRange { get; set; }
        public double AvgCheckoutEasy { get; set; }
        public double AvgOverallExp { get; set; }
        public int Male { get; set; }
        public int Female { get; set; }

    }
}