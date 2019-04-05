using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Service;
using Model;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }


        public IActionResult List()
        {
            new MovieServer().GetDb().GetById(12);
            return View();
        }
       public  IActionResult Insert()
        {
            return View();
        }
    }
}