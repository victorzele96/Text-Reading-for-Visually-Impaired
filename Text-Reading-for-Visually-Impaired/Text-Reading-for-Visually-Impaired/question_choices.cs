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
            //this.panel1.Controls.Add(new questioPanel( new question("q", "how long this night is gonna be?", new List<String> { "1 hour", "2 hour", "3 hour", "4 hour" }, 1)));
            foreach(question q in myStory.questions)
            {
                questioPanel p = new questioPanel(new question(q.ID, q.questionString, q.answers));
                this.panel1.Controls.Add(p);
                p.Location = new Point(0, p.Height * questionsCounter);
                questionsCounter++;
            }
        }
        public void set_Question_Panels()
        {
           //this.panel1.Controls.Add(new questioPanel())
        }
    }
}
