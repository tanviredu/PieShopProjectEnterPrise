using PieShop.Data;
using PieShop.Data.Implementation;
using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.UI.Pages.SurveyOverview
{
    public partial class SurveyOverview
    {
        public List<Survey> Surveys { get; set; } = new List<Survey>();

        protected override void OnInitialized()
        {
            using (var _db = new AppDbContext()) {
                var sr = new SurveyRepository(_db);
                Surveys = sr.GetAllSurveys().ToList();
                
            }
        }
    }
}
