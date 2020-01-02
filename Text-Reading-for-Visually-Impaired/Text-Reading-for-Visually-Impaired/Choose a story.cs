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
    public partial class Choose_a_story : Form
    {
        public Student Student_main;
        public Choose_a_story(Student main)
        {
            InitializeComponent();
            this.Student_main = main;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Student_main.Show();
        }

        private void Choose_a_story_Load(object sender, EventArgs e)
        {
            this.ForeColor = Student_main.ForeColor;
            this.BackColor = Student_main.BackColor;
            foreach (Button butt in this.Controls.OfType<Button>())
            {
                butt.BackColor = Student_main.BackColor;
                butt.ForeColor = Student_main.button4.ForeColor;
            }
            foreach (Label lab in this.Controls.OfType<Label>())
            {
                lab.ForeColor = Student_main.button4.ForeColor;
            }
        }
    }
}
