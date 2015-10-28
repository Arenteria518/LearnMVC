using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
            return View("myView", emp);
        }
    }

    

  

    


}