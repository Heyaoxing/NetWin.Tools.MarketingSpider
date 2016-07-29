using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using NetWin.Tools.MarketingSpider.App_Code;

namespace NetWin.Tools.MarketingSpider
{
    /// <summary>
    /// 网站抓取服务
    /// </summary>
    public class SpiderService
    {
        /// <summary>
        /// 百度权重接口
        /// </summary>
        private static string BAIDUPRZZAPI = "http://www.link114.cn/get.php?baiduprzz&{0}&1259";

        /// <summary>
        ///  获取网址HTML
        /// </summary>
        /// <param name="URL">网址 </param>
        /// <returns> </returns>
        public static ResultModel<string> GetHtml(string URL)
        {
            ResultModel<string> resultModel = new ResultModel<string>();
            resultModel.Result = true;
            HttpWebRequest wrt;

            try
            {

                wrt = (HttpWebRequest)WebRequest.Create(URL);
                wrt.Timeout = 5 * 1000;//5秒超时
                wrt.Method = "GET"; //请求方法
                wrt.Accept = "text/html"; //接受的内容
                wrt.UserAgent = "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; Trident/4.0)"; ; //用户代理
                wrt.Credentials = CredentialCache.DefaultCredentials;
                WebResponse wrp;
                wrp = wrt.GetResponse();

                var bytes = StreamToBytes(wrp.GetResponseStream());

                var stream = new StreamReader(BytesToStream(bytes), Encoding.GetEncoding("utf-8"));


                string htmlstring = stream.ReadToEnd();
                var encodingString = GetEncoding(htmlstring);

                //判断不是utf8不转码
                if (encodingString.ToLower() != "utf-8")
                {
                    htmlstring = new StreamReader(BytesToStream(bytes), Encoding.GetEncoding(encodingString)).ReadToEnd();
                }
                wrt.GetResponse().Close();
                //删除脚本
                resultModel.Data = Regex.Replace(htmlstring, @"<script[^>]*?>.*?</script>", "", RegexOptions.IgnoreCase);
                if (string.IsNullOrWhiteSpace(resultModel.Data))
                {
                    resultModel.Result = false;
                    resultModel.Message = "无网页内容!";
                }
            }
            catch (Exception ex)
            {
                resultModel.Result = false;
                resultModel.Message = ex.Message;
            }
            return resultModel;
        }

        /// <summary>
        /// 转化为字节
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static byte[] StreamToBytes(Stream stream)
        {
            List<byte> bytes = new List<byte>();
            int temp = stream.ReadByte();
            while (temp != -1)
            {
                bytes.Add((byte)temp);
                temp = stream.ReadByte();
            }

            return bytes.ToArray();
        }

        /// <summary>
        /// 转化为流
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        private static Stream BytesToStream(byte[] bytes)
        {
            Stream stream = new MemoryStream(bytes);
            return stream;
        }
        /// <summary>
        /// 读取网页编码
        /// </summary>
        /// <returns></returns>
        private static string GetEncoding(string Html)
        {
            try
            {
                var reg = new Regex(@"<meta.+?charset=[^\w]?([-\w]+)", RegexOptions.IgnoreCase);
                string encodingStirng = reg.Match(Html).Groups[1].Value;
                if (encodingStirng.ToLower() == "gb2312" || encodingStirng.ToLower() == "gbk")
                {
                    encodingStirng = "gb18030";
                }
                return encodingStirng;
            }
            catch (Exception ex)
            {
            }
            return "gb18030";
        }

        /// <summary>
        /// 获取网站域名
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public static string GetHost(string Url)
        {
            try
            {
                var reg = new Regex(@"https?://(.*?)($|/)", RegexOptions.IgnoreCase);
                return reg.Match(Url).Groups[1].Value;
            }
            catch (Exception ex)
            {
            }
            return "";
        }

        /// <summary>
        /// 获取网站标题
        /// </summary>
        /// <param name="Html"></param>
        /// <returns></returns>
        public static string GetTitle(string Html)
        {
            var reg = new Regex(@"<title[^>]*?>(.*)<\/title>",RegexOptions.IgnoreCase | RegexOptions.Singleline);
            return reg.Match(Html).Groups[1].Value;
        }

        /// <summary>
        /// 获取网页中的所有相同域名的链接
        /// </summary>
        /// <param name="html"></param>
        /// <param name="baseUrl">域名</param>
        /// <returns></returns>
        public static ResultModel<List<string>> GetLinks(string html, string baseUrl)
        {
            ResultModel<List<string>> resultModel = new ResultModel<List<string>>();
            resultModel.Result = true;
            resultModel.Data = new List<string>();
            try
            {
                baseUrl = baseUrl.TrimEnd('/');
                //{
                //    const string pattern = @"http://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?";
                //    Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
                //    MatchCollection m = r.Matches(html);
                //    if (m != null)
                //        foreach (var link in m)
                //        {


                //            if (UrlAvailable(link.ToString()) && link.ToString().Contains(baseUrl) && !resultModel.Data.Contains(link.ToString()))
                //                resultModel.Data.Add(link.ToString().Trim());
                //        }

                const string ahref = @"<a[^>]*href=([""'])?(?<href>[^'""]+)\1[^>]*>";
                Regex regex = new Regex(ahref, RegexOptions.IgnoreCase);
                var captureCollection = regex.Matches(html);

                string _link = string.Empty;
                foreach (Match link in captureCollection)
                {
                    _link = link.Groups[2].ToString().TrimEnd('/').TrimStart('/');
                    var host = GetHost(_link);//获取域名
                    if (string.IsNullOrWhiteSpace(host))
                    {
                        _link = baseUrl + "/" + _link;
                        if (!_link.StartsWith("http") || !_link.StartsWith("ftp"))
                        {
                            _link = "http://" + _link;
                        }
                    }
                   

                    if (UrlAvailable(_link) && !resultModel.Data.Contains(_link) && _link.ToString().Contains(baseUrl))
                        resultModel.Data.Add(_link.TrimEnd('#').Trim());
                }
            }
            catch (Exception exception)
            {
                resultModel.Result = false;
                resultModel.Message = exception.Message;
            }

            return resultModel;
        }

        /// <summary>
        /// 获取权重
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static int GetWeights(string url)
        {
            int weights = -1;
            try
            {
                var html = GetHtml(string.Format(BAIDUPRZZAPI, url));
                if (html.Result)
                {
                    weights = Int32.Parse(html.Data);
                }
            }
            catch (Exception exception)
            {
            }
            return weights;
        }

        /// <summary>
        /// 判断链接是否合法
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private static bool UrlAvailable(string url)
        {
            if (url.Contains(".jpg") || url.Contains(".gif")
                || url.Contains(".png") || url.Contains(".css")
                || url.Contains(".js") || url.Contains(".xml") || url.Contains("javascript:"))
            {
                return false;
            }
            return true;
        }



    }
}
