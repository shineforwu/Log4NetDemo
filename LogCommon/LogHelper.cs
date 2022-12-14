using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogCommon
{
    public static class LogHelper
    {
        //这里的 loginfo 和 log4net.config 里的名字要一样
        private static readonly log4net.ILog log_info = log4net.LogManager.GetLogger("loginfo");

        //这里的 logerror 和 log4net.config 里的名字要一样
        private static readonly log4net.ILog log_error = log4net.LogManager.GetLogger("logerror");

        private static readonly log4net.ILog log_warn = log4net.LogManager.GetLogger("logwarn");

        private static readonly log4net.ILog log_debug = log4net.LogManager.GetLogger("logdebug");

        public static void LogInfo(string info)
        {
            if (log_info.IsInfoEnabled)
            {
                log_info.Info(info);
            }
        }

        public static void LogWarn(string info,Exception ex)
        {
            if(log_warn.IsWarnEnabled)
            {
                log_warn.Warn(info,ex);
            } 
        }

        public static void LogWarn(string info)
        {
            if (log_warn.IsWarnEnabled)
            {
                log_warn.Warn(info);
            }
        }

        public static void LogDebug(string info)
        {
            if (log_debug.IsDebugEnabled)
            {
                log_debug.Debug(info);
            }
        }
        public static void LogDebug(string info,Exception ex)
        {
            if (log_debug.IsDebugEnabled)
            {
                log_debug.Debug(info,ex);
            }
        }

        public static void LogError(string error, Exception ex)
        {
            if (log_error.IsErrorEnabled)
            {

                log_error.Error(error, ex);
                while (ex.InnerException != null)
                {
                    ex = ex.InnerException;
                    log_error.Error(error, ex);
                }


            }
        }
    }
}
