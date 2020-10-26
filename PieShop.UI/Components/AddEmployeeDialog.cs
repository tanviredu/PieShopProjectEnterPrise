using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PieShop.Models;
using PieShop.Data;
using Microsoft.AspNetCore.Components;
using PieShop.Data.Implementation;



/*
 * THIS IS A COMPONENT SO WE NEED TO IMPORT
 * THE COMPONENT BASE FROM ASP.NET CORE
 * AND THERE WILL BE NO URL ONLY RHE UI CODE
 * AND THE LOGIC CODE IN A PARTIAL CLASS
 *  WE USE A FUNCTION NAME StatehasChanged()
 *  THAT WILL RESET THE STATE 
 */

namespace PieShop.UI.Components
{
    public partial class AddEmployeeDialog:ComponentBase
    {
        public EmployeeRepository employeeRepository;
        public Employee Employee { get; set; }
        public bool ShowDialog { get; set; }
        private void ResetDialog()
        {
            // this method give a default data 
            // when the state has changed in add Employee component

            Employee = new Employee { 
                CountryId = 1,
                JobCategoryId = 1,
                BirthDate = DateTime.Now,
                JoinedDate = DateTime.Now 
            };

        }
        public void Close() {
            // when user close the dialog
            ShowDialog = false;
            StateHasChanged(); // this is a default function
        }

        public void Show() {

            ResetDialog();
            ShowDialog = true;
            StateHasChanged();
            
        }

        protected void HandleValidSubmit() {
            employeeRepository.AddEmployee(Employee);
            ShowDialog = false;
            
        }


    }

    

}
