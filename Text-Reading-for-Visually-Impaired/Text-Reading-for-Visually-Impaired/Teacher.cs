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
    public partial class Teacher : Form
    {
        public Login login_main;
        public Teacher(Login main)
        {
            InitializeComponent();
            this.login_main = main;//-------------
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Send_feedback feedback = new Send_feedback(this);
            feedback.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_details update = new Update_details(this);
            update.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Creating_a_story create = new Creating_a_story(this);
            create.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Create_new_student create = new Create_new_student(this);
            create.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher_Reports report = new Teacher_Reports(this);
            report.ShowDialog();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {

        }
    }
}
