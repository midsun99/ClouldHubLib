///**********************************************************************************
///
///=================================
///CLR版本		：4.0.30319.42000
///命名空间		：LYDLib.CloudHub.Models.Result
///文件名称		：MsgGroupList
///=================================
///创建者		：midsun
///创建日期		：2018-12-17 19:27:57
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
    public class MsgGroupList
    {
        /// <summary>
        /// 
        /// </summary>
        public MsgGroupList_Data data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string success { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int errorCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string error { get; set; }
    }

    public class MsgGroupList_Data
    {
        /// <summary>
        /// 
        /// </summary>
        public bool more { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime updateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<MsgGroupList_ListItem> list { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int unreadTotal { get; set; }
    }

    public class MsgGroupList_ListItem 
    {
        /// <summary>
        /// 
        /// </summary>
        public int extendUpdateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int groupType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string updateFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int lastMsgType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string lastMsgId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string groupId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int unreadCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string headerUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string participantMd5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string lastMsgContent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int appUpdateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mention { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string fromUserName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string fold { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string groupName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public GroupList_Param param { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public MsgGroupList_LastMsg lastMsg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime lastMsgSendTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int direction { get; set; }
    }

    public class MsgGroupList_LastMsg
    {
        /// <summary>
        /// 
        /// </summary>
        public int msgLen { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int msgType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public MsgGroupList_Param param { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string clientMsgId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string fromUserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sourceMsgId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string msgId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string fromClientId { get; set; }
        /// <summary>
        /// [图片]
        /// </summary>
        public string content { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int direction { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sendTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int status { get; set; }
    }

    public class MsgGroupList_Param
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
    }
}
