namespace FullyShutdown
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbTimeout = new System.Windows.Forms.ComboBox();
            this.dgvWhitelist = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKill = new System.Windows.Forms.DataGridViewButtonColumn();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
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
            // dgvWhitelist
            // 
            this.dgvWhitelist.AllowUserToAddRows = false;
            this.dgvWhitelist.AllowUserToDeleteRows = false;
            this.dgvWhitelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWhitelist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colDesc,
            this.colKill});
            this.dgvWhitelist.Location = new System.Drawing.Point(12, 115);
            this.dgvWhitelist.MultiSelect = false;
            this.dgvWhitelist.Name = "dgvWhitelist";
            this.dgvWhitelist.ReadOnly = true;
            this.dgvWhitelist.RowHeadersVisible = false;
            this.dgvWhitelist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWhitelist.Size = new System.Drawing.Size(450, 172);
            this.dgvWhitelist.TabIndex = 4;
            // 
            // colName
            // 
            this.colName.HeaderText = "程序名称";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 150;
            // 
            // colDesc
            // 
            this.colDesc.HeaderText = "描述";
            this.colDesc.Name = "colDesc";
            this.colDesc.ReadOnly = true;
            this.colDesc.Width = 180;
            // 
            // colKill
            // 
            this.colKill.HeaderText = "运行状态/操作";
            this.colKill.Name = "colKill";
            this.colKill.ReadOnly = true;
            this.colKill.Text = "未运行";
            this.colKill.UseColumnTextForButtonValue = false;
            this.colKill.Width = 100;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(468, 115);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "添加程序";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(468, 150);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 30);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "移除选中";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += btnRemove_Click;
            // 
            // timerStatus
            // 
            this.timerStatus.Enabled = true;
            this.timerStatus.Interval = 5000;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 290);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvWhitelist);
            this.Controls.Add(this.cmbTimeout);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnShutdown);
            this.Name = "Form1";
            this.Text = "完全关机";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbTimeout;
        private System.Windows.Forms.DataGridView dgvWhitelist;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc;
        private System.Windows.Forms.DataGridViewButtonColumn colKill;
        private System.Windows.Forms.Timer timerStatus;
    }
}