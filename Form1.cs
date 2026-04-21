using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FullyShutdown
{
    public partial class Form1 : Form
    {
        private int TIMEOUT = 0;

        public Form1()
        {
            InitializeComponent();
            try
            {
                // 尝试从应用程序目录加载图标
                string iconPath = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "icon.ico");
                if (System.IO.File.Exists(iconPath))
                {
                    this.Icon = new System.Drawing.Icon(iconPath);
                }
                else
                {
                    // 尝试从项目根目录加载图标（用于调试）
                    iconPath = System.IO.Path.Combine(System.IO.Directory.GetParent(System.Windows.Forms.Application.StartupPath).Parent.FullName, "icon.ico");
                    if (System.IO.File.Exists(iconPath))
                    {
                        this.Icon = new System.Drawing.Icon(iconPath);
                    }
                }
            }
            catch { }
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            ExecuteCommand($"shutdown -f -s -t {TIMEOUT}");
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
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
    }
}
