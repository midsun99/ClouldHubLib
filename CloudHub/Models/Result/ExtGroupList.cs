///**********************************************************************************
///
///=================================
///CLR版本		：4.0.30319.42000
///命名空间		：LYDLib.CloudHub.Models.Result
///文件名称		：ExtGroupList
///=================================
///创建者		：midsun
///创建日期		：2018-12-17 20:32:03
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
    public class ExtGroupList
    {
        /// <summary>
        /// 
        /// </summary>
        public ExtGroupList_Data data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string success { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int errorCode { get; set; }
    }

    public class ExtGroupList_Data
    {
        /// <summary>
        /// 
        /// </summary>
        public string more { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string updateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> list { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int unreadTotal { get; set; }
    }
}
