using RepositoryPatterninMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatterninMVC.Repository.Contract
{
    public interface IEmployee
    {
         List<Employee> getEmployees();
         Employee AddEmploye(Employee empObj);
         Employee getSingleEmployee(int id);
         Employee UpdateEmployee(Employee empObj);
         bool DeleteEmployee(int id);
    }
}
