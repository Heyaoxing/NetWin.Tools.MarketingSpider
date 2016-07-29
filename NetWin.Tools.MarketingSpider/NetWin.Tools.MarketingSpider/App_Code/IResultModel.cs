using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetWin.Tools.MarketingSpider.App_Code
{
    public abstract class IResultModel
    {
        public bool Result { set; get; }
        public string Message { set; get; }
    }
}
