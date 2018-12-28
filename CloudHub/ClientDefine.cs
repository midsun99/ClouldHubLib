///**********************************************************************************
///
///=================================
///CLR版本		：4.0.30319.42000
///命名空间		：LYDLib.CloudHub
///文件名称		：ClientDefine
///=================================
///创建者		：midsun
///创建日期		：2018-12-17 10:10:35
///=================================
///功能描述		：
///使用说明		：
///修改人		：midsun
///
///**********************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LYDLib.CloudHub.Models;
using LYDLib.CloudHub.Models.Result;
using LYDLib.Common.Models;

namespace LYDLib.CloudHub
{
    public partial class Client
    {
        private AsyncOperation asyncOperation;
        private TaskFactory factory;
        private CancellationTokenSource source;
        private string Token;
        private bool CancelLisen = false;
        /// <summary>
        /// 当前配置
        /// </summary>
        
        /// <summary>
        /// 后台保持心跳线程
        /// </summary>
        public NamedBackgroundWorker BGWork_KeepAlive { get; set; }
        private Dictionary<string, string> Contact = new Dictionary<string, string>();
        public event EventHandler<TEventArgs<Image>> GetLoginQrCodeComplete;
        public event EventHandler<TEventArgs<object>> LoginComplete;
        public event EventHandler<TEventArgs<Exception>> CatchException;
        /// <summary>
        /// 加载会话
        /// </summary>
        public event EventHandler<TEventArgs<GroupList_ListItem>> LoadConversation; 
        /// <summary>
        /// 收到消息事件，有可能会有重复消息，请通过消息ID自行过滤
        /// </summary>
        public event EventHandler<TEventArgs<MsgGroupList_Data>> ReceiveMsg;
        public bool IsLogin = false; 
        public class UserInstance
        {
            public static Config Config { get; set; } = new Config();
            public static ClientWebSocket WS = new ClientWebSocket();
            public static WSReturn WSReturn = new WSReturn();
            public static CookieContainer CookieContainer { get; set; } = new CookieContainer();
            public static Enums.LoginStatus LoginStatus { get; set; } = Enums.LoginStatus.初始化;
            /// <summary>
            /// 所有的会话列表
            /// </summary>
            public static Dictionary<string, GroupList_ListItem> Conversesion { get; set; } = new Dictionary<string, GroupList_ListItem>();
            public static MyInfo MyInfo { get; set; } 
        }
    }
}
