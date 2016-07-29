using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetWin.Tools.MarketingSpider.App_Code;
using Shove._IO;

namespace NetWin.Tools.MarketingSpider.Tool.Controller
{
    public class ExecutionController
    {
        /// <summary>
        /// 开始执行
        /// </summary>
        public static void Start()
        {
            Shove._IO.Log log = new Log(DateTime.Now.ToString("yyyyMMdd") + ".txt");
            log.Write(FormatLog("开始抓取", SpiderEnum.LogLevel.INFO));
            var usrls = DBOperationService.GetUserSiteUrl();
            if (!usrls.Result)
            {
                log.Write(FormatLog(usrls.Message, SpiderEnum.LogLevel.ERROR));
                return;
            }

            foreach (var baseUrl in usrls.Data)
            {

                var ItemUrls = GetItemUrls(baseUrl.UserSiteUrl, baseUrl.Id);

                DBOperationService.DeleteSynthReleaseSiteMap(baseUrl.Id);
                BatchInsert(ItemUrls);
            }
            log.Write(FormatLog("结束抓取", SpiderEnum.LogLevel.INFO));
        }

        /// <summary>
        /// 批量插入
        /// </summary>
        /// <param name="synthReleaSesites"></param>
        private static void BatchInsert(List<SynthReleaSesiteMapModel> synthReleaSesites)
        {
            int pageIndex = 0;
            int pageSize = 20;//最大20个批量插入
            while (synthReleaSesites.Count > pageIndex * pageSize)
            {
                DBOperationService.BatchInsertSynthReleaseSiteMap(synthReleaSesites.Skip(pageIndex * pageSize).Take(pageSize).ToList());
                pageIndex++;
            }
        }

        /// <summary>
        /// 获取所有本域名下的子链接
        /// </summary>
        /// <param name="Urls"></param>
        /// <param name="Host"></param>
        /// <param name="ReleaseSiteId"></param>
        /// <returns></returns>
        private static List<SynthReleaSesiteMapModel> GetItemUrls(string Host, long ReleaseSiteId)
        {
            int pageIndex = 1;
            int pageSize = 10;//10次并发

            List<string> Urls = new List<string>();
            var url = Host.TrimEnd('/');
            if (!url.StartsWith("http") || !url.StartsWith("ftp"))
            {
                url = "http://" + url.TrimEnd('/') + '/';
            }

            var _url = url.TrimEnd('/');

            Urls.Add(url);

            ConcurrentBag<SynthReleaSesiteMapModel> synthReleaSesites = new ConcurrentBag<SynthReleaSesiteMapModel>();//暂存符合条件的子链接
            do
            {
                ConcurrentBag<string> noneBag = new ConcurrentBag<string>();//暂存未抓取子链接

                do
                {
                    Parallel.ForEach(Urls.Skip((pageIndex - 1) * pageSize).Take(pageSize), p =>
                    {
                        try
                        {
                            var htmlResult = SpiderService.GetHtml(p);
                            if (!htmlResult.Result)
                                return;

                            var title = SpiderService.GetTitle(htmlResult.Data);
                            if (synthReleaSesites.Where(x => x.Url == p).Count() > 0)
                                return;

                            if (string.Compare(url, p) != 0 && string.Compare(_url, p) != 0)
                            {
                                synthReleaSesites.Add(new SynthReleaSesiteMapModel()
                                {
                                    ReleaseSiteId = ReleaseSiteId,
                                    Title = title,
                                    Url = p
                                });
                            }
                       

                            var linksResult = SpiderService.GetLinks(htmlResult.Data, Host);
                            foreach (var item in linksResult.Data)
                            {
                                if (string.Compare(url,item)==0||string.Compare(_url,item)==0)
                                    continue;

                                if (synthReleaSesites.Where(x => x.Url == item).Count() > 0)
                                    continue;

                                noneBag.Add(item);
                            }
                        }
                        catch (Exception ex)
                        {
                        }
                    });

                    pageIndex++;
                } while (Urls.Count > (pageIndex - 1) * pageSize);

                Urls.Clear();//清空

                Urls.AddRange(noneBag.ToList().Distinct());
            } while (Urls.Any());
            return synthReleaSesites.ToList();
        }

        /// <summary>
        /// 格式化日志文本
        /// </summary>
        /// <param name="content"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        public static string FormatLog(string content, SpiderEnum.LogLevel level)
        {
            return string.Format("日志等级:{0}" +
                                 "时间:{1}" +
                                 "消息:{2}", level.ToString(), DateTime.Now, content);
        }

    }
}
