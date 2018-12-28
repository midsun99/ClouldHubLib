using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LYDLib.CloudHub.Models.Result;
using System.Net;
using System.IO;
using LYDLib.CloudHub.Service;
using LYDLib.Common;
using LYDLib.Common.Models;

namespace I9Test.MyControl
{
    public partial class CoversationCard : UserControl
    {
        private string _groupname;
        private string _lastmsg;
        private string _header;
        private int _unreadnum;
        public event EventHandler<TEventArgs<KeyValuePair<string,string>>> Clicked;
        public string Groupname
        {
            get{return _groupname;}
            set
            {
                _groupname = value;
                if(value.Length > 10)
                {
                    txb_groupname.Text = value.Substring(0, 8) + "...";
                }
                else
                {
                    txb_groupname.Text = value;
                }
            }
        }
        public string Lastmsg
        {
            get{return _lastmsg;}
            set
            {
                _lastmsg = value;
                if (value.Length > 15)
                {
                    txba_lastmsg.Text = value.Substring(0, 13) + "...";
                }
                else
                {
                    txba_lastmsg.Text = value;
                }
            }
        }
        public string Header
        {
            get { return _header; }
            set { _header = value; SetHeader(value); }
        }
        public int UnreadNum
        {
            get { return _unreadnum; }  
            set
            {
                _unreadnum = value;
                if(value < 1)
                {
                    this.pib_unread.Image = null;
                }
                else
                {
                    this.pib_unread.Image = Untity.DrawUnreadNum(value,new Size(pib_unread.Width, pib_unread.Height));
                }
            }
        }
        public string GroupID { get; set; }
        private void SetHeader(string url)
        {
            try
            {
                pic_header.Image =Untity.ConvertToCircle(HttpHelper.LoadPicture("https://www.yunzhijia.com" + url));
            }
            catch (Exception ex)
            {
                pic_header.Image = null;
                Console.WriteLine("下载头像出错："+ ex.Message);
            }
        }
        public CoversationCard()
        {
            InitializeComponent();
        }
        public CoversationCard(GroupList_ListItem group)
        {
            InitializeComponent();
            this.Groupname = group.groupName;
            this.GroupID = group.groupId;
            this.Lastmsg = group.lastMsgContent;
            this.Header = group.headerUrl;
            this.UnreadNum = group.unreadCount; 
            txb_lasttime.Text = group.lastMsgSendTime.ToShortTimeString();
        }

        private void CoversationCard_Click(object sender, EventArgs e)
        {
            ClickEvent(sender, e);
        }

        private void pl_top_MouseClick(object sender, MouseEventArgs e)
        {
            ClickEvent(sender, e);
        }
        private void ClickEvent(object sender, EventArgs e)
        {
            KeyValuePair<string, string> re = new KeyValuePair<string, string>(this.GroupID, this.Groupname); 
            Clicked.Invoke(sender,new TEventArgs<KeyValuePair<string, string>>(re));
            
        }
        private void pic_header_Click(object sender, EventArgs e)
        {
            ClickEvent(sender, e);
        }

        private void txb_groupname_Click(object sender, EventArgs e)
        {
            ClickEvent(sender, e);
        }

        private void txba_lastmsg_Click(object sender, EventArgs e)
        {
            ClickEvent(sender, e);
        }

        private void pib_unread_Click(object sender, EventArgs e)
        {
            ClickEvent(sender, e);
        }

        private void txb_lasttime_Click(object sender, EventArgs e)
        {
            ClickEvent(sender, e);
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            ClickEvent(sender, e);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            ClickEvent(sender, e);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            ClickEvent(sender, e);
        }
    }
}
