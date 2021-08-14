using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day22_14窗体传值
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ShowMsg(string str)
        {
            label1.Text = str;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(ShowMsg);
            frm.ShowDialog();
        }
    }
}
