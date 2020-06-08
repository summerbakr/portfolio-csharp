using Microsoft.AspNetCore.Mvc;
using System;
    namespace Portfolio.Controllers     //be sure to use your own project's namespace!
    {
        public class HomeController : Controller   //remember inheritance??
        {
            //for each route this controller is to handle:
            [HttpGet]       //type of request
            [Route("")]     //associated route string (exclude the leading /)
            public ViewResult Index()
            {
                return View();
            }
            
            [HttpGet]       //type of request
            [Route("project")]     //associated route string (exclude the leading /)
            public ViewResult Project()
            {
                return View("Project");
            }

            [HttpGet]       //type of request
            [Route("contacts")]     //associated route string (exclude the leading /)
            public ViewResult Contact()
            {
                return View();
            }

            [HttpPost]       //type of request
            [Route("submit")]     //associated route string (exclude the leading /)
            public IActionResult Submit(string Name, string Email, string Message)
            {
                Console.WriteLine($"Name: {Name}, Email: {Email}, Message: {Message}");
                ViewBag.Name=Name;
                ViewBag.Email=Email;
                ViewBag.Message=Message;
                return View();
            }

        }
    }