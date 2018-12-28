///**********************************************************************************
///
///=================================
///CLR版本		：4.0.30319.42000
///命名空间		：LYDLib.CloudHub.Models
///文件名称		：User
///=================================
///创建者		：midsun
///创建日期		：2018-12-19 21:37:35
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
    /// <summary>
    /// 用户简单信息
    /// </summary>
    public class User
    {
        /// <summary>
        /// 用户唯一ID
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 用户姓名
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 头像地址
        /// </summary>
        public string photoUrl { get; set; }
        /// <summary>
        /// 头像ID
        /// </summary>
        public string photoId { get; set; }
        /// <summary>
        /// 是否记住登录
        /// </summary>
        public bool isPublicMailBox { get; set; }

    }
}
