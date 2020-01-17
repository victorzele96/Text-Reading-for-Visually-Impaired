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
        public bool check_test = false;
        private bool isCollapsed;
        public Boolean dontchangecolorflag =false;
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

        public void Theme_color(Color fore_color, Color back_color, Color form_back_color)
        {
            Test.ActiveForm.BackColor = form_back_color;//change form color
            foreach (Control c in this.panelDropDown.Controls)
            {
                if (c is Button)
                {
                    c.ForeColor = fore_color;
                    c.BackColor = back_color;
                }
            }

            foreach (Control c in this.Controls)
            {
                if (c is Panel && c.Name != "panelDropDown")
                {
                    c.BackColor = back_color;
                    foreach (Control v in c.Controls)
                    {

                        if (v is Button || v is Label || v is RichTextBox || v is TextBox)
                        {
                            v.ForeColor = fore_color;
                            v.BackColor = back_color;
                        }
                    }
                }
                if (c is Button && !dontchangecolorflag && !c.Name.Contains("000") || c is RichTextBox)
                {
                    c.ForeColor = fore_color;
                    c.BackColor = back_color;
                }
                if (c is Label)
                {
                    c.ForeColor = fore_color;
                    c.BackColor = form_back_color;
                }
            }
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

        private void button1_Click(object sender, EventArgs e)
        {//Default
            Theme_color(Color.Black, Color.Gainsboro, Color.Gainsboro);
        }

        private void button2_Click(object sender, EventArgs e)
        {//Option 1
            Theme_color(Color.Yellow, Color.Black, Color.Black);
        }

        private void button3_Click(object sender, EventArgs e)
        {//Option 2
            Theme_color(Color.Red, Color.Black, Color.Black);
        }

        private void button4_Click(object sender, EventArgs e)
        {//Option 3
            Theme_color(Color.Blue, Color.Yellow, Color.Yellow);
        }

        public bool CheckFontDecrease()
        {
            check_test = false;

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
                                check_test = true;
                            }
                        }
                    }
                }
                else if (obj is Label || obj is TextBox || obj is RichTextBox || obj is Button)
                {
                    if (obj.Font.Size > 16)
                    {
                        obj.Font = new Font(obj.Font.FontFamily, obj.Font.Size - 2f, obj.Font.Style);
                        check_test = true;
                    }
                }
            }
            return check_test;
        }

        public bool CheckFontIncrease()
        {
            check_test = false;

            foreach (Control obj in this.Controls)
            {
                if (obj is Panel)
                {
                    foreach (Control obj2 in obj.Controls)
                    {
                        if (obj2 is Label || obj2 is TextBox || obj2 is RichTextBox || obj2 is Button)
                        {
                            obj2.Font = new Font(obj2.Font.FontFamily, obj2.Font.Size + 2f, obj2.Font.Style);
                            check_test = true;
                        }
                    }
                }
                else if (obj is Label || obj is TextBox || obj is RichTextBox || obj is Button)
                {
                    obj.Font = new Font(obj.Font.FontFamily, obj.Font.Size + 2f, obj.Font.Style);
                    check_test = true;
                }
            }
            return check_test;
        }
    }
}
