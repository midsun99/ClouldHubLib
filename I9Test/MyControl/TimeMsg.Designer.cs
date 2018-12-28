namespace I9Test.MyControl
{
    partial class TimeMsg
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
            this.txb_msg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txb_msg
            // 
            this.txb_msg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_msg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txb_msg.Location = new System.Drawing.Point(0, 0);
            this.txb_msg.Name = "txb_msg";
            this.txb_msg.Size = new System.Drawing.Size(396, 18);
            this.txb_msg.TabIndex = 0;
            this.txb_msg.Text = "2018年12月17日 21:48:33";
            // 
            // TimeMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txb_msg);
            this.Name = "TimeMsg";
            this.Size = new System.Drawing.Size(396, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_msg;
    }
}
