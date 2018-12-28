using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I9Test
{
    public partial class QRForm : Form
    {
        public QRForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }
        public void SetQR(Image qr)
        {
            pic_qr.Image = qr;

        }
    }
}
