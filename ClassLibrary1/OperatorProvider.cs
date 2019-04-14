
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;




using System.Globalization;

using System.Security.Claims;

namespace Utility.Operator
{
     public interface IOperatorProvider {
         Operator Current { get; }
    }

    /// <summary>
    /// 用户登陆信息提供者。
    /// </summary>
    public class OperatorProvider: IOperatorProvider
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        /// <summary>
        /// Session/Cookie键。
        /// </summary>
        public OperatorProvider(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Operator Current
        {
            get
            {
                Operator operatorModel = new Operator();
                operatorModel.RealName=_httpContextAccessor.HttpContext.User.Identity.Name;
                return operatorModel;
            }
            
        }
    }

    /// <summary>
    /// 操作模型，保存登陆用户必要信息。
    /// </summary>
    public class Operator
    {
        public string UserId { get; set; }
        public string Account { get; set; }
        public string RealName { get; set; }
        public string Avatar { get; set; }
        public string Password { get; set; }
        public string CompanyId { get; set; }
        public string DepartmentId { get; set; }
        public List<string> RoleId { get; set; }
        public string Token { get; set; }
        public DateTime LoginTime { get; set; }
        public string ClientUrl { get; set; }
    }
}