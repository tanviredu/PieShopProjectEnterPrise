using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PieShop.Models;
using PieShop.Data;
using Microsoft.AspNetCore.Components;
using PieShop.Data.Implementation;

namespace PieShop.UI.Components
{
    public partial class NewEmployeesWidget : ComponentBase
    {

        public EmployeeRepository employeeRepository;
        public List<Employee> NewEmployees { get; set; } = new List<Employee>();


        protected override void OnInitialized()
        {
            NewEmployees = employeeRepository.GetAllEmployees().OrderBy(x => x.JoinedDate).Take(3).ToList();

        }
    }
}
