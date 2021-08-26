using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day15_07实现点击更换照片
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<string> list = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] path = Directory.GetFiles(@"H:\a","*.jpg");

            for (int i = 0; i < path.Length; i++)
            {
                string fileName = Path.GetFileName(path[i]);
                listBox1.Items.Add(fileName);
                list.Add(path[i]);

                //listBox1.Items.Add( Path.GetFileName(path[i]));
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(list[listBox1.SelectedIndex]);

        }
    }
}
