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
            //this.panel1.Width = this.Width;
            this.panel1.Height = this.Height - this.button1.Height * 2 - 10;
            this.panel1.Location = new Point(0, 0);
            this.button1.Location = new Point(this.button1.Location.X, this.panel1.Location.Y + this.panel1.Height + 2);
            this.button2.Location = new Point(this.button2.Location.X, button1.Location.Y);
            int locationKeeper = 0;
            foreach (question q in myStory.questions)
            {
                questioPanel p = new questioPanel(new question(q.ID, q.questionString, q.answers));
                this.panel1.Controls.Add(p);
                //p.Size = new Size(panel1.Width-100, 200);
                p.Location = new Point(23, locationKeeper);
                questionsCounter++;
                locationKeeper += p.Height + 10;
            }
        }
        public void set_Question_Panels()
        {
           //this.panel1.Controls.Add(new questioPanel())
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int correct = get_num_of_right_answeres();
            int answered = get_num_of_answered_questions();
            if (check_if_all_questions_answered())
            {
                if(answered == correct)
                {
                    MessageBox.Show("amazing you scored it all!!");
                }
                else if(correct < answered * 0.6)
                {
                    String msg = String.Format("you scored {0} out of {1} questions, better luck next time",correct,answered);
                    MessageBox.Show(msg);
                }
                else
                {
                    String msg = String.Format("you scored {0} out of {1} questions, good job!!",correct,answered);
                    MessageBox.Show(msg);
                }
            }
        }

        public Boolean check_if_all_questions_answered()
        {
            foreach (questioPanel qp in panel1.Controls)
            {
                if(!qp.isAnswered)
                {
                    return false;
                }
            }
            return true;
        }

        public int get_num_of_right_answeres()
        {
            int counter = 0;
            foreach (questioPanel qp in panel1.Controls)
            {
                if (qp.correctlyAnswered)
                {
                    counter++ ;
                }
            }
            return counter;
        }

        public int get_num_of_answered_questions()
        {
            int counter = 0;
            foreach (questioPanel qp in panel1.Controls)
            {
                if (qp.isAnswered)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
