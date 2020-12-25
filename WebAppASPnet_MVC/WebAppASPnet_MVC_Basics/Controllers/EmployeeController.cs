using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppASPnet_MVC_Basics.Models;

namespace WebAppASPnet_MVC_Basics.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee

        public ActionResult Index()
        {
            List<Employee> listemp = new List<Employee> {
                new Employee() { EmployeeId = 1234,FirstName = "Mary",LastName = "Browm" , Email= "Mary@yahoo.ca"},
                new Employee(){EmployeeId = 1235,FirstName = "john",LastName = "Browm" , Email= "john@yahoo.ca"},
                new Employee(){EmployeeId = 1236,FirstName = "Marie",LastName = "Tremblay" , Email= "marie@yahoo.ca"},
                new Employee(){EmployeeId = 1237,FirstName = "Julie",LastName = "junfung" , Email= "julie@yahoo.ca"},
                new Employee(){EmployeeId = 1238,FirstName = "Thomas",LastName = "moore" , Email= "thomas@yahoo.ca"},

            };
            return View(listemp);
        }
    }
}