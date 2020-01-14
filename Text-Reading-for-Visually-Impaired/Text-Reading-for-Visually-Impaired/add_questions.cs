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
    public partial class add_questions : Form
    {
        public Add add_main;
        public add_questions(Add main)

        {
            InitializeComponent();
            this.add_main = main;
            this.CenterToScreen();
        }

        private void add_questions_Load(object sender, EventArgs e)
        {

        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            List<string> answers = new List<string>();

            if(QuestionRTB.Text != "" && RightAnswerTB.Text != "" && (Answer1TB.Text != "" || Answer2TB.Text != "" || Answer3TB.Text != ""))
            {
                answers.Add(RightAnswerTB.Text);    //add the correct answer into the list

                if(Answer1TB.Text != "")    //check if the first answer isn`t empty
                {
                    answers.Add(Answer1TB.Text);
                }
                if (Answer2TB.Text != "")   //check if the second answer isn`t empty
                {
                    answers.Add(Answer1TB.Text);
                }
                if (Answer3TB.Text != "")   //check if the third answer isn`t empty
                {
                    answers.Add(Answer1TB.Text);
                }

                question Qst = new question(QuestionRTB.Text, answers);


            }
            else
            {
                MessageBox.Show("Please fill all fields!", "Error!");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
