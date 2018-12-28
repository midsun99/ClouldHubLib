using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using I9Test.MyControl;
using LYDLib.CloudHub;
using LYDLib.CloudHub.Models.Result;
using LYDLib.CloudHub.Service;
using LYDLib.Common;
using static LYDLib.CloudHub.Client;
using static LYDLib.Common.Models.Enums;

namespace I9Test
{
    public partial class MainForm : Form
    {
        string opengroupid = null;
        private Client I9Client = new Client();
        private static QRForm qr = new QRForm();
        private delegate void AddCardDele(Control control);
        public void AddCard(Control control)
        {
            if (flp_cardlist.InvokeRequired)
            {
                flp_cardlist.Invoke(new AddCardDele(AddCard), control);
            }
            else
            {
                splitContainer1.SplitterDistance = control.Size.Width + 20;
                flp_cardlist.Controls.Add(control);
            } 
        }
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            panel1.BackColor = rtb_msg.BackColor; 
        }
        private void MainForm_Load(object sender, EventArgs e)
        { 
            I9Client.GetLoginQrCodeComplete += this.I9Client_GetLoginQrCodeComplete;
            I9Client.LoginComplete += I9Client_LoginComplete;
            I9Client.ReceiveMsg += I9Client_ReceiveMsg;
            I9Client.LoadConversation += I9Client_LoadConversation;
            I9Client.CatchException += I9Client_CatchException;
            I9Client.Start("账号", "密码");
            //qr = new QRForm(); 
            //I9Client.StartByQR();
            //qr.ShowDialog();
        }
        private void I9Client_CatchException(object sender, LYDLib.Common.Models.TEventArgs<Exception> e)
        {
            MessageBox.Show("发生异常："+e.Result.Message);
        }

        private void I9Client_LoadConversation(object sender, LYDLib.Common.Models.TEventArgs<GroupList_ListItem> e)
        {
            CoversationCard card = new CoversationCard(e.Result);
            card.Name = e.Result.groupId;
            card.Clicked += Card_Clicked;
            AddCardAsync(card); 
        }
        private  void AddCardAsync(CoversationCard cd)
        {
           new Task(()=> {
               AddCard(cd);
           }).Start();
        }
        private void Card_Clicked(object sender, LYDLib.Common.Models.TEventArgs<KeyValuePair<string, string>> e)
        {

            this.Text = e.Result.Value;
            //获取当前会话所有用户
            var re = HttpHelper.GetGroupUser(200, e.Result.Key, 0); 
            if(re!=null && re.success)
            {
                flp_Container.Controls.Clear();
                flp_Container.Tag = re;
                opengroupid = e.Result.Key;
            }
            //获取最新10条消息
            var new10msg = HttpHelper.ListMessage(10, e.Result.Key,"");
            if(new10msg!=null && new10msg.data.list.Count > 0)
            {
                CreateConversation(new10msg.data.list);
            }
            //MessageBox.Show("您点击了："+e.Result);

        }
        private void CreateConversation(List<ListMessage_ListItem> msgs)
        {
            foreach (var item in msgs)
            {
                if (item.msgType == (int)MsgType.图片)
                {

                }
                else if (item.direction == 1)
                {
                    TextMsgRight msg = new TextMsgRight(item.photoUrl,item.senderName,item.sendTime,item.content);
                    msg.Width = flp_Container.Width;
                    flp_Container.Controls.Add(msg);
                }
                else
                {
                    TextMsgLeft msg = new TextMsgLeft(item.photoUrl, item.senderName, item.sendTime, item.content);
                    msg.Width = flp_Container.Width;
                    flp_Container.Controls.Add(msg);
                }
            }
        }
        private void I9Client_ReceiveMsg(object sender, LYDLib.Common.Models.TEventArgs<LYDLib.CloudHub.Models.Result.MsgGroupList_Data> e)
        {
            foreach (var item in e.Result.list)
            {
                Console.WriteLine($"{item.groupName}:【{item.fromUserName}】说：{item.lastMsgContent}");
                if (item.direction == 1)
                {
                    TextMsgRight msg = new TextMsgRight(item);
                    msg.Width = flp_Container.Width;
                    flp_Container.Controls.Add(msg);
                }
                else
                {
                    TextMsgLeft msg = new TextMsgLeft(item);
                    msg.Width = flp_Container.Width;
                    flp_Container.Controls.Add(msg);
                }
                
                
            }
            
        }

        private void I9Client_LoginComplete(object sender, LYDLib.Common.Models.TEventArgs<object> e)
        {
            qr.Dispose();
        }

        private void I9Client_GetLoginQrCodeComplete(object sender, LYDLib.Common.Models.TEventArgs<Image> e)
        { 
            qr.SetQR(e.Result); 
        }

        private void OpenConversion()
        {
            List<MsgGroupList_ListItem> msgs = new List<MsgGroupList_ListItem>();
            foreach (var msg in msgs)
            {
                if(msg.lastMsgType == (int)MsgType.纯文本)
                {
                    flp_Container.Controls.Add(new TimeMsg(msg.lastMsg.content));
                }

            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            GruopUser g = flp_Container.Tag as GruopUser;
            if (!string.IsNullOrEmpty( rtb_msg.Text)&&g!=null )
            {
                I9Client.SendMessage(rtb_msg.Text,"", opengroupid);
                rtb_msg.Text = "";
            }
            
        }


    }
}
