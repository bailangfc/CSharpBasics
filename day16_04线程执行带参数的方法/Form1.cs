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

namespace day16_04线程执行带参数的方法
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(Test);
            th.IsBackground = true;
            th.Start("222");
           // Test();
        }

        private void Test(object s)
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
