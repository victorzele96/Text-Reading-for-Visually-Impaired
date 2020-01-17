using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Reading_for_Visually_Impaired
{
    public partial class myCheckBox : UserControl
    {
        public Boolean Checked;
        questioPanel main;
        public myCheckBox(questioPanel main,myCheckBox mycb)
        {
            InitializeComponent();
            this.Checked = false;
            this.label1.Font = this.Font;
            this.main = main;
            this.Click += new System.EventHandler(clicked);
            this.Size = mycb.Size;
            this.Font = mycb.Font;
            this.BackColor = mycb.BackColor;
            this.label1.Size = mycb.label1.Size;
            this.label1.Font = mycb.label1.Font;
          //  label1.Click += this.Click;
            
        }

        public myCheckBox()
        {
            InitializeComponent();
            this.Checked = false;
            this.label1.Font = this.Font;
            this.Click += new System.EventHandler(clicked);

        }

        private void myCheckBox_Load(object sender, EventArgs e)
        {
           
            
        }

        public void clicked(object sender, EventArgs e)
        {
            this.RB1.Checked = true;
            this.Checked = true;
        }

        private void label1_BackColorChanged(object sender, EventArgs e)
        {
            this.BackColor = label1.BackColor;
            RB1.BackColor = label1.BackColor;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.RB1.Checked = true;
            this.Checked = true;
        }

        private void myCheckBox_BackColorChanged(object sender, EventArgs e)
        {
            this.label1.BackColor = this.BackColor;
            this.RB1.BackColor = this.BackColor;
        }

        private void RB1_CheckedChanged(object sender, EventArgs e)
        {
            this.Checked = RB1.Checked;
            try
            {
                main.rbClicked(this.Name);
            }catch(Exception)
            {

            }
        }

        private void myCheckBox_ForeColorChanged(object sender, EventArgs e)
        {
            this.label1.ForeColor = this.ForeColor;
        }

        private void myCheckBox_FontChanged(object sender, EventArgs e)
        {
            this.label1.Font = this.Font;
        }

        private void RB1_Click(object sender, EventArgs e)
        {
            this.RB1.Checked = true;
            this.Checked = true;
        }
    }
}
