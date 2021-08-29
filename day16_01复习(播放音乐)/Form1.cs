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

namespace day16_01复习_播放音乐_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //string[] path = Directory.GetFiles(@"H:\Music", "*.wav");
        private void Form1_Load(object sender, EventArgs e)
        {
            
            //for (int i = 0; i < path.Length; i++)
            //{
            //    //Console.WriteLine(path[i]);
            //    listBox1.Items.Add(Path.GetFileName(path[i]));


            //}
            //Console.ReadKey();
        }

        List<string> list = new List<string>();
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择要打开的文件：";
            ofd.Filter = "音乐文件|*.wav";
            ofd.Multiselect = true;
            ofd.ShowDialog();
            
            string[] path = ofd.FileNames;
            list.AddRange(path);
            for (int i = 0; i < path.Length; i++)
            {
                listBox1.Items.Add(Path.GetFileName(path[i]));
            }
           
        }

        SoundPlayer sp = new SoundPlayer();
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            
            sp.SoundLocation = list[listBox1.SelectedIndex];
            sp.Play();
        }
       
        /// <summary>
        /// 下一首
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            index++;
            //Console.WriteLine(index);
            //Console.WriteLine(path.Length);
            if (index == list.Count)
            {
                index = 0;
            }
            listBox1.SelectedIndex = index;
            sp.SoundLocation = list[listBox1.SelectedIndex];
            sp.Play();
        }
        /// <summary>
        /// 下一首
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            //index--;
            if (index == 0)
            {
                index = list.Count - 1;
            }
            else
            {
                index--;
            }
            listBox1.SelectedIndex = index;
            sp.SoundLocation = list[listBox1.SelectedIndex];
            sp.Play();
        }

       
    }
}
