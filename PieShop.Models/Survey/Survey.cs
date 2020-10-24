using System;
using System.Collections.Generic;
using System.Text;

namespace PieShop.Models
{
    public class Survey
    {
        public int SurveyId { get; set; }
        public String Title { get; set; }
        public string Description { get; set; }

        // one to many relation
        public List<Answer> Answers { get; set; }
    }
}
