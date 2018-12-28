///**********************************************************************************
///
///=================================
///CLR版本		：4.0.30319.42000
///命名空间		：LYDLib.CloudHub.Models.Result
///文件名称		：GroupList
///=================================
///创建者		：midsun
///创建日期		：2018-12-17 19:23:57
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
using LYDLib.CloudHub.Interface;

namespace LYDLib.CloudHub.Models.Result
{
    public class Param_Content_List
    {
        /// <summary>
        /// 
        /// </summary>
        public string date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string srcurl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int row { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string text { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string thumbUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
    }
    public class Param_Content_Param
    {
        /// <summary>
        /// 
        /// </summary>
        public int todo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int msgType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string todoNotify { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sendUser { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int model { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int updateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string text { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int authType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Param_Content_List> list { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string commentSwitch { get; set; }
    }
    public class Param_Content
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
        public Param_Content_Param param { get; set; }
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
        /// 
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
    public class GroupList_Param
    {
        /// <summary>
        /// 
        /// </summary>
        public int micDisable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int recordStatus { get; set; }
    }
    public class GroupList_LastMsg
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
        public Param_Content param { get; set; }
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
        /// 收到
        /// </summary>
        public string content { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int direction { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime sendTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int status { get; set; }
    }
    public class GroupList_ListItem
    {
        /// <summary>
        /// 
        /// </summary>
        public long extendUpdateTime { get; set; }
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
        public long appUpdateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mention { get; set; }
        /// <summary>
        /// 
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
        public List<string> managerIds { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public GroupList_Param param { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public GroupList_LastMsg lastMsg { get; set; }
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
    public class GroupList_Data
    {
        /// <summary>
        /// 
        /// </summary>
        public bool more { get; set; } = false;
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
        public List<GroupList_ListItem> list { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int unreadTotal { get; set; }
    }
    public class GroupList
    {
        /// <summary>
        /// 
        /// </summary>
        public GroupList_Data data { get; set; }
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
