using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        //GET: /<controller>/
        [HttpGet]
        

        public IActionResult Index()
        {
            //return View(); //commenting line to add string html Hello World! and return Content
            //string html = "<h1>Hello World!</h1>";  //commenting out for ch10 part 4: Forms
            string html = "<form method='post' action='/helloworld/'>" +
                "<input type='text' name='name' />" +
                "<input type='text' language='language' />" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";
            

            return Content(html, "text/html");
        }

        



        // GET /hello/welcome
        // [HttpGet]  //commenting out for ch10 part 4: Forms
        // [Route("/helloworld/welcome/{name?}")]  //commenting out for ch10 part 4: Forms
        [HttpGet("welcome/{name?}")]
        [HttpPost]

        public IActionResult Welcome(string name = "World")
        {
            return Content("<h1>Welcome to my app, " + name + language + "!</h1>", "text/html");
        }
    }
}
