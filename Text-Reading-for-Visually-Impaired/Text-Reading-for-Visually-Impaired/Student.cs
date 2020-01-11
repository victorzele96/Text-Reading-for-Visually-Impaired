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
        public Login login_main;
        public Student(Login main)
        {
            InitializeComponent();
            this.login_main = main;
        }
       

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Student_Load(object sender, EventArgs e)
        {

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

        private void button7_Click(object sender, EventArgs e)
        {
            login_main.Show();
            this.Close();
        }
    }
}
