using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Reading_for_Visually_Impaired
{
    public partial class Add : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Admin Admin_main;
        public Add(Admin main)
        {
            InitializeComponent();
            this.Admin_main = main;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_main.Show();
            //this.Close();
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string str_file_name = openFileDialog1.FileName;
                MessageBox.Show(str_file_name);  //prints the file path
            }
        }
    }
}
