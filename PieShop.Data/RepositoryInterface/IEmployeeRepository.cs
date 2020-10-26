using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PieShop.Data.RepositoryInterface
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int employeeId);
        Employee AddEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
        void DeleteEmployee(int employeeId);
    }
}
