namespace I9Test.MyControl
{
    partial class CoversationCard
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_header = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pib_unread = new System.Windows.Forms.PictureBox();
            this.txba_lastmsg = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txb_groupname = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txb_lasttime = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_header)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_unread)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pic_header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 80);
            this.panel1.TabIndex = 0;
            // 
            // pic_header
            // 
            this.pic_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_header.Location = new System.Drawing.Point(0, 0);
            this.pic_header.Name = "pic_header";
            this.pic_header.Size = new System.Drawing.Size(80, 80);
            this.pic_header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_header.TabIndex = 0;
            this.pic_header.TabStop = false;
            this.pic_header.Click += new System.EventHandler(this.pic_header_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pib_unread);
            this.panel2.Controls.Add(this.txba_lastmsg);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(80, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 80);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // pib_unread
            // 
            this.pib_unread.Location = new System.Drawing.Point(246, 48);
            this.pib_unread.Name = "pib_unread";
            this.pib_unread.Size = new System.Drawing.Size(32, 32);
            this.pib_unread.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pib_unread.TabIndex = 2;
            this.pib_unread.TabStop = false;
            this.pib_unread.Click += new System.EventHandler(this.pib_unread_Click);
            // 
            // txba_lastmsg
            // 
            this.txba_lastmsg.BackColor = System.Drawing.Color.White;
            this.txba_lastmsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txba_lastmsg.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txba_lastmsg.ForeColor = System.Drawing.Color.DeepPink;
            this.txba_lastmsg.Location = new System.Drawing.Point(6, 57);
            this.txba_lastmsg.Name = "txba_lastmsg";
            this.txba_lastmsg.ReadOnly = true;
            this.txba_lastmsg.Size = new System.Drawing.Size(230, 18);
            this.txba_lastmsg.TabIndex = 1;
            this.txba_lastmsg.Text = "这里是内容描述";
            this.txba_lastmsg.Click += new System.EventHandler(this.txba_lastmsg_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txb_groupname);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 48);
            this.panel3.TabIndex = 0;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // txb_groupname
            // 
            this.txb_groupname.BackColor = System.Drawing.Color.White;
            this.txb_groupname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_groupname.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_groupname.Location = new System.Drawing.Point(6, 22);
            this.txb_groupname.Name = "txb_groupname";
            this.txb_groupname.ReadOnly = true;
            this.txb_groupname.Size = new System.Drawing.Size(230, 21);
            this.txb_groupname.TabIndex = 1;
            this.txb_groupname.Text = "这里是标题总多少个字";
            this.txb_groupname.Click += new System.EventHandler(this.txb_groupname_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txb_lasttime);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(236, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(52, 48);
            this.panel4.TabIndex = 0;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // txb_lasttime
            // 
            this.txb_lasttime.BackColor = System.Drawing.Color.White;
            this.txb_lasttime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_lasttime.Location = new System.Drawing.Point(3, 21);
            this.txb_lasttime.Name = "txb_lasttime";
            this.txb_lasttime.ReadOnly = true;
            this.txb_lasttime.Size = new System.Drawing.Size(49, 18);
            this.txb_lasttime.TabIndex = 0;
            this.txb_lasttime.Text = "10:03";
            this.txb_lasttime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_lasttime.Click += new System.EventHandler(this.txb_lasttime_Click);
            // 
            // CoversationCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CoversationCard";
            this.Size = new System.Drawing.Size(368, 80);
            this.Click += new System.EventHandler(this.CoversationCard_Click);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_header)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_unread)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_header;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pib_unread;
        private System.Windows.Forms.TextBox txba_lastmsg;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txb_groupname;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txb_lasttime;
    }
}
