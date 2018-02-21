using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project.Models
{
    public class Feedback1
    {
        public int feedback_id { get; set; }
        public int qn_id { get; set; }
        public int substaffmap_id { get; set; }
        public string stud_id { get; set; }
        public string choice { get; set; }
    }
}