﻿using System;
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
    public partial class question_choices : Form
    {
        public second_Page main;
        public int questionsCounter=0;
        public story myStory;
        public question_choices(second_Page sp, story myStory)
        {
            main = sp;
            this.myStory = myStory; ;
            this.BackColor = main.BackColor;
            this.ForeColor = main.insertTxtLb.ForeColor;
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void question_choices_Load(object sender, EventArgs e)
        {
            this.Size = ClientSize;
            this.panel1.Width = this.Width;
            this.panel1.Height = this.Height - this.button1.Height * 2 - 10;
            this.panel1.Location = new Point(0, 0);
            this.button1.Location = new Point(this.button1.Location.X,this.panel1.Location.Y + this.panel1.Height +2 );
            this.button2.Location = new Point(this.button2.Location.X, button1.Location.Y ) ;
            int locationKeeper = 0;
            foreach(question q in myStory.questions)
            {
                questioPanel p = new questioPanel(new question(q.ID, q.questionString, q.answers));
                this.panel1.Controls.Add(p);
                p.Size = new Size(panel1.Width, 200);
                p.Location = new Point(0, locationKeeper);
                questionsCounter++;
                locationKeeper += p.Height +4;
            }
        }
        public void set_Question_Panels()
        {
           //this.panel1.Controls.Add(new questioPanel())
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
