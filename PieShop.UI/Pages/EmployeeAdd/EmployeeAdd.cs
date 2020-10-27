using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using PieShop.Data;
using PieShop.Data.Implementation;
using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.UI.Pages.EmployeeAdd
{
    public partial class EmployeeAdd 
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public string EmployeeId { get; set; }
        public InputText LastNameInputText { get; set; }
        public Employee Employee { get; set; } = new Employee();


        // initial value is set
        protected string CountryId = string.Empty;
        protected string JobCategoryId = string.Empty;

        // store the state of the screen
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved;

        /* there are two option input so we need two list*/
        public List<Country> Countries { get; set; } = new List<Country>();
        public List<JobCategory> JobCategories { get; set; } = new List<JobCategory>();

        protected override void OnInitialized()
        {
            Saved = false;
            using (var _db = new AppDbContext())
            {
                var cr = new CountryRepository(_db);
                Countries = cr.GetAllCountries().ToList();
            }

            using (var _db = new AppDbContext())
            {

                var jr = new JobCategoryRepository(_db);
                JobCategories = jr.GetAllJobCategories().ToList();

            }
            int.TryParse(EmployeeId, out var employeeId);
            if (employeeId == 0)
            {
                // EmployeeId ==0 means it is new not yet exist  
                // can use null because its in variable
                // and the 0 means false
                //add some defaults
                Employee = new Employee { CountryId = 1, JobCategoryId = 1, BirthDate = DateTime.Now, JoinedDate = DateTime.Now };
                CountryId = Employee.CountryId.ToString();
                JobCategoryId = Employee.JobCategoryId.ToString();


            }
        }

        protected void HandleValidSubmit()
        {

            Employee.CountryId = int.Parse(CountryId);
            Employee.JobCategoryId = int.Parse(JobCategoryId);

            using (var _db = new AppDbContext())
            {

                var er = new EmployeeRepository(_db);
                er.AddEmployee(Employee);
                StatusClass = "alert-success";
                Message = "Successfully Saved";
                Saved = true;

            }

        }
        protected void HandleInvalidSubmit()
        {
            StatusClass = "alert-danger";
            Message = "There are Some Validation Error";
        }

        protected void NavigateToOverview()
        {
            NavigationManager.NavigateTo("/employeeoverview");
        }

        protected void DeleteEmployee()
        {
            using (var _db = new AppDbContext())
            {

                var er = new EmployeeRepository(_db);
                er.DeleteEmployee(Employee.EmployeeId);
                StatusClass = "alert-success";
                Message = "Successfully Deleted";
                Saved = true;

            }
        }


    }
}
