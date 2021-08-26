using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day14_02DoYouLoveMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLove_Click(object sender, EventArgs e)
        {


            MessageBox.Show("爱你");
            this.Close();

        }

        private void btnUnLove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("不爱");
            this.Close();


        }

        private void btnUnLove_MouseEnter(object sender, EventArgs e)
        {
            int x = this.ClientSize.Width - btnUnLove.Width;
            int y = this.ClientSize.Height - btnUnLove.Height;

            //int x = this.Width - btnUnLove.Width;
            //int y = this.Height - btnUnLove.Height;
            Random r = new Random();
            btnUnLove.Location = new Point(r.Next(0, x + 1), r.Next(0, y + 1));

        }
    }
}
