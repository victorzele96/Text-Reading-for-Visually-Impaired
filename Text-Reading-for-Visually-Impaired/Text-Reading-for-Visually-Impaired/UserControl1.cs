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
        public List<RadioButton> RBDict;
        public String rightAns;
        public Boolean isAnswered;
        public Boolean correctlyAnswered;
        public Color backColor;
        public Color foreColor;
        public Font font;
        SpeechSynthesizer synth = new SpeechSynthesizer();


        public questioPanel(question q,Font font , Color backColor,Color foreColor)
        {
            InitializeComponent();
            question = q;
            this.ans1RB.Hide();
            this.ans2RB.Hide();
            this.ans3RB.Hide();
            this.ans4RB.Hide();
            this.rightAns = q.answers[0];
            correctlyAnswered = false;
            isAnswered = false;
            RBDict = new List<RadioButton>() {this.ans1RB , this.ans2RB,this.ans3RB,this.ans4RB};
            initialRadioButtons();
            panel1.BackColor = backColor;
            this.backColor = backColor;
            this.foreColor = foreColor;
            this.font = font;
            this.label1.Text = question.questionString;
            synth = new SpeechSynthesizer();


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
                //rInt = r.Next(0,3);
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
                if (c is RadioButton)
                {
                    ((RadioButton)c).Font = font;
                    ((RadioButton)c).BackColor = backColor;
                    ((RadioButton)c).Checked = false;
                    ((RadioButton)c).ForeColor = foreColor;
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
            foreach (RadioButton rb in panel1.Controls)
            {
                if (rb.Checked)
                {
                    if (rb.Text == rightAns)
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
                if(rb is RadioButton)
                {
                    if (((RadioButton)rb).Checked)
                    {
                        if (rb.Text == question.answers[0])
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
            string Text_To_Read = label1.Text + "." + ans1RB.Text+ "."  + ans2RB.Text + "." + ans3RB.Text + "." + ans4RB.Text;
            synth.SpeakAsync(Text_To_Read);
        }
    }

}
