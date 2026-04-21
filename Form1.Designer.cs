namespace FullyShutdown
{
    partial class Form1
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
            this.btnShutdown = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbTimeout = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnShutdown
            // 
            this.btnShutdown.Location = new System.Drawing.Point(12, 12);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(150, 50);
            this.btnShutdown.TabIndex = 0;
            this.btnShutdown.Text = "关机";
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(168, 12);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(150, 50);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "重启";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(324, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbTimeout
            // 
            this.cmbTimeout.FormattingEnabled = true;
            this.cmbTimeout.Items.AddRange(new object[] {
            "0秒 (立即)",
            "5秒",
            "10秒",
            "30秒",
            "1分钟",
            "3分钟",
            "5分钟",
            "10分钟",
            "20分钟",
            "30分钟",
            "1小时"});
            this.cmbTimeout.Location = new System.Drawing.Point(12, 78);
            this.cmbTimeout.Name = "cmbTimeout";
            this.cmbTimeout.Size = new System.Drawing.Size(150, 20);
            this.cmbTimeout.TabIndex = 3;
            this.cmbTimeout.Text = "0秒 (立即)";
            this.cmbTimeout.SelectedIndexChanged += new System.EventHandler(this.cmbTimeout_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 110);
            this.Controls.Add(this.cmbTimeout);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnShutdown);
            this.Name = "Form1";
            this.Text = "完全关机";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbTimeout;
    }
}

