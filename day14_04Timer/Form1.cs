using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day14_04Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = System.DateTime.Now.ToString();
            if (DateTime.Now.Hour == 21 && DateTime.Now.Minute == 59 && DateTime.Now.Second == 32 )
            {
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = @"Windows Ringin.wav";
                sp.Play();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = System.DateTime.Now.ToString();
        }
    }
}
