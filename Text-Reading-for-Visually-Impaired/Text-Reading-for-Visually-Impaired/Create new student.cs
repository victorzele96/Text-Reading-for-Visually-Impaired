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
    public partial class Create_new_student : Form
    {
        public Teacher Teacher_main;
        public Create_new_student(Teacher main)
        {
            InitializeComponent();
            this.Teacher_main = main;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Teacher_main.Show();
            //this.Close();
        }
    }
}
