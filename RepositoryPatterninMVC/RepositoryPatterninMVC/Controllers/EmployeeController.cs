using RepositoryPatterninMVC.Models;
using RepositoryPatterninMVC.Repository.Contract;
using RepositoryPatterninMVC.Repository.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RepositoryPatterninMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        private readonly IEmployee _employee;
        public EmployeeController()
        {
            this._employee = new EmployeeService(new EmployeeDbContext());
        }
        public ActionResult Index()
        {
            var employee=_employee.getEmployees();
            return View(employee);
        }
    }
}






