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
    public partial class Update_details : Form
    {
        public Update_details()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Database11DataSetTableAdapters.TeacherTableAdapter tr = new Database11DataSetTableAdapters.TeacherTableAdapter();
            Database11DataSet.TeacherDataTable dt1 = tr.GetData();//tr=teacher
            dataGridView1.DataSource = dt1;
            bool foundflag = false;

            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {//need to chenge that find only the one that login
                    String x = (String)r.Cells[0].Value;
                    String y = textBox6.Text;
                    if (x == y)
                    {
                        foundflag = true;
                        textBox3.Text = ((DataGridViewRow)r).Cells["ID"].Value.ToString();
                        textBox1.Text = ((DataGridViewRow)r).Cells["First Name"].Value.ToString();
                        textBox2.Text = ((DataGridViewRow)r).Cells["Last Name"].Value.ToString();
                        textBox4.Text = ((DataGridViewRow)r).Cells["Male / Female"].Value.ToString();
                        textBox5.Text = ((DataGridViewRow)r).Cells["Email"].Value.ToString();
                    }
                }
            }
            else
                MessageBox.Show("The account does not exist in the system!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher ts = new Teacher();
            ts.ShowDialog();
            this.Close();
        }

        private void Update_details_Load(object sender, EventArgs e)
        {
            Database11DataSetTableAdapters.TeacherTableAdapter tr = new Database11DataSetTableAdapters.TeacherTableAdapter();
            Database11DataSet.TeacherDataTable dt1 = tr.GetData();//tr=teacher
            dataGridView1.DataSource = dt1;

            dataGridView1.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
