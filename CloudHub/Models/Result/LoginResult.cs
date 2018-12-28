///**********************************************************************************
///
///=================================
///CLR版本		：4.0.30319.42000
///命名空间		：LYDLib.CloudHub.Models.Result
///文件名称		：LoginResult
///=================================
///创建者		：midsun
///创建日期		：2018-12-26 16:50:46
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
    public class LoginResult
    {
        /// <summary>
        /// 登录成功后用户信息
        /// </summary>
        public User user { get; set; }
        /// <summary>
        /// 错误消息
        /// </summary>
        public string errormsg { get; set; }
        /// <summary>
        /// 错误代码
        /// </summary>
        public int errorCode { get; set; }
        /// <summary>
        /// 账号
        /// </summary>
        public string em { get; set; }
        /// <summary>
        /// 成功标识
        /// </summary>
        public bool success { get; set; }
        /// <summary>
        /// 服务器时间戳
        /// </summary>
        public long serverTime { get; set; }
    }

}
