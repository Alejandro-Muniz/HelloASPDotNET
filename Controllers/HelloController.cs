using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloASPDotNET.Controllers
{
    public class HelloController : Controller
    {
        //GET: /<controller>/
        [HttpGet]
        [Route("/helloworld/")]
        public IActionResult Index()
        {
            //return View(); //commenting line to add string html and return Content
            string html = "<h1>Hello World!</h1>";
            return Content(html, "text/html");
        }

        // GET /hello/welcome
        [HttpGet]
        [Route("/helloworld/welcome/{name?}")]
        public IActionResult Welcome(string name = "World")
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }
    }
}
