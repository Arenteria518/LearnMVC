using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using learnMVC.ViewModels;
using learnMVC.Models;


namespace learnMVC.Controllers
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return this.CustomerName + "|" + this.Address;
        }

       
    }
    public class TestController : Controller
    {
        public Customer getCustomer()
        {
            Customer c = new Customer();
            c.CustomerName = "Customer 1";
            c.Address = "Address1";
            return c;
        }

        public ActionResult getView()
        {
            Employee emp = new Employee();
            emp.FirstName = "Anthony";
            emp.LastName = "Renteria";
            emp.Salary = 100000;

            EmployeeViewModel vmEmp = new EmployeeViewModel();
            vmEmp.EmployeeName = emp.FirstName + " " + emp.LastName;
            vmEmp.Salary = emp.Salary.ToString("C");
            if(emp.Salary > 1500)
            {
                vmEmp.SalaryColor = "yellow";
            }
            else
            {
                vmEmp.SalaryColor = "green";
            }

            vmEmp.UserName = "Admin";

            return View("myView", vmEmp);
        }
    }

    

  

    


}