﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Model;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Login(string returnUrl = "")
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost, ActionName("Login")]
        public async Task<IActionResult> LoginPost(LoginViewModel model, string returnUrl = "")
        {
            ViewData["ReturnUrl"] = returnUrl;
            ValidationAttributeUtil.GetRequiredErrorMessage("姓名");
            if (ModelState.IsValid)
            {
                bool succee = (model.UserName == "admin") && (model.Password == "123");

                if (succee)
                {
                    //创建用户身份标识
                    var claimsIdentity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                    claimsIdentity.AddClaims(new List<Claim>()
                    {
                        new Claim(ClaimTypes.Sid, model.UserName),
                        new Claim(ClaimTypes.Name, model.UserName),
                        new Claim(ClaimTypes.Role, "admin"),
                        new Claim("LastUpdated", "admin")//当密码有改动时
                    });

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                    return Content("ok");
                }
                else
                {
                    ModelState.AddModelError("ValidError", "帐号或者密码错误。");
                    StringBuilder strBuild = new StringBuilder();
                    foreach (var item in ModelState.Values)
                    {
                        if (item.Errors.Count > 0)
                        {
                            int itemErrorCount = item.Errors.Count;
                            for (int i = 0; i < itemErrorCount; i++)
                            {
                                strBuild.Append(item.Errors[i].ErrorMessage);
                                strBuild.Append("<br/>");
                            }
                        }
                    }
                  
                    return Json(strBuild.ToString());
                }
            }

            return Json(ModelState);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return Redirect("/Home/Index");
        }
    }
}
