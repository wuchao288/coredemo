using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Service;
using Model;
using Utility.Operator;
using Microsoft.Extensions.Logging;
using log4net;
using Blog.Core.Log;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/
        private readonly IUseRBLL _UseRBLL;
        private readonly ILoggerHelper _log;
        public HelloWorldController(IUseRBLL UseRBLL, ILoggerHelper log)
        {
            _UseRBLL = UseRBLL;
            _log = log;
        }
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
            _log.Info(typeof(HelloWorldController), "33333");
            ViewBag.data= _UseRBLL.testc();
            return View();
        }
    }
}