﻿using System;
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
    public partial class questioPanel : UserControl
    {
        public question question;
        public int correctAnsIndex;
        Dictionary<int,RadioButton> RBDict;

        public questioPanel(question q)
        {
            InitializeComponent();
            question = q;
            this.ans1RB.Hide();
            this.ans2RB.Hide();
            this.ans3RB.Hide();
            this.ans4RB.Hide();
            RBDict = new Dictionary<int,RadioButton>() { { 1,this.ans1RB}, {2, this.ans2RB}, {3, this.ans3RB}, {4, this.ans4RB} };
            initialRadioButtons();
            this.label1.Text = question.questionString;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void initialRadioButtons()
        {
            Random r = new Random();
            int rInt = r.Next(1, 4);
            int indexCounter = 1;
            for(int i=0; i<4;i++)
            {
                if(question.answers[rInt] != null && question.answers[rInt]!="" && question.answers[rInt] != " ")
                {
                    this.RBDict[indexCounter].Text = question.answers[rInt];
                    this.RBDict[indexCounter].Show();
                    indexCounter++;
                    rInt = (rInt + 1) % 4;
                }
            }
        }

        private void questioPanel_Load(object sender, EventArgs e)
        {

        }
    }
}