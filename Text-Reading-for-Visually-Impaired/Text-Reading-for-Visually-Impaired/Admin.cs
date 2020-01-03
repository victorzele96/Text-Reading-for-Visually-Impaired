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
    public partial class Admin : Form
    {
        public Login main;
        public Admin(Login main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports report = new Reports(this);
            report.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Requests request = new Requests(this);
            request.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add add = new Add(this);
            add.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Remove remove = new Remove(this);
            remove.ShowDialog();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
