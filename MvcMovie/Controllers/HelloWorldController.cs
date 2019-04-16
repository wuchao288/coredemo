using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Service;
using Model;
using Utility.Operator;
using Microsoft.Extensions.Logging;
using log4net;
using Blog.Core.Log;
using System;
using Microsoft.Extensions.Localization;


namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        private readonly IStringLocalizer<HelloWorldController> _localizer;

    

        // 
        // GET: /HelloWorld/
        private readonly IUseRBLL _UseRBLL;
        private readonly ILoggerHelper _log;
        public HelloWorldController(IUseRBLL UseRBLL, ILoggerHelper log,IStringLocalizer<HelloWorldController> localizer)
        {
            _UseRBLL = UseRBLL;
           _log = log;
            _localizer = localizer;
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
            ViewBag.data= _UseRBLL.testc() +
             _localizer["Hello world!"]; 
            return View();
        }
    }
}