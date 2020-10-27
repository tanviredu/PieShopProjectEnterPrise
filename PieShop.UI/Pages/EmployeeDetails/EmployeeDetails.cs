using Microsoft.AspNetCore.Components;
using PieShop.Data;
using PieShop.Data.Implementation;
using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.UI.Pages.EmployeeDetails
{
    public partial class EmployeeDetails :ComponentBase
    {
        [Parameter]
        public string EmployeeId { get; set; }
        protected string JobCategory = string.Empty;
        public Employee employee { get; set; } = new Employee();

        protected override void OnInitialized()
        {
            using (var _db = new AppDbContext()) {
                var employeeRepository = new EmployeeRepository(_db);
                employee = employeeRepository.GetEmployeeById(int.Parse(EmployeeId));
            }
            using (var _db = new AppDbContext()) {
                var jobCategoryrepository = new JobCategoryRepository(_db);
                JobCategory = jobCategoryrepository.GetJobCategoryById(employee.JobCategoryId).JobCategoryName;

            }
                
            
        }
    }
}
