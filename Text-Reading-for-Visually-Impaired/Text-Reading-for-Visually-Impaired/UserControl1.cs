using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Text_Reading_for_Visually_Impaired
{
    public partial class questioPanel : UserControl
    {
        public question question;
        public int correctAnsIndex;
        public List<Label> RBDict;
        public String rightAns;
        public Boolean isAnswered;
        public Boolean correctlyAnswered;
        public Color backColor;
        public Color foreColor;
        public Font font;
        question_choices main;
        SpeechSynthesizer synth;


        public questioPanel(question_choices main, question q,Font font , Color backColor,Color foreColor)
        {
            InitializeComponent();
            question = q;
            this.main = main;
            this.rightAns = q.answers[0];
            this.synth = main.synth;
            correctlyAnswered = false;
            isAnswered = false;
            RBDict = new List<Label>() {this.LB1 , this.LB2,this.LB3,this.LB4};
            //initialRadioButtons();
            panel1.BackColor = backColor;
            this.backColor = backColor;
            this.foreColor = foreColor;
            this.font = font;
            this.label1.Text = question.questionString;
            this.LB1.Font = label1.Font;
            this.LB2.Font = label1.Font;
            this.LB3.Font = label1.Font;
            this.LB4.Font = label1.Font;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void initialRadioButtons()
        {
            Random r = new Random();
            int rInt = r.Next(0, 3);
            int indexCounter = 0;
            for (int i = 0; i < 4; i++)
            {
                if (question.answers[rInt] != null && question.answers[rInt] != "" && question.answers[rInt] != " ")
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
            foreach (Control c in panel1.Controls)
            {
                if (c is myCheckBox)
                {
                    ((myCheckBox)c).Font = font;
                    ((myCheckBox)c).BackColor = backColor;
                    ((myCheckBox)c).RB1.Checked = false;
                    ((myCheckBox)c).ForeColor = foreColor;
                }
            }
        }

        private void questioPanel_SizeChanged(object sender, EventArgs e)
        {
            //this.label1.Width = panel1.Width;
        }

        private void ans1RB_CheckedChanged(object sender, EventArgs e)
        {
            isAnswered = true;
            foreach (myCheckBox rb in panel1.Controls)
            {
                if (rb.Checked)
                {
                    if (rb.label1.Text == rightAns)
                    {
                        correctlyAnswered = true;
                    }
                    else
                    {
                        correctlyAnswered = false;
                    }
                }
            }
        }

        private void ans2RB_CheckedChanged(object sender, EventArgs e)
        {
            this.isAnswered = true;
            foreach(Control rb in panel1.Controls)
            {
                if(rb is myCheckBox)
                {
                    if (((myCheckBox)rb).Checked)
                    {
                        if (((myCheckBox)rb).label1.Text == question.answers[0])
                        {
                            correctlyAnswered = true;
                        }
                    }
                }
                
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            synth.Dispose();
            synth = new SpeechSynthesizer();
            String Text_To_Read;
            if(label1.Text.Contains("__"))
            {
                Text_To_Read ="complete the sentence. " + label1.Text.Replace('_', '.') + ". " + LB1.Text + ". " +LB2.Text + ". " +LB4.Text + ". " + LB3.Text;
            }
            else
            {
                Text_To_Read = label1.Text + "? " +LB1.Text + ". " +LB2.Text + ". " + LB4.Text + ". " + LB3.Text;
            }

            synth.SpeakAsync(Text_To_Read);
        }

        private void myCheckBox1_Load(object sender, EventArgs e)
        {
            
        }

        private void myCheckBox2_Load(object sender, EventArgs e)
        {
            
        }

        private void myCheckBox3_Load(object sender, EventArgs e)
        {
            
        }

        private void myCheckBox4_Load(object sender, EventArgs e)
        {
           
        }

        private void myCB4_Click(object sender, EventArgs e)
        {
            this.isAnswered = true;
            if (RBDict[3].Text == question.answers[0])
            {
                correctlyAnswered = true;
            }

            /*
                        foreach (Control rb in panel1.Controls)
                        {
                            if (rb is RadioButton)
                            {
                                if (RBDict[3].Text == question.answers[0])
                                {
                                    correctlyAnswered = true;
                                }
                            }

                        }*/
        }

        private void myCB1_Click(object sender, EventArgs e)
        {
            
        }

        private void myCB2_Click(object sender, EventArgs e)
        {
        }

        private void myCB3_Click(object sender, EventArgs e)
        {
          
        }

        public void rbClicked(String name)
        {
        }

        private void myCB2_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {
            RB3.Checked = true;
        }

        private void RB2_CheckedChanged(object sender, EventArgs e)
        {
            this.isAnswered = true;
            if (RBDict[1].Text == question.answers[0])
            {
                correctlyAnswered = true;
            }
        }

        private void LB1_Click(object sender, EventArgs e)
        {
            RB1.Checked = true;
        }

        private void LB4_Click(object sender, EventArgs e)
        {
            RB4.Checked = true;
        }

        private void LB2_Click(object sender, EventArgs e)
        {
            RB2.Checked = true;
        }

        private void RB4_CheckedChanged(object sender, EventArgs e)
        {
            this.isAnswered = true;
            if (RBDict[3].Text == question.answers[0])
            {
                correctlyAnswered = true;
            }
        }

        private void RB3_CheckedChanged(object sender, EventArgs e)
        {
            this.isAnswered = true;
            if (RBDict[2].Text == question.answers[0])
            {
                correctlyAnswered = true;
            }
        }

        private void RB1_CheckedChanged(object sender, EventArgs e)
        {
            this.isAnswered = true;
            if (RBDict[0].Text == question.answers[0])
            {
                correctlyAnswered = true;
            }
        }
    }
    

}
