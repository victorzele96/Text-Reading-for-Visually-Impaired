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
    public partial class Reports : Form
    {
        public Admin Admin_main;
        public Reports(Admin main)
        {
            InitializeComponent();
            this.Admin_main = main;
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report report = new Report(this);
            report.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Admin_main.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Feedback f = new Feedback(this);
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
