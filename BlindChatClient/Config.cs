using System;
using System.Configuration;
using System.Net;

namespace BlindChat
{
    /// <summary>
    /// 获取应用程序的配置信息
    /// </summary>
    public class Config
    {
        #region Property

        /// <summary>
        /// APP名称
        /// </summary>
        public static string AppName
        {
            get
            {
                return ConfigurationManager.AppSettings["appname"];
            }
        }

        /// <summary>
        /// 根目录的路径
        /// </summary>
        public static string RootDir
        {
            get
            {
                return ConfigurationManager.AppSettings["rootdir"];
            }
        }

        /// <summary>
        /// 客户端监听端口
        /// </summary>
        public static int ClientPort
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["ClientPort"]);
            }
        }

        /// <summary>
        /// 服务端监听端口
        /// </summary>
        public static int ServerPort
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["ServerPort"]);
            }
        }

        /// <summary>
        /// 服务器IP地址
        /// </summary>
        public static string ServerIP
        {
            get
            {
                return ConfigurationManager.AppSettings["ServerIP"];
            }
        }

        /// <summary>
        /// 本机IP地址
        /// </summary>
        public static string LocalIPAddress
        {
            get
            {
                string localIP = string.Empty;
                foreach (IPAddress ip in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
                {
                    if (ip.AddressFamily.ToString() == "InterNetwork")
                    {
                        localIP = ip.ToString();
                    }
                }
                return localIP;
            }
        }

        #endregion
    }
}
