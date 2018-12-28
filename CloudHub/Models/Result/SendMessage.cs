﻿///**********************************************************************************
///
///=================================
///CLR版本		：4.0.30319.42000
///命名空间		：LYDLib.CloudHub.Models.Result
///文件名称		：SendMessage
///=================================
///创建者		：midsun
///创建日期		：2018-12-17 21:13:08
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
    public class SendMessage
    {
        /// <summary>
        /// 
        /// </summary>
        public SendMessage_Data data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string error { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int errorCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool success { get; set; }
    }

    public class SendMessage_Data
    {
        /// <summary>
        /// 
        /// </summary>
        public string groupId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string msgId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sendTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int unreadUserCount { get; set; }
    }
}
