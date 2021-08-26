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
using System.Media;

namespace day15_08双击播放音乐
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
            string[] path = Directory.GetFiles(@"H:\Music","*.wav");
            
            for (int i = 0; i < path.Length; i++)
            {
                string fileName = Path.GetFileName(path[i]);
                listBox1.Items.Add(fileName);
                list.Add(path[i]);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = list[listBox1.SelectedIndex];
            sp.Play();
        }
    }
}
