using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PieShop.Data;
using PieShop.Models;
using PieShop.UI.Components;
using Microsoft.AspNetCore.Components;
using PieShop.Data.Implementation;

namespace PieShop.UI.Pages.EmployeeOverview
{
    public partial class EmployeeOverview : ComponentBase
    {


        public EmployeeRepository employeeRepository;

        
        public List<Employee> Employees { get; set; }
        protected AddEmployeeDialog AddEmployeeDialog { get; set; }

        protected override void OnInitialized()
        {
            var _db = new AppDbContext();
            employeeRepository = new EmployeeRepository(_db);
            Employees = employeeRepository.GetAllEmployees().ToList();
            
           
        }

        protected void QuickAddEmployee() {

            AddEmployeeDialog.Show();
            
        }

        /* NOW WHEN THE DIALOG WILL BE CLOSED WE NEED TO
           REFRESH THE PAGE WITH THE NEW lIST
           SO WE FETCH THE LIST AGAIN WHEN THE DIALOG IS CLOSED
         */

        public  void AddEmployeeDialog_OnDialogClose() {
            // when this dialog is closed refresh the data
            Employees =  employeeRepository.GetAllEmployees().ToList();
        
        }

    }
}
