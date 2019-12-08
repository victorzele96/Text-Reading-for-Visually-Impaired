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
            Database11DataSetTableAdapters.TeacherTableAdapter th = new Database11DataSetTableAdapters.TeacherTableAdapter();
            Database11DataSet.TeacherDataTable dt1 = th.GetData(); //th=teacher
            
            Database11DataSetTableAdapters.ProfileTableAdapter pr = new Database11DataSetTableAdapters.ProfileTableAdapter();
            Database11DataSet.ProfileDataTable dt2 = pr.GetData();//pr=profile

            if (textBox6.Text==dt1)
            {
                label6.Text = "";
                label8.Text = "";
                label9.Text = "";
                label10.Text = "";
                label11.Text = "";
            }
            else
                if(textBox6.Text == dt2.DataSet("ID"))
                {
                    label6.Text = "";
                    label8.Text = "";
                    label9.Text = "";
                    label10.Text = "";
                    label11.Text = "";
                }
               */ 
        }
    }
}
