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

        private void Requests_Load(object sender, EventArgs e)
        { 
            // TODO: This line of code loads data into the 'database11DataSet4.Requests' table. You can move, or remove it, as needed.
            this.requestsTableAdapter.Fill(this.database11DataSet4.Requests);

            dataGridView2.Hide();

            label7.Text = ""; //ID
            label6.Text = ""; //first name
            label3.Text = ""; //last name
            label8.Text = ""; //email

            UpdateFont();
        }

        private void UpdateFont()
        {
            //Change cell font
            foreach (DataGridViewColumn c in dataGridView1.Columns)
                c.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 16F, GraphicsUnit.Pixel);
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
                        if (((DataGridViewRow)r).Cells[0].Value.ToString() == label7.Text)
                        {
                            label6.Text = ((DataGridViewRow)r).Cells[3].Value.ToString();
                            label3.Text = ((DataGridViewRow)r).Cells[4].Value.ToString();
                            label8.Text = ((DataGridViewRow)r).Cells[5].Value.ToString();
                            break;
                        }
                    }
                }
                else
                    MessageBox.Show("Not exists");
            }
            else
            {
                MessageBox.Show("Empty Table");
            }
        }
    }
}
