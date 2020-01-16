using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
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

        private void Feedback_Load(object sender, EventArgs e)
        {
            dataGridView2.Hide();
            // TODO: This line of code loads data into the 'database11DataSet2.Reports' table. You can move, or remove it, as needed.
            this.reportsTableAdapter.Fill(this.database11DataSet2.Reports);
            Feedback.ActiveForm.BackColor = Color.Gainsboro;

            label7.Text = ""; //ID
            label6.Text = ""; //first ID
            label3.Text = ""; //last ID
            label8.Text = ""; //email

            UpdateFont();
        }

        private void UpdateFont()
        {
            //Change cell font
            foreach (DataGridViewColumn c in dataGridView1.Columns)
                c.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 16F, GraphicsUnit.Pixel);
        }

            private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }


        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            Database11DataSetTableAdapters.TeacherTableAdapter pr = new Database11DataSetTableAdapters.TeacherTableAdapter();
            Database11DataSet.TeacherDataTable dt1 = pr.GetData();//pr=profile
            dataGridView2.DataSource = dt1;


            if (dataGridView1.Rows.Count > 0)
            {
                label7.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                richTextBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                
                if (dataGridView2.Rows.Count > 0)
                {
                    foreach (DataGridViewRow r in dataGridView2.Rows)
                    {
                        if (((DataGridViewRow)r).Cells["ID"].Value.ToString() == label7.Text)
                        {
                            label6.Text = ((DataGridViewRow)r).Cells["First Name"].Value.ToString();
                            label3.Text = ((DataGridViewRow)r).Cells["Last Name"].Value.ToString();
                            label8.Text = ((DataGridViewRow)r).Cells["Email"].Value.ToString();
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Empty"); 
            }
        }
    }
}
