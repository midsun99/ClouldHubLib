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
using LYDLib.Common;
using LYDLib.CloudHub.Service;
using static LYDLib.CloudHub.Client;

namespace I9Test.MyControl
{
    public partial class TextMsgRight : UserControl
    {
        public TextMsgRight()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Right| AnchorStyles.Top;
        }
        public TextMsgRight(MsgGroupList_ListItem msg)
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.pic_header.Image = Untity.ConvertToCircle(HttpHelper.LoadPicture(UserInstance.MyInfo.photoUrl/*"https://www.yunzhijia.com" + msg.headerUrl*/));
            this.txb_sender.Text = msg.fromUserName + " " + msg.lastMsgSendTime.ToLongTimeString();
            txb_content.Text = msg.lastMsgContent;
        }
        public TextMsgRight(string headerUrl,string fromuser,DateTime sendtime,object content)
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Right | AnchorStyles.Top; 
            this.pic_header.Image = Untity.ConvertToCircle(HttpHelper.LoadPicture(UserInstance.MyInfo.photoUrl/*"https://www.yunzhijia.com" +  headerUrl*/));
            this.txb_sender.Text = fromuser + " " + sendtime.ToLongTimeString();
            txb_content.Text = content.ToString();
        }
    }
}
