namespace I9Test
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btn_send;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flp_cardlist = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flp_Container = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtb_msg = new System.Windows.Forms.RichTextBox();
            btn_send = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            btn_send.AutoEllipsis = true;
            btn_send.BackColor = System.Drawing.Color.DodgerBlue;
            btn_send.Dock = System.Windows.Forms.DockStyle.Right;
            btn_send.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            btn_send.ForeColor = System.Drawing.Color.White;
            btn_send.Location = new System.Drawing.Point(630, 0);
            btn_send.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            btn_send.Name = "btn_send";
            btn_send.Size = new System.Drawing.Size(105, 48);
            btn_send.TabIndex = 3;
            btn_send.Text = "发送";
            btn_send.UseVisualStyleBackColor = false;
            btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flp_cardlist);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1009, 711);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // flp_cardlist
            // 
            this.flp_cardlist.AutoScroll = true;
            this.flp_cardlist.AutoSize = true;
            this.flp_cardlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_cardlist.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_cardlist.Location = new System.Drawing.Point(0, 0);
            this.flp_cardlist.Name = "flp_cardlist";
            this.flp_cardlist.Size = new System.Drawing.Size(268, 709);
            this.flp_cardlist.TabIndex = 0;
            this.flp_cardlist.WrapContents = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.flp_Container);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            this.splitContainer2.Panel2.Controls.Add(this.rtb_msg);
            this.splitContainer2.Size = new System.Drawing.Size(737, 711);
            this.splitContainer2.SplitterDistance = 491;
            this.splitContainer2.SplitterIncrement = 2;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // flp_Container
            // 
            this.flp_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_Container.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_Container.Location = new System.Drawing.Point(0, 0);
            this.flp_Container.Name = "flp_Container";
            this.flp_Container.Size = new System.Drawing.Size(735, 489);
            this.flp_Container.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(btn_send);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 48);
            this.panel1.TabIndex = 2;
            // 
            // rtb_msg
            // 
            this.rtb_msg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_msg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_msg.Location = new System.Drawing.Point(0, 0);
            this.rtb_msg.Name = "rtb_msg";
            this.rtb_msg.Size = new System.Drawing.Size(735, 217);
            this.rtb_msg.TabIndex = 1;
            this.rtb_msg.Text = "";
            // 
            // MainForm
            // 
            this.AcceptButton = btn_send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 711);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtb_msg;
        private System.Windows.Forms.FlowLayoutPanel flp_Container;
        private System.Windows.Forms.FlowLayoutPanel flp_cardlist;
    }
}

