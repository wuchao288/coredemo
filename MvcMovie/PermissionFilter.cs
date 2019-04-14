using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Claims;

namespace MvcMovie
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class PermissionFilter :Attribute, IAsyncAuthorizationFilter
    {
        public PermissionFilter(string name)
        {
            Name = name;
        }
        public PermissionFilter():base()
        {

        }
        public string Name { get; set; }

        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            bool form = context.HttpContext.User.Identity.IsAuthenticated;
            if (form==false)//认证已经过期
            {
                //如果是ajax
                if (context.HttpContext.Request.Headers["x-requested-with"] != "XMLHttpRequest") {

                    context.Result = new RedirectResult("/Login/Login");//如果过期了

                }
                else
                {
                    context.HttpContext.Response.StatusCode = 401;
                    context.Result = new JsonResult(new { msg = "222" });//如果过期了
                }
                return;
            }
            var authorizationService = context.HttpContext.RequestServices.GetRequiredService<IAuthorizationService>();
            var authorizationResult = await authorizationService.AuthorizeAsync(context.HttpContext.User, null, new PermissionAuthorizationRequirement(Name));
            if (!authorizationResult.Succeeded)
            {
                context.Result = new JsonResult(new { msg = "222" });
            }
        }
    }
    public class MyAuthorizationService : IAuthorizationService
    {
        public Task<AuthorizationResult> AuthorizeAsync(ClaimsPrincipal user, object resource, IEnumerable<IAuthorizationRequirement> requirements)
        {
           
            return Task.FromResult(AuthorizationResult.Success());
        }

        public Task<AuthorizationResult> AuthorizeAsync(ClaimsPrincipal user, object resource, string policyName)
        {
            return Task.FromResult(AuthorizationResult.Success());
        }
    }
}
