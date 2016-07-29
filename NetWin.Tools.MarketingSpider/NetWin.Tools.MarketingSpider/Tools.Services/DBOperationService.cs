using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using com.google.zxing;
using DAL;
using NetWin.Tools.MarketingSpider.App_Code;

namespace NetWin.Tools.MarketingSpider
{
    public class DBOperationService
    {
        /// <summary>
        /// 获取需要爬取的营销站点
        /// </summary>
        /// <returns></returns>
        public static ResultModel<List<SynthReleaseSiteModel>> GetUserSiteUrl()
        {
            var resulrModel = new ResultModel<List<SynthReleaseSiteModel>>();
            resulrModel.Result = true;
            resulrModel.Message = "成功";
            resulrModel.Data = new List<SynthReleaseSiteModel>();
            try
            {
                Tables.t_synth_release_site entity=new Tables.t_synth_release_site();
                var dt = entity.Open(" id,user_site_url ", " is_eims_url=0 ", "", -1,-1);
                if (dt == null)
                {
                    resulrModel.Message = "数据查询失败!";
                    resulrModel.Result = false;
                    return resulrModel;
                }
                if (dt.Rows.Count == 0)
                {
                    resulrModel.Message = "未找到符合条件网址!";
                    resulrModel.Result = false;
                    return resulrModel;
                }

                foreach (DataRow dr in dt.Rows)
                {
                    var userSiteUrl = dr["user_site_url"] != null ? dr["user_site_url"].ToString() : "";
                    if (!string.IsNullOrWhiteSpace(userSiteUrl))
                    {
                        resulrModel.Data.Add(new SynthReleaseSiteModel()
                        {
                            Id = Int32.Parse(dr["id"].ToString()),
                            UserSiteUrl = userSiteUrl
                        });
                    }
                }
            }
            catch (Exception exception)
            {
                resulrModel.Result = false;
                resulrModel.Message = exception.Message;
            }

            return resulrModel;
        }

        /// <summary>
        /// 根据t_synth_release_site的id删除广告计划推广的站点的站点地图表
        /// </summary>
        /// <param name="ReleaseSiteId"></param>
        /// <returns></returns>
        public static ResultModel DeleteSynthReleaseSiteMap(long ReleaseSiteId)
        {
            ResultModel resultModel = new ResultModel();
            resultModel.Result = true;
            try
            {

                Shove.Database.MySQL.ExecuteNonQuery("delete from t_synth_release_sitemap where release_site_id=" + ReleaseSiteId + " ");
            }
            catch (Exception exception)
            {
                resultModel.Result = false;
                resultModel.Message = exception.Message;
            }
            return resultModel;
        }

        /// <summary>
        /// 批量插入广告计划推广的站点的站点地图表
        /// </summary>
        /// <returns></returns>
        public static ResultModel BatchInsertSynthReleaseSiteMap(List<SynthReleaSesiteMapModel> SynthReleaSesites)
        {
            ResultModel resultModel = new ResultModel();
            resultModel.Result = true;
            try
            {
                StringBuilder sb=new StringBuilder();
                if (SynthReleaSesites != null && SynthReleaSesites.Count > 0)
                {
                    foreach (var item in SynthReleaSesites)
                    {
                        sb.AppendFormat("insert into t_synth_release_sitemap(release_site_id,title,url,create_time)values({0},'{1}','{2}','{3}');", item.ReleaseSiteId, item.Title, item.Url, DateTime.Now);
                    }
                    Shove.Database.MySQL.ExecuteNonQuery(sb.ToString());
                }
            }
            catch (Exception exception)
            {
                resultModel.Result = false;
                resultModel.Message = exception.Message;
            }
            return resultModel;
        }
    }
}
