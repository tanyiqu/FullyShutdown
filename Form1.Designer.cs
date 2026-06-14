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
            this.lblTimeout = new System.Windows.Forms.Label();
            this.dgvWhitelist = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKill = new System.Windows.Forms.DataGridViewButtonColumn();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelList = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWhitelist)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelList.SuspendLayout();
            this.SuspendLayout();
            //
            // btnShutdown
            //
            this.btnShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutdown.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.btnShutdown.ForeColor = System.Drawing.Color.White;
            this.btnShutdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnShutdown.FlatAppearance.BorderSize = 0;
            this.btnShutdown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnShutdown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnShutdown.Location = new System.Drawing.Point(20, 20);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(160, 48);
            this.btnShutdown.TabIndex = 0;
            this.btnShutdown.Text = "关机";
            this.btnShutdown.UseVisualStyleBackColor = false;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            //
            // btnRestart
            //
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnRestart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnRestart.Location = new System.Drawing.Point(190, 20);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(160, 48);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "重启";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            //
            // btnCancel
            //
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnCancel.Location = new System.Drawing.Point(360, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 48);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            //
            // lblTimeout
            //
            this.lblTimeout.AutoSize = true;
            this.lblTimeout.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblTimeout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblTimeout.Location = new System.Drawing.Point(20, 86);
            this.lblTimeout.Name = "lblTimeout";
            this.lblTimeout.Size = new System.Drawing.Size(54, 17);
            this.lblTimeout.TabIndex = 7;
            this.lblTimeout.Text = "延时：";
            //
            // cmbTimeout
            //
            this.cmbTimeout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimeout.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cmbTimeout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.cmbTimeout.BackColor = System.Drawing.Color.White;
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
            this.cmbTimeout.Location = new System.Drawing.Point(75, 83);
            this.cmbTimeout.Name = "cmbTimeout";
            this.cmbTimeout.Size = new System.Drawing.Size(160, 25);
            this.cmbTimeout.TabIndex = 3;
            this.cmbTimeout.Text = "0秒 (立即)";
            this.cmbTimeout.SelectedIndexChanged += new System.EventHandler(this.cmbTimeout_SelectedIndexChanged);
            //
            // panelTop
            //
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.btnShutdown);
            this.panelTop.Controls.Add(this.btnRestart);
            this.panelTop.Controls.Add(this.btnCancel);
            this.panelTop.Controls.Add(this.lblTimeout);
            this.panelTop.Controls.Add(this.cmbTimeout);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(20);
            this.panelTop.Size = new System.Drawing.Size(684, 125);
            this.panelTop.TabIndex = 8;
            //
            // dgvWhitelist
            //
            this.dgvWhitelist.AllowUserToAddRows = false;
            this.dgvWhitelist.AllowUserToDeleteRows = false;
            this.dgvWhitelist.AllowUserToResizeRows = false;
            this.dgvWhitelist.AllowUserToResizeColumns = false;
            this.dgvWhitelist.BackgroundColor = System.Drawing.Color.White;
            this.dgvWhitelist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvWhitelist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvWhitelist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvWhitelist.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dgvWhitelist.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.dgvWhitelist.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.dgvWhitelist.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dgvWhitelist.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.dgvWhitelist.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.dgvWhitelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWhitelist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colDesc,
            this.colKill});
            this.dgvWhitelist.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvWhitelist.DefaultCellStyle.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.dgvWhitelist.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.dgvWhitelist.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.dgvWhitelist.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.dgvWhitelist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWhitelist.EnableHeadersVisualStyles = false;
            this.dgvWhitelist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dgvWhitelist.Location = new System.Drawing.Point(20, 20);
            this.dgvWhitelist.MultiSelect = false;
            this.dgvWhitelist.Name = "dgvWhitelist";
            this.dgvWhitelist.ReadOnly = true;
            this.dgvWhitelist.RowHeadersVisible = false;
            this.dgvWhitelist.RowTemplate.Height = 36;
            this.dgvWhitelist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWhitelist.ShowCellToolTips = false;
            this.dgvWhitelist.Size = new System.Drawing.Size(544, 220);
            this.dgvWhitelist.TabIndex = 4;
            //
            // colName
            //
            this.colName.HeaderText = "程序名称";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 180;
            //
            // colDesc
            //
            this.colDesc.HeaderText = "描述";
            this.colDesc.Name = "colDesc";
            this.colDesc.ReadOnly = true;
            this.colDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            //
            // colKill
            //
            this.colKill.HeaderText = "运行状态 / 操作";
            this.colKill.Name = "colKill";
            this.colKill.ReadOnly = true;
            this.colKill.Text = "未运行";
            this.colKill.UseColumnTextForButtonValue = false;
            this.colKill.Width = 130;
            //
            // btnAdd
            //
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnAdd.Location = new System.Drawing.Point(574, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "+ 添加程序";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += btnAdd_Click;
            //
            // btnRemove
            //
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnRemove.FlatAppearance.BorderSize = 1;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.btnRemove.Location = new System.Drawing.Point(574, 66);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 36);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "- 移除选中";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += btnRemove_Click;
            //
            // panelList
            //
            this.panelList.BackColor = System.Drawing.Color.White;
            this.panelList.Controls.Add(this.dgvWhitelist);
            this.panelList.Controls.Add(this.btnAdd);
            this.panelList.Controls.Add(this.btnRemove);
            this.panelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelList.Location = new System.Drawing.Point(0, 125);
            this.panelList.Name = "panelList";
            this.panelList.Padding = new System.Windows.Forms.Padding(20);
            this.panelList.Size = new System.Drawing.Size(684, 260);
            this.panelList.TabIndex = 9;
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(684, 385);
            this.Controls.Add(this.panelList);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "Form1";
            this.Text = "完全关机";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWhitelist)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTimeout;
        private System.Windows.Forms.ComboBox cmbTimeout;
        private System.Windows.Forms.DataGridView dgvWhitelist;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc;
        private System.Windows.Forms.DataGridViewButtonColumn colKill;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelList;
    }
}
