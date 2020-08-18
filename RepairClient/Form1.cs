using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RepairClient
{
    public partial class Form1 : Form
    {
        private bool install_cfg;
        private bool sql_cfg;
        private bool url_cfg;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.Description = "请选择 雨枫OA办公系统 所在文件夹";
            dialog.ShowNewFolderButton = false;
            dialog.ShowDialog();
            OAPath.Text = dialog.SelectedPath;
        }
    }
}
