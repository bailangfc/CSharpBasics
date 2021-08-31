using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day15_09石头剪刀布
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStone_Click(object sender, EventArgs e)
        {
            string str = "石头";
            NewMethod(str);
        }

        private void NewMethod(string str)
        {
            lblPlayer.Text = str;

            Player p = new Player();
            int num1 = p.ShowFirst(str);

            Computer c = new Computer();
            int num2 = c.ShowFirst();
            label4.Text = c.First;

            Result res = CaiPan.Judge(num1, num2);
            lblResult.Text = res.ToString();
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            string str = "剪刀";
            NewMethod(str);
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            string str = "布";
            NewMethod(str);
        }
    }
}
