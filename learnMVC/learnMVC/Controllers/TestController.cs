using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace learnMVC.Controllers
{
    public class TestController : Controller
    {
       public string GetString()
        {
            return "Hello World";
        }
    }
}