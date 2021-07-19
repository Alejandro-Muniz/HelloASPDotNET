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
        [HttpGet]  //commenting out for ch10 part 4: Forms
        [Route("/helloworld/")]  //commenting out for ch10 part 4: Forms
        public IActionResult Index()
        {
            //return View(); //commenting line to add string html Hello World! and return Content
            //string html = "<h1>Hello World!</h1>";  //commenting out for ch10 part 4: Forms
            string html = "<form method='post' action='/helloworld/'>" +
                "<input type='text' name='name' />" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";

            return Content(html, "text/html");
        }

        // GET /hello/welcome
        //[HttpGet]  //commenting out for ch10 part 4: Forms
        //[Route("/helloworld/welcome/{name?}")]  //commenting out for ch10 part 4: Forms
        [HttpPost]
        [Route("helloworld/")]
        public IActionResult Welcome(string name = "World")
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }
    }
}
