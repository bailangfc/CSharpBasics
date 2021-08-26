using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day15_04ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int year = System.DateTime.Now.Year;
            for (int i = year; i >= 1949; i--)
            {
                cboyear.Items.Add(i + "年");

            }
        }

        private void cboyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbomonth.Items.Clear();
            for (int i = 1; i < 13; i++)
            {
                cbomonth.Items.Add(i + "月");

            }
        }

        private void cbomonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboday.Items.Clear();
            int day = 0;
            //MessageBox.Show(cboyear.SelectedItem.ToString());
            string stryear = cboyear.SelectedItem.ToString().Split(new char[] { '年' }, StringSplitOptions.RemoveEmptyEntries)[0];
            string strmonth = cbomonth.SelectedItem.ToString().Split(new char[] { '月' }, StringSplitOptions.RemoveEmptyEntries)[0];
            int year = int.Parse(stryear);
            int month = int.Parse(strmonth);
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    day = 31;
                    break;
                case 2:
                    if ((year % 400 == 0) || (year % 4 == 0) && (year % 100 != 0))
                    {
                        day = 29;
                    }
                    else
                    {
                        day = 28;
                    }
                    break;
                default:
                    day = 30;
                    break;
            }
            for (int i = 1; i <= day; i++)
            {
                cboday.Items.Add(i + "日");
            }
        }
    }
}
