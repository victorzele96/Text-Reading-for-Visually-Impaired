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
    public partial class Student : Test
    {
        public Login main;
        public Student(Login main)
        {
            InitializeComponent();
            this.main = main;
        }
       

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Hide();
            main.Show();
            
            this.Close();
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (thems.SelectedIndex == 0)
            {
                Student.ActiveForm.BackColor = Color.White;//change form color

                button4.ForeColor = Color.Black;           //change font color
                button5.ForeColor = Color.Black;
                button6.ForeColor = Color.Black;

                button4.BackColor = Color.Gainsboro;       //change back color buttons
                button5.BackColor = Color.Gainsboro;
                button6.BackColor = Color.Gainsboro;
            }

            if (thems.SelectedIndex == 1)
            {
                Student.ActiveForm.BackColor = Color.Black;//change form color

                button4.ForeColor = Color.Yellow;           //change font color
                button5.ForeColor = Color.Yellow;
                button6.ForeColor = Color.Yellow;

                button4.BackColor = Color.Black;       //change back color buttons
                button5.BackColor = Color.Black;
                button6.BackColor = Color.Black;
            }

            if (thems.SelectedIndex == 2)
            {
                Student.ActiveForm.BackColor = Color.Gainsboro;//change form color

                button4.ForeColor = Color.Red;           //change font color
                button5.ForeColor = Color.Red;
                button6.ForeColor = Color.Red;

                button4.BackColor = Color.Black;       //change back color buttons
                button5.BackColor = Color.Black;
                button6.BackColor = Color.Black;
            }

            if (thems.SelectedIndex == 3)
            {
                Student.ActiveForm.BackColor = Color.Black;//change form color

                button4.ForeColor = Color.Yellow;           //change font color
                button5.ForeColor = Color.Yellow;
                button6.ForeColor = Color.Yellow;

                button4.BackColor = Color.Black;       //change back color buttons
                button5.BackColor = Color.Black;
                button6.BackColor = Color.Black;
            }

            if (thems.SelectedIndex == 4)
            {
                Student.ActiveForm.BackColor = Color.Black;//change form color

                button4.ForeColor = Color.Yellow;           //change font color
                button5.ForeColor = Color.Yellow;
                button6.ForeColor = Color.Yellow;

                button4.BackColor = Color.Black;       //change back color buttons
                button5.BackColor = Color.Black;
                button6.BackColor = Color.Black;
            }

            if (thems.SelectedIndex == 5)
            {
                Student.ActiveForm.BackColor = Color.Black;//change form color

                button4.ForeColor = Color.Yellow;           //change font color
                button5.ForeColor = Color.Yellow;
                button6.ForeColor = Color.Yellow;

                button4.BackColor = Color.Black;       //change back color buttons
                button5.BackColor = Color.Black;
                button6.BackColor = Color.Black;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Choose_a_story story = new Choose_a_story(this);
            story.Show();
            story.Theme_color(button6.ForeColor, button6.BackColor, this.BackColor);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Update_student_Information student_info = new Update_student_Information(this);
            student_info.Show();
            student_info.Theme_color(button6.ForeColor, button6.BackColor, this.BackColor);
        }
    }
}
