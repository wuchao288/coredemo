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
        private readonly IOperatorProvider _httpContextAccessor;
        public UseRBLL(IOperatorProvider httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public  string testc()
        {
            Task.Run(() => {
                Thread.Sleep(5000);
            });
            return _httpContextAccessor.Current.RealName;
        }
    }
}
