﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Text_Reading_for_Visually_Impaired
{
    public partial class story_choices : Form
    {
        second_Page main;
        List<String> myList;
        public story_choices(second_Page sp, List <String> list)
        {
            main = sp;
            myList = list;
            this.BackColor = main.BackColor;
            this.ForeColor = main.insertTxtLb.ForeColor;
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Story_choices_Load(object sender, EventArgs e)
        {
            panel1.AutoScroll = false;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = true;
            int lastLocation = 3;
            foreach (String name in myList)
            {
                RadioButton newButton = new RadioButton();
                newButton.Text = name;
                newButton.Width = panel1.Width;
                newButton.Height = 102;
                newButton.BackColor = this.BackColor;
                newButton.ForeColor = this.ForeColor;
                newButton.Font = main.richTextBox1.Font;
                panel1.Controls.Add(newButton);
                newButton.Location = new Point(2, lastLocation);
                lastLocation += newButton.Size.Height + 10;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            foreach(Control rb in panel1.Controls)
            {
                if (rb is RadioButton)
                {
                    if(((RadioButton)rb).Checked)
                    {
                        main.fillRichTextBox(((RadioButton)rb).Text);
                        break;
                    }
                }
            }
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}