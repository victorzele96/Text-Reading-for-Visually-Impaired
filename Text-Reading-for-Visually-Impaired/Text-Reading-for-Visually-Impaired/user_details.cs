using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Text_Reading_for_Visually_Impaired
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports f = new Reports();
            f.ShowDialog();
            this.Close();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            Database11DataSetTableAdapters.TeacherTableAdapter tr = new Database11DataSetTableAdapters.TeacherTableAdapter();
            Database11DataSet.TeacherDataTable dt1 = tr.GetData();//tr=teacher
            dataGridView1.DataSource = dt1;

            Database11DataSetTableAdapters.ProfileTableAdapter pr = new Database11DataSetTableAdapters.ProfileTableAdapter();
            Database11DataSet.ProfileDataTable dt2 = pr.GetDataBy();//pr=profile
            dataGridView2.DataSource = dt2;

            label6.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
                                                             //th= means teacher
            Database11DataSetTableAdapters.TeacherTableAdapter th = new Database11DataSetTableAdapters.TeacherTableAdapter();
            Database11DataSet.TeacherDataTable dt1 = th.GetDataByID(textBox6.Text);

            if (dt1.Rows.Count > 0)
            {
                label6.Text = "";
                label8.Text = "";
                label9.Text = dt1.Rows.Count.ToString();
                label10.Text = "";
                label11.Text = "";
            }
            */
            Database11DataSetTableAdapters.AdminTableAdapter ad = new Database11DataSetTableAdapters.AdminTableAdapter();
            Database11DataSet.AdminDataTable dt1 = ad.GetDataByID(textBox6.Text);
 
            if (dt1.Rows.Count > 0)
            {
                label9.Text = dt1.IDColumn.ToString();
            }
            else
                MessageBox.Show("The account does not exist in the system!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
