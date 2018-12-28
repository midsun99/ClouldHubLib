using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I9Test.MyControl
{
    public partial class TimeMsg : UserControl
    {
        public TimeMsg(string msg)
        {
            InitializeComponent();
            this.Size = txb_msg.Size;
            txb_msg.TextAlign = HorizontalAlignment.Center;
            txb_msg.ForeColor = Color.AntiqueWhite;
            txb_msg.Text = msg;
        }
    }
}
