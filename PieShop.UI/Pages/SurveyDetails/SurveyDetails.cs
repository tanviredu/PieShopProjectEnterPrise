using Microsoft.AspNetCore.Components;
using PieShop.Data;
using PieShop.Data.Implementation;
using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.UI.Pages.SurveyDetails
{
    public partial class SurveyDetails
    {
        [Parameter]
        public string SurveyId { get; set; }
        public double AverageRating { get; set; }
        public double LowestRating { get; set; }
        public double HighestRating { get; set; }
        public double Count { get; set; }

        // now init the survey  with the Answer List
        // each survey has an answer list
        // you can init it by Survey.Answers = new List<Answer>
        // or just like the bellow
        // 
        public Survey Survey { get; set; } = new Survey() { Answers = new List<Answer>() };

        protected override void OnInitialized()
        {
            using (var _db = new AppDbContext()) {
                var sr = new SurveyRepository(_db);
                Survey = sr.GetServeyById(int.Parse(SurveyId));

                // check if it has any answers
                if (Survey.Answers == null) {

                    // init it again
                    Survey.Answers = new List<Answer>();
                }
                if (Survey.Answers.Count > 0) {
                    AverageRating = Survey.Answers.Select(x => x.Rating).Sum() / Survey.Answers.Count;

                    HighestRating = Survey.Answers.OrderByDescending(x => x.Rating).FirstOrDefault().Rating;

                    LowestRating = Survey.Answers.OrderBy(x => x.Rating).FirstOrDefault().Rating;

                    Count = Survey.Answers.Count;
                }
            }
        }
    }

}
