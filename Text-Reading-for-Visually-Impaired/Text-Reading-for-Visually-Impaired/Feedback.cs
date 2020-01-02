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
    public partial class Feedback : Form
    {
        public Reports Reports_main;
        public Feedback(Reports main)
        {
            InitializeComponent();
            this.Reports_main = main;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this.Reports_main.Show();
            //this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
