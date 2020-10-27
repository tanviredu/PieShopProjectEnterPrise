using Microsoft.AspNetCore.Components;
using PieShop.Data;
using PieShop.Data.Implementation;
using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.UI.Pages.SurveyEdit
{
    public partial class SurveyEdit
    {

        public bool Saved { get; set; } = false;
        public Survey Survey { get; set; } = new Survey();
        public string Message { get; set; }
        
        [Inject]
        NavigationManager navManager { get; set; }
        
              
         protected void HandleValidSubmit() {

            using (var _db = new AppDbContext()) {
                var sr = new SurveyRepository(_db);
                var result = sr.AddSurvey(Survey);
                if(result != null)
                {
                    navManager.NavigateTo("/surveys");
                }
                else
                {
                    Message = "An error has occured";

                }
                
            
            }
        }

    }
}
