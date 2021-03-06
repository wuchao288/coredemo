﻿using log4net;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Core.Log
{
    /// <summary>

        /// <summary>
        /// 日志接口
        /// </summary>
        public interface ILoggerHelper
        {

            /// <summary>
            /// 调试信息
            /// </summary>
            /// <param name="source">source</param>
            /// <param name="message">message</param>
            void Debug(object source, string message);
            /// <summary>
            /// 调试信息
            /// </summary>
            /// <param name="source">source</param>
            /// <param name="message">message</param>
            /// <param name="ps">ps</param>
            void Debug(object source, string message, params object[] ps);
            /// <summary>
            /// 调试信息
            /// </summary>
            /// <param name="source">source</param>
            /// <param name="message">message</param>
            void Debug(Type source, string message);
            /// <summary>
            /// 关键信息
            /// </summary>
            /// <param name="source">source</param>
            /// <param name="message">message</param>
            void Info(object source, object message);
            /// <summary>
            /// 关键信息
            /// </summary>
            /// <param name="source">source</param>
            /// <param name="message">message</param>
            void Info(Type source, object message);
            /// <summary>
            /// 警告信息
            /// </summary>
            /// <param name="source">source</param>
            /// <param name="message">message</param>
            void Warn(object source, object message);
            /// <summary>
            /// 警告信息
            /// </summary>
            /// <param name="source">source</param>
            /// <param name="message">message</param>
            void Warn(Type source, object message);
            /// <summary>
            /// 错误信息
            /// </summary>
            /// <param name="source">source</param>
            /// <param name="message">message</param>
            void Error(object source, object message);
            /// <summary>
            /// 错误信息
            /// </summary>
            /// <param name="source">source</param>
            /// <param name="message">message</param>
            void Error(Type source, object message);
            /// <summary>
            /// 失败信息
            /// </summary>
            /// <param name="source">source</param>
            /// <param name="message">message</param>
            void Fatal(object source, object message);
            /// <summary>
            /// 失败信息
            /// </summary>
            /// <param name="source">source</param>
            /// <param name="message">message</param>
            void Fatal(Type source, object message);

            /* Log a message object and exception */

            /// <summary>
            /// 调试信息
            /// </summary>
            /// <param name="source">source</param>
            /// <param name="message">message</param>
            /// <param name="exception">ex</param>
            void Debug(object source, object message, Exception exception);
            /// <summary>
            /// 调试信息
            /// </summary>
            /// <param name="source">source</param>
            /// <param name="message">message</param>
            /// <param name="exception">ex</param>
            void Debug(Type source, object message, Exception exception);
            /// <summary>
            /// 关键信息
            /// </summary>
            /// <param name="source">source</param>
            /// <param name="message">message</param>
            /// <param name="exception">ex</param>
            void Info(object source, object message, Exception exception);
            /// <summary>
            /// 关键信息
            /// </summary>
            /// <param name="source">source</param>
            /// <param name="message">message</param>
            /// <param name="exception">ex</param>
            void Info(Type source, object message, Exception exception);
            /// <summary>
            /// 警告信息
            /// </summary>
            /// <param name="source">source</param>
            /// <param name="message">message</param>
            /// <param name="exception">ex</param>
            void Warn(object source, object message, Exception exception);
            /// <summary>
            /// 警告信息
            /// </summary>
            /// <param name="source">source</param>
            /// <param name="message">message</param>
            /// <param name="exception">ex</param>
            void Warn(Type source, object message, Exception exception);
            /// <summary>
            /// 错误信息
            /// </summary>
            /// <param name="source">source</param>
            /// <param name="message">message</param>
            /// <param name="exception">ex</param>
            void Error(object source, object message, Exception exception);
            /// <summary>
            /// 错误信息
            /// </summary>
            /// <param name="source">source</param>
            /// <param name="message">message</param>
            /// <param name="exception">ex</param>
            void Error(Type source, object message, Exception exception);
            /// <summary>
            /// 失败信息
            /// </summary>
            /// <param name="source">source</param>
            /// <param name="message">message</param>
            /// <param name="exception">ex</param>
            void Fatal(object source, object message, Exception exception);
            /// <summary>
            /// 失败信息
            /// </summary>
            /// <param name="source">source</param>
            /// <param name="message">message</param>
            /// <param name="exception">ex</param>
            void Fatal(Type source, object message, Exception exception);
        

    }
    /// </summary>
    public class LogHelper : ILoggerHelper
    {
        private readonly ConcurrentDictionary<Type, ILog> Loggers = new ConcurrentDictionary<Type, ILog>();

        /// <summary>
        /// 获取记录器
        /// </summary>
        /// <param name="source">soruce</param>
        /// <returns></returns>
        private ILog GetLogger(Type source)
        {
            if (Loggers.ContainsKey(source))
            {
                return Loggers[source];
            }
            else
            {
                ILog logger = LogManager.GetLogger("Blog.Core", source);
                Loggers.TryAdd(source, logger);
                return logger;
            }
        }

        /* Log a message object */

        /// <summary>
        /// 调试信息
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="message">message</param>
        public void Debug(object source, string message)
        {
            Debug(source.GetType(), message);
        }

        /// <summary>
        /// 调试信息
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="message">message</param>
        /// <param name="ps">ps</param>
        public void Debug(object source, string message, params object[] ps)
        {
            Debug(source.GetType(), string.Format(message, ps));
        }

        /// <summary>
        /// 调试信息
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="message">message</param>
        public void Debug(Type source, string message)
        {
            ILog logger = GetLogger(source);
            if (logger.IsDebugEnabled)
            {
                logger.Debug(message);
            }
        }

        /// <summary>
        /// 关键信息
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="message">message</param>
        public void Info(object source, object message)
        {
            Info(source.GetType(), message);
        }

        /// <summary>
        /// 关键信息
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="message">message</param>
        public void Info(Type source, object message)
        {
            ILog logger = GetLogger(source);
            if (logger.IsInfoEnabled)
            {
                logger.Info(message);
            }
        }

        /// <summary>
        /// 警告信息
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="message">message</param>
        public void Warn(object source, object message)
        {
            Warn(source.GetType(), message);
        }

        /// <summary>
        /// 警告信息
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="message">message</param>
        public void Warn(Type source, object message)
        {
            ILog logger = GetLogger(source);
            if (logger.IsWarnEnabled)
            {
                logger.Warn(message);
            }
        }

        /// <summary>
        /// 错误信息
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="message">message</param>
        public void Error(object source, object message)
        {
            Error(source.GetType(), message);
        }

        /// <summary>
        /// 错误信息
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="message">message</param>
        public void Error(Type source, object message)
        {
            ILog logger = GetLogger(source);
            if (logger.IsErrorEnabled)
            {
                logger.Error(message);
            }
        }

        /// <summary>
        /// 失败信息
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="message">message</param>
        public void Fatal(object source, object message)
        {
            Fatal(source.GetType(), message);
        }

        /// <summary>
        /// 失败信息
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="message">message</param>
        public void Fatal(Type source, object message)
        {
            ILog logger = GetLogger(source);
            if (logger.IsFatalEnabled)
            {
                logger.Fatal(message);
            }
        }

        /* Log a message object and exception */

        /// <summary>
        /// 调试信息
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="message">message</param>
        /// <param name="exception">ex</param>
        public void Debug(object source, object message, Exception exception)
        {
            Debug(source.GetType(), message, exception);
        }

        /// <summary>
        /// 调试信息
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="message">message</param>
        /// <param name="exception">ex</param>
        public void Debug(Type source, object message, Exception exception)
        {
            GetLogger(source).Debug(message, exception);
        }

        /// <summary>
        /// 关键信息
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="message">message</param>
        /// <param name="exception">ex</param>
        public void Info(object source, object message, Exception exception)
        {
            Info(source.GetType(), message, exception);
        }

        /// <summary>
        /// 关键信息
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="message">message</param>
        /// <param name="exception">ex</param>
        public void Info(Type source, object message, Exception exception)
        {
            GetLogger(source).Info(message, exception);
        }

        /// <summary>
        /// 警告信息
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="message">message</param>
        /// <param name="exception">ex</param>
        public void Warn(object source, object message, Exception exception)
        {
            Warn(source.GetType(), message, exception);
        }

        /// <summary>
        /// 警告信息
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="message">message</param>
        /// <param name="exception">ex</param>
        public void Warn(Type source, object message, Exception exception)
        {
            GetLogger(source).Warn(message, exception);
        }

        /// <summary>
        /// 错误信息
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="message">message</param>
        /// <param name="exception">ex</param>
        public void Error(object source, object message, Exception exception)
        {
            Error(source.GetType(), message, exception);
        }

        /// <summary>
        /// 错误信息
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="message">message</param>
        /// <param name="exception">ex</param>
        public void Error(Type source, object message, Exception exception)
        {

            message=string.Format("{0} \r\n【异常类型】{1} \r\n【异常信息】{2} \r\n【堆栈调用】{3}", new object[] { message, exception.GetType().Name, exception.Message, exception.StackTrace });
            GetLogger(source).Error(message, exception);
        }

        /// <summary>
        /// 失败信息
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="message">message</param>
        /// <param name="exception">ex</param>
        public void Fatal(object source, object message, Exception exception)
        {
            Fatal(source.GetType(), message, exception);
        }

        /// <summary>
        /// 失败信息
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="message">message</param>
        /// <param name="exception">ex</param>
        public void Fatal(Type source, object message, Exception exception)
        {
            GetLogger(source).Fatal(message, exception);
        }


    }
}
