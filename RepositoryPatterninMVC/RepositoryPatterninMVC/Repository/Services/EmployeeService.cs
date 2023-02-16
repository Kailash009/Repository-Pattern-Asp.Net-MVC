using RepositoryPatterninMVC.Models;
using RepositoryPatterninMVC.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryPatterninMVC.Repository.Services
{
    public class EmployeeService : IEmployee
    {
        EmployeeDbContext _dataContext;
        public EmployeeService(EmployeeDbContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Employee> getEmployees()
        {
            return _dataContext.Employees.ToList();
        }
        public Employee getSingleEmployee(int id)
        {
            throw new NotImplementedException();
        }
        public Employee AddEmploye(Employee empObj)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }
        public Employee UpdateEmployee(Employee empObj)
        {
            throw new NotImplementedException();
        }
    }
}