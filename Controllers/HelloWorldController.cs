using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVC_July_project.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int numTImes = 1)

        {
            ViewData["Message"]= "Ahoj" + name;
            ViewData["NumTimes"]= numTImes;

            return View();
        }
        


    }
}