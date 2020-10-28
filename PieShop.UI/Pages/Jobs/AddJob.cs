using Microsoft.AspNetCore.Components;
using PieShop.Data;
using PieShop.Data.Implementation;
using PieShop.Models.Job;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.UI.Pages.Jobs
{
    public partial class AddJob :ComponentBase
    {
        [Inject]
        public NavigationManager navigationManager { get; set; }

        public Job Job { get; set; } = new Job();
        public string Message { get; set; }

        protected override void OnInitialized()
        {
        }

        protected void HandleValidSubmit() {
            using (var _db = new AppDbContext()) {
                var jr = new JobRepository(_db);
                var job = jr.AddJob(Job);

                if (job != null) {
                    var Job = new Job();
                    navigationManager.NavigateTo("/jobs");
                }
                
            }
            
        }
    }
}
