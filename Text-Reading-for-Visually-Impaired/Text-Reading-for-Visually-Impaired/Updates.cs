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
    public partial class Updates : Form
    {
        public Teacher_Reports teacher_rp;
        public Updates(Teacher_Reports main)
        {
            InitializeComponent();
            this.teacher_rp = main;
        }

        private void Updates_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.teacher_rp.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
