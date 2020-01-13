﻿using System;
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
        public Reports Reports_main;
        public Report(Reports main)
        {
            InitializeComponent();
            this.Reports_main = main;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Reports_main.Show();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            Database11DataSetTableAdapters.TeacherTableAdapter tr = new Database11DataSetTableAdapters.TeacherTableAdapter();
            Database11DataSet.TeacherDataTable dt1 = tr.GetData();//tr=teacher
            dataGridView1.DataSource = dt1;

            Database11DataSetTableAdapters.ProfileTableAdapter pr = new Database11DataSetTableAdapters.ProfileTableAdapter();
            Database11DataSet.ProfileDataTable dt2 = pr.GetData();//pr=profile
            dataGridView2.DataSource = dt2;

            label6.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";

            UpdateFont();

        }

        private void UpdateFont()
        {
            //Change cell font
            foreach (DataGridViewColumn c in dataGridView1.Columns)
                c.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 16F, GraphicsUnit.Pixel);


            foreach (DataGridViewColumn c in dataGridView2.Columns)
                c.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 16F, GraphicsUnit.Pixel);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Database11DataSetTableAdapters.TeacherTableAdapter tr = new Database11DataSetTableAdapters.TeacherTableAdapter();
            Database11DataSet.TeacherDataTable dt1 = tr.GetData();//tr=teacher
            dataGridView1.DataSource = dt1;

            Database11DataSetTableAdapters.ProfileTableAdapter pr = new Database11DataSetTableAdapters.ProfileTableAdapter();
            Database11DataSet.ProfileDataTable dt2 = pr.GetData();//pr=profile
            dataGridView2.DataSource = dt2;

            Boolean foundFlag = false;
                if (dataGridView1.Rows.Count > 0 && foundFlag == false)
                {
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        String x = (String)r.Cells[0].Value;
                        String y = textBox6.Text;
                        if (x == y)
                        {
                            foundFlag = true;
                            label9.Text = ((DataGridViewRow)r).Cells["ID"].Value.ToString();
                            label6.Text = ((DataGridViewRow)r).Cells["First Name"].Value.ToString();
                            label8.Text = ((DataGridViewRow)r).Cells["Last Name"].Value.ToString();
                            label10.Text = ((DataGridViewRow)r).Cells["Male / Female"].Value.ToString();
                            label11.Text = ((DataGridViewRow)r).Cells["Email"].Value.ToString();
                        }
                    }
                }
            
                if (dataGridView2.Rows.Count > 0 && foundFlag == false)
                {
                    foreach (DataGridViewRow r in dataGridView2.Rows)
                    {
                        String x = (String)r.Cells[0].Value;
                        String y = textBox6.Text;
                        if (x == y)
                        {
                            foundFlag = true;
                            label9.Text = ((DataGridViewRow)r).Cells["ID"].Value.ToString();
                            label6.Text = ((DataGridViewRow)r).Cells["First Name"].Value.ToString();
                            label8.Text = ((DataGridViewRow)r).Cells["Last Name"].Value.ToString();
                            label10.Text = ((DataGridViewRow)r).Cells["Male / Female"].Value.ToString();
                            label11.Text = ((DataGridViewRow)r).Cells["Email"].Value.ToString();
                        }
                    }
                }
            if(!foundFlag)
                MessageBox.Show("The account does not exist in the system!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox6.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Reports_main.Show();
        }
    }
}
