using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace day15_14记事本应用程序2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            textBox1.Location = new Point(248,28);
        }

        private void 隐藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            textBox1.Location = new Point(12, 28);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            textBox1.Location = new Point(12, 28);
        }
        List<string> list = new List<string>();
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择要打开的文件";
            ofd.Filter = "文本文件|*.txt|所有文件|*.*";
            ofd.Multiselect = true;
            ofd.InitialDirectory = @"C:\Users\bailangfc\OneDrive\桌面";
            ofd.ShowDialog();

            string path = ofd.FileName;
            list.Add(path);
            listBox1.Items.Add(Path.GetFileName(path));

            if (path == "")
            {
                return;
            }
            using(FileStream fsRead=new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int r = fsRead.Read(buffer, 0, buffer.Length);
                textBox1.Text = Encoding.Default.GetString(buffer, 0, r);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            textBox1.WordWrap = false;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "请选择要保存的文件路径";
            sfd.Filter = "文本文件|*.txt|所有文件|*.*";
            sfd.InitialDirectory = @"C:\Users\bailangfc\OneDrive\桌面";

            sfd.ShowDialog();

            string path = sfd.FileName;
            if (path == "")
            {
                return;
            }
            using(FileStream fsWrite=new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] buffer = Encoding.Default.GetBytes(textBox1.Text);
                fsWrite.Write(buffer, 0, buffer.Length);

            }
        }

        private void 自动换行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (自动换行ToolStripMenuItem.Text == "自动换行")
            {
                自动换行ToolStripMenuItem.Text = "取消自动换行";
                textBox1.WordWrap = true;
            }
            else
            {
                自动换行ToolStripMenuItem.Text = "自动换行";
                textBox1.WordWrap = false;
            }
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            textBox1.Font = fd.Font;
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            textBox1.ForeColor = cd.Color;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string path = list[listBox1.SelectedIndex];
            using(FileStream fsRead=new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int r = fsRead.Read(buffer, 0, buffer.Length);
                textBox1.Text = Encoding.Default.GetString(buffer, 0, r);

            }

        }
    }
}
