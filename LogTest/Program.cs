using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogCommon;

namespace LogTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();
            LogHelper.LogInfo("This msg is Info.");
            LogHelper.LogError("This msg is Error.",new Exception("This my Exception"));
        }
    }
}
