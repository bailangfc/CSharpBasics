using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day15_03浏览器控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string str = textBox1.Text;
            //Uri u = new Uri("http://"+str);
            //webBrowser1.Url = u;
            //webBrowser1.Url = str;
          //string a=  textBox1.Text;
        }
    }
}
