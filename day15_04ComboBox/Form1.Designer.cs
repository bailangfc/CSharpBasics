namespace day15_04ComboBox
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cboyear = new System.Windows.Forms.ComboBox();
            this.cbomonth = new System.Windows.Forms.ComboBox();
            this.cboday = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboyear
            // 
            this.cboyear.FormattingEnabled = true;
            this.cboyear.Location = new System.Drawing.Point(169, 135);
            this.cboyear.Name = "cboyear";
            this.cboyear.Size = new System.Drawing.Size(121, 20);
            this.cboyear.TabIndex = 0;
            this.cboyear.SelectedIndexChanged += new System.EventHandler(this.cboyear_SelectedIndexChanged);
            // 
            // cbomonth
            // 
            this.cbomonth.FormattingEnabled = true;
            this.cbomonth.Location = new System.Drawing.Point(366, 135);
            this.cbomonth.Name = "cbomonth";
            this.cbomonth.Size = new System.Drawing.Size(121, 20);
            this.cbomonth.TabIndex = 1;
            this.cbomonth.SelectedIndexChanged += new System.EventHandler(this.cbomonth_SelectedIndexChanged);
            // 
            // cboday
            // 
            this.cboday.FormattingEnabled = true;
            this.cboday.Location = new System.Drawing.Point(574, 134);
            this.cboday.Name = "cboday";
            this.cboday.Size = new System.Drawing.Size(121, 20);
            this.cboday.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboday);
            this.Controls.Add(this.cbomonth);
            this.Controls.Add(this.cboyear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboyear;
        private System.Windows.Forms.ComboBox cbomonth;
        private System.Windows.Forms.ComboBox cboday;
    }
}

