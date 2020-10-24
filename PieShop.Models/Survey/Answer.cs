using System;
using System.Collections.Generic;
using System.Text;

namespace PieShop.Models
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string Response { get; set; }
        public double Rating { get; set; }
        

        // many to one relationship
        public int SurveyId { get; set; }
        public Survey Survey { get; set; }
    }
}
