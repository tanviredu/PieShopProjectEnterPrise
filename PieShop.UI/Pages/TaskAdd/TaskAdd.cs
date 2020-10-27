using Microsoft.AspNetCore.Components;
using PieShop.Data;
using PieShop.Data.Implementation;
using PieShop.Models;
using PieShop.Models.HRTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.UI.Pages.TaskAdd
{
    public partial class TaskAdd
    {
        public bool Saved { get; set; }
        public HRTask Task { get; set; } = new HRTask();
        public string Message { get; set; }
        protected string EmployeeId = "1";

        [Inject]
        public NavigationManager navManager { get; set; }

        public List<Employee> Employees { get; set; } = new List<Employee>();

        protected override void OnInitialized()
        {
            Saved = false;
            using (var _db = new AppDbContext()) {
                var er = new EmployeeRepository(_db);
                Employees = er.GetAllEmployees().ToList();
            }
        }

        protected void HandleValidSubmit() {
            // we add the employeeId with the 
            // Assignto variable
            // then add the task
            Task.AssignedTo = int.Parse(EmployeeId);
            using (var _db = new AppDbContext()) {
                var tr = new TaskRepository(_db);
                var result = tr.AddTask(Task);
                if (result != null)
                {
                    navManager.NavigateTo("/");
                }
                else
                {
                    Message = "Error is Occured";
                }
            }
            

        
        }
    }
}
