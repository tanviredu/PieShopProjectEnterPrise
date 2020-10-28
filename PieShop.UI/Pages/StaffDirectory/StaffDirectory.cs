using Microsoft.AspNetCore.Components;
using PieShop.Data;
using PieShop.Data.Implementation;
using PieShop.Models;
using PieShop.UI.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// remember this will be used as a component too
// so we need to inherit from the component base
namespace PieShop.UI.Pages.StaffDirectory
{
    public partial class StaffDirectory : ComponentBase
    {
        public List<Employee> Employees { get; set; }

        protected AddEmployeeDialog AddEmployeeDialog { get; set; }

        protected override void OnInitialized()
        {
            using (var _db = new AppDbContext()) {
                var er = new EmployeeRepository(_db);
                Employees = er.GetAllEmployees().ToList();
            
            }
        }
    }
}
