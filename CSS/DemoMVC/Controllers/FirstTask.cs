using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers

{
    public class HelloWorldController : Controller
    { 
        // GET: /HelloWorld/
        public string Index()
        {
            return "This is my default action...";
        } 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
