using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using NetWin.Tools.MarketingSpider.App_Code;
using NetWin.Tools.MarketingSpider.Tool.Controller;
using Shove._IO;

namespace NetWin.Tools.MarketingSpider
{
    public partial class MarketingSpiderService : ServiceBase
    {
        /// <summary>
        /// 设置定时周期
        /// </summary>
        private readonly static int CYCLE = Int32.Parse(ConfigurationManager.AppSettings["CycleTimer"]);

        /// <summary>
        /// 设置每日周期
        /// </summary>
        private readonly static string DAILY = ConfigurationManager.AppSettings["DailyTimer"];


        /// <summary>
        /// 设置定时类型(100:定时周期类型; 200:每日周期类型)
        /// </summary>
        private readonly static int TIMERTYPE = Int32.Parse(ConfigurationManager.AppSettings["TimerType"]);

        /// <summary>
        /// 高峰期开始时间
        /// </summary>
        private readonly static string PEAKSTARTTIME = ConfigurationManager.AppSettings["PeakStartTime"];

        /// <summary>
        /// 高峰期结束时间
        /// </summary>
        private readonly static string PEAKENDTIME = ConfigurationManager.AppSettings["PeakEndTime"];

        /// <summary>
        /// 是否启用高峰期判断(1:表示启用,0表示禁用)
        /// </summary>
        private readonly static string ENABLEPEAK = ConfigurationManager.AppSettings["EnablePeak"].Trim();


        Shove._IO.Log log = new Log(DateTime.Now.ToString("yyyyMMdd") + ".txt");


        /// <summary>
        /// 存储上次执行时间
        /// </summary>
        private DateTime cycleTime = DateTime.MinValue;

        public MarketingSpiderService()
        {
            InitializeComponent();
        }
        System.Timers.Timer t = new System.Timers.Timer(1000 * 30);//实例化Timer类，设置间隔时间为30秒;
        public void BeginTimer()
        {
            

            t.Elapsed += new System.Timers.ElapsedEventHandler(Execution);//到达时间的时候执行事件;
            t.AutoReset = true;//设置是执行一次（false）还是一直执行(true);
            t.Enabled = true;//是否执行System.Timers.Timer.Elapsed事件;

            t.Start();//开始计时
        }



        /// <summary>
        /// 执行定时任务
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void Execution(object source, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                if (!IsPeak(DateTime.Now))//判断是否在高峰期,只有不在高峰期才执行.
                {
                    //判断周期类型
                    if (TIMERTYPE == 100)
                    {
                        CycleExecution();
                    }
                    else
                    {
                        DailyExecution();
                    }
                }

            }
            catch (Exception exception)
            {
                log.Write(ExecutionController.FormatLog("执行定时任务时异常:" + exception.Message, SpiderEnum.LogLevel.ERROR));
            }
        }

        /// <summary>
        /// 定时周期执行任务
        /// </summary>
        private void CycleExecution()
        {
            var now = DateTime.Now;
            double minutes = (now - cycleTime).TotalMinutes;
            if (minutes > CYCLE)
            {
                log.Write(ExecutionController.FormatLog("执行定时周期任务,上次执行时间为:" + cycleTime + ",本次执行时间为:" + now, SpiderEnum.LogLevel.ERROR));
                try
                {
                    ExecutionController.Start();
                }
                catch (Exception exception)
                {
                    log.Write(ExecutionController.FormatLog(exception.Message, SpiderEnum.LogLevel.ERROR));
                }
                cycleTime = now;
            }
        }

        /// <summary>
        /// 每日周期执行任务
        /// </summary>
        private void DailyExecution()
        {
            var now = DateTime.Now;
            var dateFormString = DAILY.Split(':').ToList();
            int hours = Int32.Parse(dateFormString[0].ToString());//小时
            int minute = Int32.Parse(dateFormString[1].ToString());//分钟
            var dailyDateTime = new DateTime(now.Year, now.Month, now.Day, hours, minute, 0);//初始化一个设置到达的时间类型,方便与当前时间作比较

            if (dailyDateTime <= now && (now - cycleTime).Days != 0)
            {
                log.Write(ExecutionController.FormatLog("执行每日周期任务,上次执行时间为:" + cycleTime + ",本次执行时间为:" + now, SpiderEnum.LogLevel.ERROR));
                try
                {
                    ExecutionController.Start();
                }
                catch (Exception exception)
                {
                    log.Write(ExecutionController.FormatLog(exception.Message, SpiderEnum.LogLevel.ERROR));
                }
                cycleTime = now;
            }
        }

        /// <summary>
        /// 判断是否在高峰期
        /// </summary>
        /// <param name="now"></param>
        /// <returns></returns>
        private bool IsPeak(DateTime now)
        {
            if (ENABLEPEAK== "0")
                return false;


            //高峰开始日期
            var PeakStartTimeString = PEAKSTARTTIME.Split(':').ToList();
            int hoursStart = Int32.Parse(PeakStartTimeString[0].ToString());//小时
            int minuteStart = Int32.Parse(PeakStartTimeString[1].ToString());//分钟
            var PeakStartTime = new DateTime(now.Year, now.Month, now.Day, hoursStart, minuteStart, 0);//初始化一个设置到达的时间类型,方便与当前时间作比较

            //高峰结束日期
            var PeakEndTimeString = PEAKENDTIME.Split(':').ToList();
            int hoursEnd = Int32.Parse(PeakEndTimeString[0].ToString());//小时
            int minuteEnd = Int32.Parse(PeakEndTimeString[1].ToString());//分钟
            var PeakEndTime = new DateTime(now.Year, now.Month, now.Day, hoursEnd, minuteEnd, 0);//初始化一个设置到达的时间类型,方便与当前时间作比较

            if (now >= PeakStartTime && PeakEndTime >= now)
                return true;

            return false;
        }


        /// <summary>
        /// 服务开始
        /// </summary>
        /// <param name="args"></param>
        protected override void OnStart(string[] args)
        {
            log.Write(ExecutionController.FormatLog("服务启动成功", SpiderEnum.LogLevel.ERROR));
            try
            {
                BeginTimer();
            }
            catch (Exception exception)
            {
                log.Write(ExecutionController.FormatLog("执行定时器检测任务执行时异常:" + exception.Message, SpiderEnum.LogLevel.ERROR));
            }
        }

        /// <summary>
        /// 服务结束
        /// </summary>
        protected override void OnStop()
        {
            try
            {
                if (t != null)
                    t.Dispose();
            }
            catch (Exception exception)
            {
                log.Write(ExecutionController.FormatLog("服务停止异常:" + exception.Message, SpiderEnum.LogLevel.ERROR));
            }
            
            log.Write(ExecutionController.FormatLog("服务停止", SpiderEnum.LogLevel.ERROR));
        }

        #region 调试时调用
        public void Start(string[] args)
        {
            this.OnStart(args);
        }
        #endregion
    }
}
