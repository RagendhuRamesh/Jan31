using Jan31.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jan31.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        static List<Employee> employees = new List<Employee>()
       {
           new Employee{Id=1,Name="Sam",Designation="Manager",Salary=98000,DOJ=new DateTime(day:23,month:11,year:2019)},
           new Employee{Id=2,Name="Arsh",Designation="Manager",Salary=98000,DOJ=new DateTime(day:29,month:11,year:2018)},
           new Employee{Id=3,Name="Ritu",Designation="Developer",Salary=78000,DOJ=new DateTime(day:28,month:11,year:2022)},
           new Employee{Id=4,Name="Vini",Designation="Tester",Salary=54000,DOJ=new DateTime(day:30,month:11,year:2022)},
           new Employee{Id=5,Name="Gaurav",Designation="Developer",Salary=38000,DOJ=new DateTime(day:03,month:11,year:2020)},
           new Employee{Id=6,Name="Aki",Designation="Developer",Salary=48000,DOJ=new DateTime(day:25,month:11,year:2022)},
           new Employee{Id=7,Name="Vik",Designation="HR",Salary=68000,DOJ=new DateTime(day:02,month:11,year:2023)},
           new Employee{Id=10,Name="Simi",Designation="Developer",Salary=76000,DOJ=new DateTime(day:25,month:11,year:2019)},
       };
        public ActionResult Index()
        {
            return View(employees);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Employee());
        }
        [HttpPost]
        public ActionResult Create(Employee emp) 
        {
            if(ModelState.IsValid) 
            {
                employees.Add(emp);
                return RedirectToAction("Index");
            }
            return View(emp);
        }
    }
}