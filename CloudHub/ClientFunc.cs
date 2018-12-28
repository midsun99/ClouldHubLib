///**********************************************************************************
///
///=================================
///CLR版本		：4.0.30319.42000
///命名空间		：LYDLib.CloudHub
///文件名称		：ClientFunc
///=================================
///创建者		：midsun
///创建日期		：2018-12-17 10:11:10
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
using System.IO;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using LYDLib.CloudHub.Models.Result;
using LYDLib.CloudHub.Service;
using LYDLib.Common;
using LYDLib.Common.Models;
using static LYDLib.Common.Models.Enums;

namespace LYDLib.CloudHub
{
    public partial class Client
    {
        
        public Client()
        {
            asyncOperation = AsyncOperationManager.CreateOperation(null);
            source = new CancellationTokenSource();
            factory = new TaskFactory(source.Token);
            UserInstance.WS.Options.Cookies = UserInstance.CookieContainer;
        } 
        /// <summary>
        /// 使用二维码登录
        /// </summary>
        public void StartByQR()
        { 
            factory.StartNew(() => GetLoginQR())
                .ContinueWith((token) => GetContactList())
                .ContinueWith((token) => StartGetMsg()); 
        }

        public void Start(string account ,string psw)
        {
            Login(account,psw);
        }
        private void Login(string account, string psw)
        {
            var redata = HttpHelper.Login( account,   psw,true);
            if(redata!=null && redata.success)
            {
                this.IsLogin = true;
                UserInstance.MyInfo = HttpHelper.Getmyinfo();
                factory.StartNew(() => GetContactList())
                    .ContinueWith((token) => StartGetMsg()) ;
            }
        }

        private void GetLoginQR()
        {
            try
            {
                var re = HttpHelper.HttpGetBase<QRResult>($"https://www.yunzhijia.com/space/c/getloginercode?time={Untity.GetTimeStamp()}&_={Untity.GetTimeStamp()}");
                if (re.success)
                {
                    this.Token = re.data.token;
                    WebClient client = new WebClient();
                    var qrbyte = client.DownloadData(@"https://www.yunzhijia.com/image/erloginpic/" + this.Token);
                    using (MemoryStream ms = new MemoryStream(qrbyte))
                    {
                        Image img = Image.FromStream(ms);
                        //监听登录信息
                        asyncOperation.Post(new SendOrPostCallback((obj) =>
                        {
                            GetLoginQrCodeComplete?.Invoke(this, new TEventArgs<Image>((Image)obj));
                        }), img); StartLoginLisen(this.Token);
                    }

                }
            }
            catch (Exception ex)
            {
                asyncOperation.Post(new SendOrPostCallback(obj => {
                    CatchException?.Invoke(this, new TEventArgs<Exception>((Exception)obj));
                }), ex);
            }
            
        }
        private void StartListen()
        {
            this.BGWork_KeepAlive = new NamedBackgroundWorker(this.Token);
            this.BGWork_KeepAlive.WorkerReportsProgress = true;
            this.BGWork_KeepAlive.WorkerSupportsCancellation = true;
            this.BGWork_KeepAlive.ProgressChanged += BGWork_KeepAlive_ProgressChanged;
            this.BGWork_KeepAlive.DoWork += BGWork_KeepAlive_DoWork;
            //保持服务器心跳
            this.BGWork_KeepAlive.RunWorkerAsync();
        }
        /// <summary>
        /// 后台心跳包
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BGWork_KeepAlive_DoWork(object sender, DoWorkEventArgs e)
        {
            string w = string.Format("wss://websocket.yunzhijia.com/im/mySocket?personId={0}&userId={1}", "5a3c7f66e4b0327a777bfc20", "5a3a31dbe4b0d1b3aa41d662");
            ArraySegment<Byte> buffer;
            UserInstance.WS.ConnectAsync(new Uri(w), CancellationToken.None).Wait();
            SendBiteHeart(null, null);
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(SendBiteHeart);
            aTimer.Interval = 10000;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
            while (UserInstance.WS.State == WebSocketState.Open)
            {
                buffer = new ArraySegment<Byte>(new byte[65535]);
                var result = UserInstance.WS.ReceiveAsync(buffer, CancellationToken.None);
                result.Wait();
                if (result.Result.Count > 0)
                { 
                    string restring = Encoding.UTF8.GetString(buffer.ToArray()).TrimEnd('\0');
                    UserInstance.WSReturn = Untity.ConvertToObject<WSReturn>(restring);
                    if(UserInstance.WSReturn.type == "Message")
                    {
                        Recievemsg();
                    }
                    Console.WriteLine(DateTime.Now.ToLongTimeString() + "收到:" + UserInstance.WSReturn.type);
                }

            }
        }

        private void Recievemsg()
        {
            new Task(()=> {
                DateTime updateTime;
                var re = HttpHelper.GroupList(DateTime.Now);
                updateTime = re.data.updateTime;
                var exg = HttpHelper.HttpGetBase<ExtGroupList>($"https://www.yunzhijia.com/im/rest/group/extGroupList?lastUpdateTime={updateTime.ToString("yyyy-MM-dd+H:mm:ss")}&_={Untity.GetTimeStamp()}");
                if (re.data.count > 0)
                {
                    //生成消息事件
                    asyncOperation.Post(new SendOrPostCallback((obj) =>
                    {
                        ReceiveMsg?.Invoke(this, new TEventArgs<MsgGroupList_Data>((MsgGroupList_Data)obj));
                    }), re.data);
                }
            }).Start();
        }
        private void SendBiteHeart(object source, System.Timers.ElapsedEventArgs e)
        {
            UserInstance.WS.SendAsync(new ArraySegment<Byte>(Encoding.UTF8.GetBytes("{socketId: \"" + UserInstance.WSReturn.socketId + "\"}")), WebSocketMessageType.Text, true, CancellationToken.None);            
        }
        /// <summary>
        /// 心跳包线程状态改变处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BGWork_KeepAlive_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
             
        }



        private void StartLoginLisen(string token)
        {
            string url = $"https://www.yunzhijia.com/space/qrloginsocket?token={token}";
            while (!CancelLisen)
            {
                var re = HttpHelper.CheckLoginStatus(token);
                //登录成功
                if (re.success)
                {
                    IsLogin = true;
                    StartListen();
                    //获取自身信息
                    UserInstance.MyInfo = HttpHelper.Getmyinfo();
                    CancelLisen = true;
                    asyncOperation.Post(new SendOrPostCallback((obj) =>
                    {
                        LoginComplete?.Invoke(this, new TEventArgs<object>(IsLogin));
                    }), this.Token);
                    break;
                }
                Thread.Sleep(2000);
            }
        }
        private void GetContactList()
        {
            new Task(() => {
                GroupList groupList = new GroupList();
                int listcount = 0;
                do
                {
                    groupList = HttpHelper.GroupList(listcount, 20);
                    listcount += 50;
                    if (groupList.data.list.Count > 0)
                    {
                        foreach (var item in groupList.data.list)
                        {
                            UserInstance.Conversesion.Add(item.groupId, item);

                            asyncOperation.Post(new SendOrPostCallback(obj=>{
                                LoadConversation?.Invoke(this, new TEventArgs<GroupList_ListItem>(item));
                            }),this.Token); 
                        }
                    }
                } while (false/*groupList.data.more*/);

            }).Start();
        }
        private void StartGetMsg()
        {
            CheckException ck = new CheckException() { isLoginException = true };
            DateTime updateTime = DateTime.Now;
            do
            {
                ck = HttpHelper.CheckException(Untity.GetTimeStamp());
                if (!ck.isLoginException)
                {
                    var re = HttpHelper.GroupList(updateTime);
                    updateTime = re.data.updateTime;
                    var exg = HttpHelper.HttpGetBase<ExtGroupList>($"https://www.yunzhijia.com/im/rest/group/extGroupList?lastUpdateTime={updateTime.ToString("yyyy-MM-dd+H:mm:ss")}&_={Untity.GetTimeStamp()}");
                    if (re.data.count > 0)
                    {
                        //生成消息事件
                        asyncOperation.Post(new SendOrPostCallback((obj) =>
                        {
                            ReceiveMsg?.Invoke(this, new TEventArgs<MsgGroupList_Data>((MsgGroupList_Data)obj));
                        }), re.data); 
                    }
                }
                else
                {
                    throw new Exception("登录状态异常，请重新登录。");
                }
                Thread.Sleep(1000);
            } while (!ck.isLoginException);
        }
        public SendMessage SendMessage(string msg, string userid,string groupid = null)
        {
            if (this.IsLogin)
            {
                return HttpHelper.SendMessage(MsgType.纯文本, msg, userid, groupid);
            }
            return new SendMessage() { success = false, error = "发送失败", errorCode = 101 };
        }

    }
}
