using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetWin.Tools.MarketingSpider.App_Code
{
    public class SpiderEnum
    {
        public enum LogLevel
        {
            /// <summary>
            /// 正常输出
            /// </summary>
            INFO=100,
            /// <summary>
            /// 错误
            /// </summary>
            ERROR=200,
            /// <summary>
            /// 警告
            /// </summary>
            WARNING=300
        }
    }
}
