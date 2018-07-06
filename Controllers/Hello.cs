using System;
using Microsoft.AspNetCore.Mvc;
namespace example.Controllers     //be sure to use your own project's namespace!
{
    public class Hello : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)The [Route] decorator accepts a string argument that represents the route string associated with a given method. For example, [Route("index")] matches the URL localhost:5000/index. They do NOT have leading slashes.
        public IActionResult Index()
        {
            //return View();
            //or
             DateTime CurrentTime = DateTime.Now;
            ViewBag.Example = CurrentTime.ToString("MMMM dd, yyyy H:mm:ss");
            return View("Index");
            //Both of these returns render same view, only one is needed
        }
    }
}