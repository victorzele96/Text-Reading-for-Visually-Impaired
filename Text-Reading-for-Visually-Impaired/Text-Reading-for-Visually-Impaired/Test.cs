using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Reading_for_Visually_Impaired
{
    public partial class Test : Form
    {
        private bool isCollapsed;
        public Test()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelDropDown.Height += 10;
                if (panelDropDown.Size == panelDropDown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panelDropDown.Height -= 10;
                if (panelDropDown.Size == panelDropDown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void plusPicture_Click(object sender, EventArgs e)
        {
            foreach (Control obj in this.Controls)
            {
                if (obj is Panel)
                {
                    foreach (Control obj2 in obj.Controls)
                    {
                        if (obj2 is Label || obj2 is TextBox || obj2 is RichTextBox || obj2 is Button)
                        {
                            obj2.Font = new Font(obj2.Font.FontFamily, obj2.Font.Size + 2f, obj2.Font.Style);
                        }
                    }
                }
                else if (obj is Label || obj is TextBox || obj is RichTextBox || obj is Button)
                {
                    obj.Font = new Font(obj.Font.FontFamily, obj.Font.Size + 2f, obj.Font.Style);
                }
               


            }
        }

        protected void locateControls()
        {

        }

        private void minusPicture_Click(object sender, EventArgs e)
        {
            foreach (Control obj in this.Controls)
            {
                if (obj is Panel)
                {
                    foreach (Control obj2 in obj.Controls)
                    {
                        if (obj2 is Label || obj2 is TextBox || obj2 is RichTextBox || obj2 is Button)
                        {
                            if (obj2.Font.Size > 16)
                            {
                                obj2.Font = new Font(obj2.Font.FontFamily, obj2.Font.Size - 2f, obj2.Font.Style);
                            }
                        }
                    }
                }
                else if(obj is Label || obj is TextBox || obj is RichTextBox || obj is Button)
                {
                    if (obj.Font.Size > 16)
                    {
                        obj.Font = new Font(obj.Font.FontFamily, obj.Font.Size - 2f, obj.Font.Style);
                    }
                }
                /*else
                {
                    obj.Width = Convert.ToInt32(obj.Width * 0.9);
                    obj.Height = Convert.ToInt32(obj.Height * 0.9);
                }*/
                

            }
        }
    }
}
