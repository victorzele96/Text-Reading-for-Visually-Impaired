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
    public partial class Requests : Form
    {
        public Admin Admin_main;
        public Requests(Admin main)
        {
            InitializeComponent();
            this.Admin_main = main;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Admin_main.Show();
            //this.Close();
        }
    }
}
