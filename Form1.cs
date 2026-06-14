using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace FullyShutdown
{
    public partial class Form1 : Form
    {
        private int TIMEOUT = 0;
        private List<WhitelistItem> whitelist = new List<WhitelistItem>();

        public class WhitelistItem
        {
            public string Name { get; set; }
            public string Desc { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            SetupGridStyle();
            dgvWhitelist.CellContentClick += dgvWhitelist_CellContentClick;
            LoadWhitelist();
            try
            {
                string iconPath = Path.Combine(Application.StartupPath, "icon.ico");
                if (File.Exists(iconPath))
                {
                    this.Icon = new System.Drawing.Icon(iconPath);
                }
                else
                {
                    iconPath = Path.Combine(Directory.GetParent(Application.StartupPath).Parent.FullName, "icon.ico");
                    if (File.Exists(iconPath))
                    {
                        this.Icon = new System.Drawing.Icon(iconPath);
                    }
                }
            }
            catch { }
        }

        private void SetupGridStyle()
        {
            dgvWhitelist.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvWhitelist.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            dgvWhitelist.CellPainting += dgvWhitelist_CellPainting;
        }

        private void dgvWhitelist_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvWhitelist.Columns["colKill"].Index) return;

            string value = e.FormattedValue != null ? e.FormattedValue.ToString() : "";
            bool isRunning = value == "强制关闭";

            e.PaintBackground(e.CellBounds, true);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (System.Drawing.StringFormat sf = new System.Drawing.StringFormat())
            {
                sf.Alignment = System.Drawing.StringAlignment.Center;
                sf.LineAlignment = System.Drawing.StringAlignment.Center;
                sf.FormatFlags = System.Drawing.StringFormatFlags.NoWrap;

                if (isRunning)
                {
                    System.Drawing.Rectangle btnRect = new System.Drawing.Rectangle(
                        e.CellBounds.X + 10, e.CellBounds.Y + 6, e.CellBounds.Width - 20, e.CellBounds.Height - 12);
                    using (System.Drawing.SolidBrush btnBrush = new System.Drawing.SolidBrush(
                        System.Drawing.Color.FromArgb(198, 40, 40)))
                    using (System.Drawing.SolidBrush txtBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White))
                    using (System.Drawing.Font btnFont = new System.Drawing.Font("微软雅黑", 8.5F, System.Drawing.FontStyle.Bold))
                    {
                        System.Drawing.Drawing2D.GraphicsPath path = GetRoundedRect(btnRect, 6);
                        e.Graphics.FillPath(btnBrush, path);
                        e.Graphics.DrawString(value, btnFont, txtBrush, btnRect, sf);
                    }
                }
                else
                {
                    using (System.Drawing.SolidBrush txtBrush = new System.Drawing.SolidBrush(
                        System.Drawing.Color.FromArgb(107, 114, 128)))
                    using (System.Drawing.Font txtFont = new System.Drawing.Font("微软雅黑", 8.5F))
                    {
                        e.Graphics.DrawString("— 未运行 —", txtFont, txtBrush, e.CellBounds, sf);
                    }
                }
            }
            e.Handled = true;
        }

        private System.Drawing.Drawing2D.GraphicsPath GetRoundedRect(System.Drawing.RectangleF rect, float radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            float d = radius * 2;
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void LoadWhitelist()
        {
            whitelist.Clear();
            dgvWhitelist.Rows.Clear();
            try
            {
                string configPath = Path.Combine(Application.StartupPath, "whitelist.txt");
                if (File.Exists(configPath))
                {
                    string[] lines = File.ReadAllLines(configPath);
                    foreach (string line in lines)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            WhitelistItem item = ParseWhitelistLine(line.Trim());
                            if (item != null)
                            {
                                whitelist.Add(item);
                            }
                        }
                    }
                }
            }
            catch { }
            foreach (WhitelistItem item in whitelist)
            {
                dgvWhitelist.Rows.Add(item.Name, item.Desc, null);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshProcessStatus();
        }

        private WhitelistItem ParseWhitelistLine(string line)
        {
            try
            {
                string name = ExtractValue(line, "name");
                string desc = ExtractValue(line, "desc");
                if (!string.IsNullOrEmpty(name))
                {
                    return new WhitelistItem { Name = name, Desc = desc };
                }
            }
            catch { }
            return null;
        }

        private string ExtractValue(string line, string key)
        {
            string pattern = key + ":\"";
            int startIdx = line.IndexOf(pattern);
            if (startIdx >= 0)
            {
                startIdx += pattern.Length;
                int endIdx = line.IndexOf("\"", startIdx);
                if (endIdx > startIdx)
                {
                    return line.Substring(startIdx, endIdx - startIdx);
                }
            }
            return string.Empty;
        }

        private void SaveWhitelist()
        {
            try
            {
                string configPath = Path.Combine(Application.StartupPath, "whitelist.txt");
                List<string> lines = new List<string>();
                foreach (WhitelistItem item in whitelist)
                {
                    lines.Add($"{{name:\"{item.Name}\", desc:\"{item.Desc}\"}}");
                }
                File.WriteAllLines(configPath, lines);
            }
            catch { }
        }

        private List<WhitelistItem> GetRunningWhitelistProcesses()
        {
            List<WhitelistItem> runningProcesses = new List<WhitelistItem>();
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                try
                {
                    string processName = p.ProcessName.ToLower();
                    foreach (WhitelistItem item in whitelist)
                    {
                        string whitelistName = Path.GetFileNameWithoutExtension(item.Name).ToLower();
                        if (processName == whitelistName || processName == whitelistName + ".exe")
                        {
                            if (!runningProcesses.Contains(item))
                            {
                                runningProcesses.Add(item);
                            }
                        }
                    }
                }
                catch { }
            }
            return runningProcesses;
        }

        private bool CheckWhitelistProcesses()
        {
            List<WhitelistItem> running = GetRunningWhitelistProcesses();
            if (running.Count > 0)
            {
                string message = "以下白名单程序正在运行，请先关闭它们：\n\n";
                foreach (WhitelistItem item in running)
                {
                    message += $"• {item.Name} ({item.Desc})\n";
                }
                message += "\n关机/重启操作已取消。";
                MessageBox.Show(message, "程序正在运行", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            if (CheckWhitelistProcesses()) return;
            ExecuteCommand($"shutdown -f -s -t {TIMEOUT}");
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (CheckWhitelistProcesses()) return;
            ExecuteCommand($"shutdown -f -r -t {TIMEOUT}");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ExecuteCommand("shutdown -a");
        }

        private void cmbTimeout_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] timeoutValues = { 0, 5, 10, 30, 60, 180, 300, 600, 1200, 1800, 3600 };
            if (cmbTimeout.SelectedIndex >= 0 && cmbTimeout.SelectedIndex < timeoutValues.Length)
            {
                TIMEOUT = timeoutValues[cmbTimeout.SelectedIndex];
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "可执行文件 (*.exe)|*.exe|所有文件 (*.*)|*.*";
                openFileDialog.Title = "选择要添加到白名单的程序";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = Path.GetFileName(openFileDialog.FileName);
                    if (!whitelist.Exists(item => item.Name == fileName))
                    {
                        using (InputDialog inputDialog = new InputDialog())
                        {
                            inputDialog.Title = "输入程序描述";
                            inputDialog.LabelText = "请输入程序描述：";
                            if (inputDialog.ShowDialog() == DialogResult.OK)
                            {
                                whitelist.Add(new WhitelistItem { Name = fileName, Desc = inputDialog.InputText });
                                dgvWhitelist.Rows.Add(fileName, inputDialog.InputText, null);
                                SaveWhitelist();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("该程序已在白名单中。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvWhitelist.CurrentRow == null || dgvWhitelist.CurrentRow.IsNewRow)
            {
                MessageBox.Show("请先选中要移除的项目。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int selectedIndex = dgvWhitelist.CurrentRow.Index;
            if (selectedIndex >= 0 && selectedIndex < dgvWhitelist.Rows.Count)
            {
                string name = dgvWhitelist.Rows[selectedIndex].Cells["colName"].Value.ToString();
                string desc = dgvWhitelist.Rows[selectedIndex].Cells["colDesc"].Value.ToString();
                
                DialogResult result = MessageBox.Show(
                    $"确定要移除程序 \"{name}\" ({desc}) 吗？", 
                    "确认移除", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question);
                
                if (result == DialogResult.Yes)
                {
                    WhitelistItem item = whitelist.Find(i => i.Name == name);
                    if (item != null)
                    {
                        whitelist.Remove(item);
                        dgvWhitelist.Rows.RemoveAt(selectedIndex);
                        SaveWhitelist();
                    }
                }
            }
        }

        private void ExecuteCommand(string command)
        {
            try
            {
                Process.Start("cmd.exe", $"/c {command}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"执行命令时出错: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            RefreshProcessStatus();
        }

        private void RefreshProcessStatus()
        {
            try
            {
                foreach (DataGridViewRow row in dgvWhitelist.Rows)
                {
                    if (row.Cells["colName"].Value != null)
                    {
                        string name = row.Cells["colName"].Value.ToString();
                        bool isRunning = IsProcessRunning(name);
                        row.Cells["colKill"].Value = isRunning ? "强制关闭" : "未运行";
                    }
                }
            }
            catch { }
        }

        private bool IsProcessRunning(string fileName)
        {
            try
            {
                string targetName = Path.GetFileNameWithoutExtension(fileName).ToLower();
                Process[] processes = Process.GetProcesses();
                foreach (Process p in processes)
                {
                    try
                    {
                        string processName = p.ProcessName.ToLower();
                        if (processName == targetName || processName == targetName + ".exe")
                        {
                            return true;
                        }
                    }
                    catch { }
                }
            }
            catch { }
            return false;
        }

        private void dgvWhitelist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvWhitelist.Rows.Count) return;
            if (e.ColumnIndex == dgvWhitelist.Columns["colKill"].Index)
            {
                DataGridViewRow row = dgvWhitelist.Rows[e.RowIndex];
                if (row.Cells["colName"].Value != null)
                {
                    string cellValue = row.Cells["colKill"].Value?.ToString();
                    if (cellValue == "强制关闭")
                    {
                        string fileName = row.Cells["colName"].Value.ToString();
                        KillProcessByName(fileName);
                    }
                }
            }
        }

        private void KillProcessByName(string fileName)
        {
            try
            {
                string targetName = Path.GetFileNameWithoutExtension(fileName).ToLower();
                Process[] processes = Process.GetProcesses();
                foreach (Process p in processes)
                {
                    try
                    {
                        string processName = p.ProcessName.ToLower();
                        if (processName == targetName || processName == targetName + ".exe")
                        {
                            p.Kill();
                        }
                    }
                    catch { }
                }
                RefreshProcessStatus();
            }
            catch { }
        }
    }

    public class InputDialog : Form
    {
        private Label label;
        private TextBox textBox;
        private Button okButton;
        private Button cancelButton;

        public string Title
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public string LabelText
        {
            get { return label.Text; }
            set { label.Text = value; }
        }

        public string InputText
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        public InputDialog()
        {
            this.Text = "输入";
            this.Size = new System.Drawing.Size(300, 150);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            label = new Label();
            label.Location = new System.Drawing.Point(15, 20);
            label.Size = new System.Drawing.Size(260, 20);
            this.Controls.Add(label);

            textBox = new TextBox();
            textBox.Location = new System.Drawing.Point(15, 50);
            textBox.Size = new System.Drawing.Size(260, 20);
            this.Controls.Add(textBox);

            okButton = new Button();
            okButton.Location = new System.Drawing.Point(85, 90);
            okButton.Size = new System.Drawing.Size(60, 25);
            okButton.Text = "确定";
            okButton.DialogResult = DialogResult.OK;
            this.Controls.Add(okButton);

            cancelButton = new Button();
            cancelButton.Location = new System.Drawing.Point(150, 90);
            cancelButton.Size = new System.Drawing.Size(60, 25);
            cancelButton.Text = "取消";
            cancelButton.DialogResult = DialogResult.Cancel;
            this.Controls.Add(cancelButton);

            this.AcceptButton = okButton;
            this.CancelButton = cancelButton;
        }
    }
}