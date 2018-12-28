///**********************************************************************************
///
///=================================
///CLR版本		：4.0.30319.42000
///命名空间		：LYDLib.CloudHub.Models.Result
///文件名称		：ListMessage
///=================================
///创建者		：midsun
///创建日期		：2018-12-19 20:57:07
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
    public class ListMessage_ListItem
    {
        /// <summary>
        /// 
        /// </summary>
        public int msgType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string openStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string fromUserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string msgId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string fromClientId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string content { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime sendTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int msgLen { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string photoUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string senderName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ListMessage_Param param { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sourceMsgId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string company { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string inCurrentNetwork { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string department { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int direction { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int status { get; set; }
    }

    public class ListMessage_Param
    {
        /// <summary>
        /// 
        /// </summary>
        public string ext { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ftype { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string size { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string file_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string isEncrypted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int unreadMonitor { get; set; }
    }

    public class ListMessage_Data
    {
        /// <summary>
        /// 
        /// </summary>
        public string more { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string groupId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ListMessage_ListItem> list { get; set; }
    }

    public class ListMessage
    {
        /// <summary>
        /// 
        /// </summary>
        public ListMessage_Data data { get; set; }
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
