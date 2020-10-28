using Microsoft.AspNetCore.Components;
using PieShop.Data;
using PieShop.Data.Implementation;
using PieShop.Models;
using PieShop.Models.Job;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.UI.Pages.Jobs
{
    // this will be a component too
    public partial class JobOverview : ComponentBase
    {
        public List<Job> Jobs { get; set; }

        protected override void OnInitialized()
        {
            using (var _db = new AppDbContext()) {
                var jr = new JobRepository(_db);
                Jobs = jr.GetAllJob().ToList();
                
            }
        }

    }
}
