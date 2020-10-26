using PieShop.Data.RepositoryInterface;
using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace PieShop.Data.Implementation
{
    public class EmployeeRepository : IEmployeeRepository
    {


        public readonly AppDbContext _appDbContext;

        public EmployeeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Employee AddEmployee(Employee employee)
        {
            var _addEmtity = _appDbContext.Employees.Add(employee);
            _appDbContext.SaveChanges();
            return _addEmtity.Entity;
        }

        public void DeleteEmployee(int employeeId)
        {
            var foundEmployee = _appDbContext.Employees.FirstOrDefault(e => e.EmployeeId == employeeId);
            if (foundEmployee == null) { return; }
            _appDbContext.Employees.Remove(foundEmployee);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _appDbContext.Employees.Select(e => e).ToList();
        }

        public Employee GetEmployeeById(int employeeId)
        {
            return _appDbContext.Employees.FirstOrDefault(e => e.EmployeeId == employeeId);
        }

        public Employee UpdateEmployee(Employee employee)
        {
            var foundEmployee = _appDbContext.Employees.FirstOrDefault(e => e.EmployeeId == employee.EmployeeId);
            if (foundEmployee != null) {
                foundEmployee.CountryId = employee.CountryId;
                foundEmployee.MaritalStatus = employee.MaritalStatus;
                foundEmployee.BirthDate = employee.BirthDate;
                foundEmployee.City = employee.City;
                foundEmployee.Email = employee.Email;
                foundEmployee.FirstName = employee.FirstName;
                foundEmployee.LastName = employee.LastName;
                foundEmployee.Gender = employee.Gender;
                foundEmployee.PhoneNumber = employee.PhoneNumber;
                foundEmployee.Smoker = employee.Smoker;
                foundEmployee.Street = employee.Street;
                foundEmployee.Zip = employee.Zip;
                foundEmployee.JobCategoryId = employee.JobCategoryId;
                foundEmployee.Comment = employee.Comment;
                foundEmployee.ExitDate = employee.ExitDate;
                foundEmployee.JoinedDate = employee.JoinedDate;

                _appDbContext.SaveChanges();
                return foundEmployee;

            }
            return null;
        }
    }
}
