﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day16_05摇奖机应用程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool b = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (b == false)
            {
                b = true;
                button1.Text = "暂停";
                Thread th = new Thread(PlayGame);
                th.IsBackground = true;
                th.Start();
            }
            else
            {
                b = false;
                button1.Text = "开始";
            }
            
        }

        private void PlayGame()
        {
            Random r = new Random();
            while (b)
            {
                label1.Text = r.Next(0, 10).ToString();
                label2.Text = r.Next(0, 10).ToString();
                label3.Text = r.Next(0, 10).ToString();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
