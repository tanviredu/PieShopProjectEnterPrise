using Microsoft.AspNetCore.Components;
using PieShop.Data;
using PieShop.Data.Implementation;
using PieShop.Models.HRTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.UI.Pages.TaskList
{
    public partial class TaskList :ComponentBase
    {
        [Parameter]
        public int Count { get; set; }

        [Inject]
        public NavigationManager navManager { get; set; }
        public List<HRTask>Tasks {get;set;} = new List<HRTask>();

        protected override void OnInitialized()
        {
            using (var _db = new AppDbContext()) {
                var tr = new TaskRepository(_db);
                Tasks = tr.GetAllTasks().ToList();
            }
            if (Count != 0) {
                // take a specfic ammount
                Tasks = Tasks.Take(Count).ToList();
            }
        }

        public void AddTask() {

            navManager.NavigateTo("/taskedit");
        }

    }


}
