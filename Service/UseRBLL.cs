using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Utility;
using Utility.Operator;

namespace Service
{
    public interface IUseRBLL
    {
        string testc();
    }
    public class UseRBLL: IUseRBLL
    {
        public IStringLocalizer _T { get; set; }

        private readonly IOperatorProvider _httpContextAccessor;
        //IOperatorProvider httpContextAccessor
        public UseRBLL(IOperatorProvider httpContextAccessor, IStringLocalizer<UseRBLL>  T)
        {
            _httpContextAccessor = httpContextAccessor;
            _T = T;
        }
        public  string testc()
        {
            //异步操作
            Task.Run(() =>
            {
                Thread.Sleep(5000);
            });
            return _httpContextAccessor.Current.RealName;
           
        }
    }
}
