///**********************************************************************************
///
///=================================
///CLR版本		：4.0.30319.42000
///命名空间		：LYDLib.CloudHub.Models
///文件名称		：Config
///=================================
///创建者		：midsun
///创建日期		：2018-12-17 13:08:08
///=================================
///功能描述		：
///使用说明		：
///修改人		：midsun
///
///**********************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYDLib.CloudHub.Models
{
    [Serializable]
    public class Config
    {
        /// <summary>
        /// 登录账号
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 登录密码
        /// </summary>
        public string PSW { get; set; }
        /// <summary>
        /// 断线重连
        /// </summary>
        public bool AutoLogin { get; set; }
        /// <summary>
        /// 7天免登录
        /// </summary>
        public bool Login7Days { get; set; }
        /// <summary>
        /// Cookie字符串
        /// </summary>
        public string CookieString { get; set; }
        /// <summary>
        /// 缓存目录
        /// </summary>
        public string CachePath { get; set; }

    }
}
