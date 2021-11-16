using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMVC.Models;
namespace DemoMVC.Controllers
{
    public class EmployeeController : Controller
    {
        static List<Employee> employeeList = null;
        public EmployeeController()
        {
            if (employeeList == null)
            {
                employeeList = new List<Employee>()
                {
                    new Employee() { Id = 1, Name = "Deepak", Department = "HR", Salary = 12000 },
                    new Employee() { Id = 2, Name = "jay", Department = "HR", Salary = 12000 },
                    new Employee() { Id = 3, Name = "Sagar", Department = "Accts", Salary = 12000 },
                    new Employee() { Id = 4, Name = "Deepak", Department = "HR", Salary = 12000 },
                    new Employee() { Id = 5, Name = "Deepak", Department = "Sales", Salary = 12000 }
                };
            }
        }
        // GET: Employee
        public ActionResult Index()
        {
            if (TempData["msg"] != null)
            {
                ViewBag.msg = TempData["msg"];
            }
            return View(employeeList.ToList());
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                ViewBag.msg = "Please provide id";
                return View();
            }
            else
            {
                var employee = employeeList.FirstOrDefault(x => x.Id == id);
                if (employee == null)
                {
                    ViewBag.msg = "record with this id not found";

                }
                return View(employee);
            }

        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            employeeList.Add(employee);
            // return View();
            TempData["msg"] = "Record is inserted";
            return RedirectToAction("Index");

        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                ViewBag.msg = "Please provide id";
                return View();
            }
            else
            {
                var employee = employeeList.FirstOrDefault(x => x.Id == id);
                if (employee == null)
                {
                    ViewBag.msg = "record with this id not found";
                    return View();
                }

                return View(employee);
            }
        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            var temp = employeeList.FirstOrDefault(x => x.Id == employee.Id);
            if (temp != null)
            {
                foreach (Employee emp in employeeList)
                {
                    if (emp.Id == temp.Id)
                    {
                        emp.Department = employee.Department;
                        emp.Salary = employee.Salary;
                        break;
                    }
                }
            }
            TempData["msg"] = "record is modified";
            return RedirectToAction("Index");


        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                ViewBag.msg = "Please provide id";
                return View();
            }
            else
            {
                var employee = employeeList.FirstOrDefault(x => x.Id == id);
                if (employee == null)
                {
                    ViewBag.msg = "record with this id not found";
                    return View();
                }

                return View(employee);
            }
        }
        [HttpPost]
        public ActionResult Delete(Employee emp)

        {
            var employee = employeeList.FirstOrDefault(x => x.Id == emp.Id);
            if(employee!=null)
            {
                employeeList.Remove(employee);
                TempData["msg"] = "record is deleted";
                
            }
            return RedirectToAction("Index");
        }
    }
}