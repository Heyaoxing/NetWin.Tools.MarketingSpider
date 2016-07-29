using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace NetWin.Tools.MarketingSpider
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        static void Main()
        {
#if DEBUG
            DebugRun(null);
#else
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
			{ 
				new MarketingSpiderService() 
			};
            ServiceBase.Run(ServicesToRun);
#endif
        }

        /// <summary>
        /// 调试时调用
        /// </summary>
        /// <param name="args"></param>
        private static void DebugRun(string[] args)
        {
            MarketingSpiderService test = new MarketingSpiderService();
            test.Start(args);
            System.Threading.Thread.Sleep(1000000000);
        }
    }
}
