///**********************************************************************************
///
///=================================
///CLR版本		：4.0.30319.42000
///命名空间		：LYDLib.CloudHub.Models.Result
///文件名称		：GruopUser
///=================================
///创建者		：midsun
///创建日期		：2018-12-19 20:41:58
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

namespace LYDLib.CloudHub.Models.Result
{
    public class UsersItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string userId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string phone { get; set; }
        /// <summary>
        /// 九州通医药集团
        /// </summary>
        public string company { get; set; }
        /// <summary>
        /// 组长
        /// </summary>
        public string jobTitle { get; set; }
        /// <summary>
        /// 系统管理组
        /// </summary>
        public string department { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int gender { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string photoUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string inCurrentNetwork { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string openStatus { get; set; }
        /// <summary>
        /// 张越 辽宁公司信息部系统管理组组长
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
    }

    public class GruopUser_Data
    {
        /// <summary>
        /// 
        /// </summary>
        public List<string> managerIds { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string hasMore { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<UsersItem> users { get; set; }
    }

    public class GruopUser
    {
        /// <summary>
        /// 
        /// </summary>
        public GruopUser_Data data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool success { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int errorCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string error { get; set; }
    }
}
