///**********************************************************************************
///
///=================================
///CLR版本		：4.0.30319.42000
///命名空间		：LYDLib.CloudHub.Service
///文件名称		：HttpHelper
///=================================
///创建者		：midsun
///创建日期		：2018-12-17 11:26:52
///=================================
///功能描述		：
///使用说明		：
///修改人		：midsun
///
///**********************************************************************************

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using LYDLib.CloudHub.Models;
using LYDLib.CloudHub.Models.Result;
using LYDLib.Common;
using static LYDLib.CloudHub.Client;
using static LYDLib.Common.Models.Enums;

namespace LYDLib.CloudHub.Service
{
    public class HttpHelper
    {
        public static string User_agent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/66.0.3359.139 Safari/537.36";
        public static string User_Host = "yunzhijia.com";
        public static string Notify = "{\"notifyTo\":[],\"notifyType\":1,\"notifyToAll\":false}";
        /// <summary>
        /// 登录账号
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="psw"></param>
        /// <param name="isremenber"></param>
        /// <returns></returns>
        public static LoginResult Login(string userid, string psw, bool isremenber)
        {
            string url = "https://www.yunzhijia.com/space/c/rest/user/login?"+Untity.GetTimeStamp();
            Models.Param param = new Models.Param();
            param.Paras.Add(new Models.ParaBase("email", null, userid));
            param.Paras.Add(new Models.ParaBase("password", null, psw));
            param.Paras.Add(new Models.ParaBase("forceToNetwork", null, false));
            param.Paras.Add(new Models.ParaBase("redirectUrl", null, null));
            param.Paras.Add(new Models.ParaBase("accountType", null, null));
            byte[] postdata = param.GetData();
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "POST";
            request.UserAgent = User_agent;
            request.Accept = "application/json, text/javascript, */*; q=0.01";
            request.Headers.Add("Accept-Encoding", "gzip, deflate, br");
            request.Headers.Add("Accept-Language", "zh-CN,zh;q=0.9");
            request.KeepAlive = true;
            request.ContentLength = postdata.Length;
            request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
            request.Headers.Add("origin", "https://www.yunzhijia.com");
            request.Referer = "https://www.yunzhijia.com/home/?m=open&a=login";
            request.Headers.Add("X-Requested-With", "XMLHttpRequest");
            request.CookieContainer = UserInstance.CookieContainer;
            try
            {
                Stream newstream = request.GetRequestStream();
                newstream.Write(postdata, 0, postdata.Length);
                newstream.Close();
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string setck = response.Headers.Get("Set-Cookie");
                UserInstance.CookieContainer.Add(response.Cookies);
                return GetResponse<LoginResult>(request);

            }
            catch (Exception ex)
            {
                request.Abort();
                return null;

            } 
        }
        public static T HttpGetBase<T>(string url)
        {
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "GET";
            request.Accept = "*/*";
            request.Headers.Add("Accept-Encoding", "gzip, deflate");
            request.Headers.Add("Accept-Language", "zh-CN");
            request.Referer = "https://yunzhijia.com/im/xiaoxi/";
            request.Headers.Add("X-Requested-With", "XMLHttpRequest");
            request.CookieContainer = UserInstance.CookieContainer;
            return GetResponse<T>(request);
        }
        /// <summary>
        /// 获取Get到的字符数据
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string HttpGetBase(string url)
        {
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "GET";
            request.Accept = "*/*";
            request.Headers.Add("Accept-Encoding", "gzip, deflate");
            request.Headers.Add("Accept-Language", "zh-CN");
            request.Referer = "https://yunzhijia.com/im/xiaoxi/";
            request.Headers.Add("X-Requested-With", "XMLHttpRequest");
            request.CookieContainer = UserInstance.CookieContainer;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            UserInstance.CookieContainer.Add(response.Cookies); 
            string jsonstr = ""; 
            try
            {
                using (Stream st = response.GetResponseStream())
                {

                    if (response.Headers.Get("Content-Encoding") == "gzip")
                    {
                        jsonstr = Untity.DecompressGZIPStream(st);
                    }
                    else
                    {
                        StreamReader reader = new StreamReader(st);
                        jsonstr = reader.ReadToEnd();
                    }
                }
                return jsonstr;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "";
        }
        private static T GetResponse<T>(HttpWebRequest request)
        {
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                UserInstance.CookieContainer.Add(response.Cookies);
                string jsonstr = "";
                using (Stream st = response.GetResponseStream())
                {
                    if (response.Headers.Get("Content-Encoding") == "gzip")
                    {
                        jsonstr = Untity.DecompressGZIPStream(st);
                    }
                    else
                    {
                        StreamReader reader = new StreamReader(st);
                        jsonstr = reader.ReadToEnd();
                    }
                } 
                return Untity.ConvertToObject<T>(jsonstr);
            }
            catch (Exception ex)
            {
                //return default(T); 
                throw new Exception("解析数据流失败：" + ex.Message);
            }
        }
        public static Result CheckLoginStatus(string token)
        {
            HttpWebRequest request = WebRequest.Create($"https://yunzhijia.com/space/c/checkloginstatus?token={token}") as HttpWebRequest;
            request.Method = "GET";
            request.Accept = "application/json, text/javascript, */*; q=0.01";
            request.Headers.Add("Accept-Encoding", "gzip, deflate");
            request.Headers.Add("Accept-Language", "zh-CN");
            request.Headers.Add("Cache-Control", "no-cache");
            request.Host = User_Host;
            request.Referer = "https://yunzhijia.com/home/custom/saas/i9";
            request.Headers.Add("X-Requested-With", "XMLHttpRequest");
            request.UserAgent = User_agent;
            request.CookieContainer = UserInstance.CookieContainer;
            return GetResponse<Result>(request);
        }
        public static MyInfo Getmyinfo()
        {
            MyInfo myInfo = new MyInfo();
            var info = HttpGetBase("https://yunzhijia.com/im/api/myinfo");
            if (info.Length > 0)
            {
                string[] sps = info.Split(';');
                string jsonstr = sps[0].Replace("var", "").Replace("__sessionUser", "").Replace("=", "");
                myInfo = Untity.ConvertToObject<MyInfo>(jsonstr);
                string myid = sps[2].Replace("__myinfo.id", "").Replace("}", "").Replace("=", "").Replace("'", "").Replace("\n", "").Replace("\r", "").Replace(" ", "");
                myInfo.UserID = myid;
            }
            return myInfo;
        }
        public static CheckException CheckException(long timestamp)
        {
            HttpWebRequest request = WebRequest.Create($"https://www.yunzhijia.com/im/rest/sso/check?_={timestamp}") as HttpWebRequest;
            request.Method = "GET";
            request.Accept = "*/*";
            request.Headers.Add("Accept-Encoding", "gzip, deflate");
            request.Headers.Add("Accept-Language", "zh-CN");
            request.Headers.Add("Cache-Control", "no-cache");
            request.Host = "www.yunzhijia.com";
            request.Referer = "https://www.yunzhijia.com/im/xiaoxi/";
            request.Headers.Add("X-Requested-With", "XMLHttpRequest");
            request.UserAgent = User_agent;
            request.CookieContainer = UserInstance.CookieContainer;
            
            return GetResponse<CheckException>(request); 
        }
        public static  MsgGroupList GroupList(DateTime lastuptime, long timestamp = 0)
        { 
            timestamp = timestamp == 0 ? Untity.GetTimeStamp() : timestamp;
            string url = string.Format("https://www.yunzhijia.com/im/rest/group/groupList?lastUpdateTime={0}&_={1}",lastuptime, timestamp); 
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.CookieContainer = UserInstance.CookieContainer;
            request.Method = "GET";
            request.Accept = "application/json, text/javascript, */*; q=0.01";
            request.Headers.Add("Accept-Encoding", "gzip,deflate");
            request.Headers.Add("Accept-Language", "zh-CN");
            request.Host = User_Host;
            request.Referer = "https://www.yunzhijia.com/im/xiaoxi/";
            request.UserAgent =User_agent;
            request.Headers.Add("X-Requested-With", "XMLHttpRequest"); 
            return GetResponse<MsgGroupList>(request); 
        }
        public static  GroupList GroupList(int offset, int count, long timestamp = 0)
        { 
            timestamp = timestamp == 0 ? Untity.GetTimeStamp() : timestamp;
            string url = string.Format("https://www.yunzhijia.com/im/rest/group/groupList?offset={0}&count={1}&_={2}", offset, count, timestamp);
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.CookieContainer = UserInstance.CookieContainer;
            request.Method = "GET";
            request.Accept = "application/json, text/javascript, */*; q=0.01";
            request.Headers.Add("Accept-Encoding", "gzip,deflate");
            request.Headers.Add("Accept-Language", "zh-CN");
            //request.KeepAlive = true;
            //request.Headers.Add("Cookie", mycookie);
            request.Host = User_Host;
            request.Referer = "https://www.yunzhijia.com/im/xiaoxi/";
            request.UserAgent = User_agent;
            request.Headers.Add("X-Requested-With", "XMLHttpRequest");
            
            return GetResponse<GroupList>(request);
        } 
        public static SendMessage SendMessage(MsgType msgtype, string content, string touserid, string groupid = null)
        {
            if (groupid == null)
            {
                //groupid = touserid + "-" + UserInstance.MyInfo.UserID;
                groupid = "";
            }

            Param para = new Param();
            para.Paras.Add(new  ParaBase("clientMsgId", typeof(string), Guid.NewGuid().ToString()));
            para.Paras.Add(new  ParaBase("content", typeof(string), HttpUtility.UrlEncode(content)));
            para.Paras.Add(new  ParaBase("groupid", typeof(string), groupid));
            para.Paras.Add(new  ParaBase("msgLen", typeof(string), content.Length));
            para.Paras.Add(new  ParaBase("msgType", typeof(int), (int)msgtype));
            para.Paras.Add(new  ParaBase("param", typeof(string), HttpUtility.UrlEncode(Notify)));
            para.Paras.Add(new  ParaBase("toUserId", typeof(string), touserid)); 
            string url = "https://yunzhijia.com/im/web/sendMessage.do";
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            byte[] postdata = para.GetData();
            request.Method = "POST";
            request.UserAgent = User_agent;
            request.Accept = "application/json, text/javascript, */*; q=0.01";
            request.Headers.Add("Accept-Encoding", "gzip,deflate");
            request.Headers.Add("Accept-Language", "no-cache");
            request.Headers.Add("Cache-Control", "zh-CN");
            request.KeepAlive = true;
            request.ContentLength = postdata.Length;
            request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
            request.CookieContainer = UserInstance.CookieContainer;
            request.Host = User_Host;
            request.Referer = "https://yunzhijia.com/im/xiaoxi/";
            request.Headers.Add("X-Requested-With", "XMLHttpRequest");
            Stream newstream = request.GetRequestStream();
            newstream.Write(postdata, 0, postdata.Length);
            newstream.Dispose();
            return GetResponse<SendMessage>(request);
        } 
        public static void StartWebSocket(string url)
        {
            new Task(()=> {
                var socket = new ClientWebSocket();
                socket.ConnectAsync(new Uri(""), CancellationToken.None).Wait();

                while (true)
                {
                    var array = new byte[4096];
                    var result = socket.ReceiveAsync(new ArraySegment<byte>(array), CancellationToken.None);
                    if (result.Result.MessageType == WebSocketMessageType.Text)
                    {
                        string msg = Encoding.UTF8.GetString(array, 0, result.Result.Count);
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("--> {0}", msg);
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        break;
                    }
                }
            }).Start(); 
        }
        /// <summary>
        /// 下载网络图片（不使用Cookies）
        /// </summary>
        /// <param name="_url"></param>
        /// <returns></returns>
        public static Image LoadPicture(string _url)
        {
            try
            {
                Image re = null;
                string url = _url;
                string dir = Path.Combine(Environment.CurrentDirectory, "header");
                string picid = Untity.GetMD5String(url) + ".jpg";
                string picpath = Path.Combine(dir, picid);
                if (Directory.Exists(UserInstance.Config.CachePath))
                {

                }
                else
                {
                    Directory.CreateDirectory(dir);
                } 
                //如果本地有缓存
                if (File.Exists(picpath))
                {
                    Console.WriteLine("从本地加载："+ picpath);
                    return new Bitmap(picpath);
                }
                
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream st = response.GetResponseStream();
                re = Image.FromStream(st);
                if (re != null)
                {
                    re.Save(picpath);
                }
                st.Dispose();
                request.Abort();
                return re;
            }
            catch (Exception ex)
            {
                return null;
            }
            
        } 
        /// <summary>
        /// 获取会话的成员
        /// </summary>
        /// <param name="count">获取成员个数</param>
        /// <param name="groupid">会话ID</param>
        /// <param name="offset">成员起始位置</param>
        /// <returns></returns>
        public static GruopUser GetGroupUser(int count, string groupid, int offset)
        { 
            string url = @"https://www.yunzhijia.com/im/rest/group/groupUser";
            Models.Param param = new Models.Param();
            param.Paras.Add(new Models.ParaBase("count", null, count));
            param.Paras.Add(new Models.ParaBase("groupId", null, groupid));
            param.Paras.Add(new Models.ParaBase("offset", null, offset));
            byte[] postdata = param.GetData();
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "POST";
            request.UserAgent = User_agent;
            request.Accept = "application/json, text/javascript, */*; q=0.01";
            request.Headers.Add("Accept-Encoding", "gzip, deflate, br");
            request.Headers.Add("Accept-Language", "zh-CN,zh;q=0.9");
            request.Headers.Add("Cache-Control", "no-cache");
            //request.Headers.Add("Cookie", mycookie);
            request.KeepAlive = true;
            request.ContentLength = postdata.Length;
            request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
            request.Host = "www.yunzhijia.com";
            request.Referer = "https://www.yunzhijia.com/im/xiaoxi";
            request.Headers.Add("X-Requested-With", "XMLHttpRequest");
            request.CookieContainer = UserInstance.CookieContainer;
            Stream newstream = request.GetRequestStream();
            newstream.Write(postdata, 0, postdata.Length);
            newstream.Dispose();
            return GetResponse< GruopUser>(request);
        }

        /// <summary>
        /// 列出对话消息
        /// </summary>
        /// <param name="p">Param_ListMessage类型参数</param>
        /// <returns></returns>
        public static ListMessage ListMessage(int _count, string _groupid, string _msgId, string _type ="new")
        {
            Param para = new Param();  
            para.Paras.Add(new ParaBase("groupid", typeof(string), _groupid));
            para.Paras.Add(new ParaBase("msgId", typeof(string), _msgId));
            para.Paras.Add(new ParaBase("count", typeof(int), _count));
            para.Paras.Add(new ParaBase("type", typeof(string), _type));
            byte[] postdata = para.GetData();
            HttpWebRequest request = WebRequest.Create("https://www.yunzhijia.com/im/rest/message/listMessage") as HttpWebRequest; 
            request.Method = "POST";
            request.Accept = "application/json, text/javascript, */*; q=0.01";
            request.Headers.Add("Accept-Encoding", "gzip,deflate");
            request.Headers.Add("Accept-Language", "zh-CN");
            request.Headers.Add("Cache-Control", "no-cache");
            request.KeepAlive = true;
            request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
            request.ContentLength = postdata.Length;
            request.CookieContainer = UserInstance.CookieContainer;
            request.Host = User_Host;
            request.Referer = "https://www.yunzhijia.com/im/xiaoxi";
            request.UserAgent = User_agent;
            request.Headers.Add("X-Requested-With", "XMLHttpRequest");
            Stream newstream = request.GetRequestStream();
            newstream.Write(postdata, 0, postdata.Length);
            newstream.Dispose();
            return GetResponse<ListMessage>(request);
        }


    }
}
