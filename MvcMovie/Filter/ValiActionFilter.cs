using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Filter
{
    public class ValiActionFilter: IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                XcHttpResult result = new XcHttpResult() { Result = false };

                foreach (var item in context.ModelState.Values)
                {
                    foreach (var error in item.Errors)
                    {
                        result.Msg += error.ErrorMessage + "|";
                    }
                }

                context.Result = new JsonResult(result);
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {

        }
    }

    public class XcHttpResult
    {
        public string Msg { get; set; }
        public bool Result { get; set; }
    }
}
