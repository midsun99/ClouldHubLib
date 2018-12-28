namespace I9Test.MyControl
{
    partial class TextMsgRight
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txb_sender = new System.Windows.Forms.TextBox();
            this.txb_content = new System.Windows.Forms.TextBox();
            this.pic_header = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_header)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Enabled = false;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pic_header);
            this.splitContainer1.Size = new System.Drawing.Size(527, 77);
            this.splitContainer1.SplitterDistance = 447;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Enabled = false;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txb_sender);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txb_content);
            this.splitContainer2.Size = new System.Drawing.Size(447, 77);
            this.splitContainer2.SplitterDistance = 29;
            this.splitContainer2.TabIndex = 0;
            // 
            // txb_sender
            // 
            this.txb_sender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_sender.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txb_sender.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_sender.Location = new System.Drawing.Point(0, 8);
            this.txb_sender.Name = "txb_sender";
            this.txb_sender.ReadOnly = true;
            this.txb_sender.Size = new System.Drawing.Size(447, 21);
            this.txb_sender.TabIndex = 0;
            this.txb_sender.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txb_content
            // 
            this.txb_content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_content.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txb_content.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_content.Location = new System.Drawing.Point(0, 23);
            this.txb_content.Name = "txb_content";
            this.txb_content.ReadOnly = true;
            this.txb_content.Size = new System.Drawing.Size(447, 21);
            this.txb_content.TabIndex = 0;
            this.txb_content.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pic_header
            // 
            this.pic_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_header.Location = new System.Drawing.Point(0, 0);
            this.pic_header.Name = "pic_header";
            this.pic_header.Size = new System.Drawing.Size(76, 77);
            this.pic_header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_header.TabIndex = 0;
            this.pic_header.TabStop = false;
            // 
            // TextMsgRight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "TextMsgRight";
            this.Size = new System.Drawing.Size(527, 77);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_header)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox pic_header;
        private System.Windows.Forms.TextBox txb_sender;
        private System.Windows.Forms.TextBox txb_content;
    }
}
