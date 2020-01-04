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
    public partial class Update_details : Form
    {
        public Teacher Teacher_main;
        public Update_details(Teacher main)
        {
            InitializeComponent();
            this.Teacher_main = main;
        }

        private void button2_Click(object sender, EventArgs e)
        {//-----------------
            bool foundflag = false;
            String y = textBox6.Text;
            if (y == Teacher_main.login_main.userName)
            {//find only the one that login
                if (dataGridView1.Rows.Count > 0)
                {
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        String x = (String)r.Cells[0].Value;
                        if (x == y)
                        {
                            foundflag = true;
                            label6.Text = ((DataGridViewRow)r).Cells["ID"].Value.ToString();
                            textBox1.Text = ((DataGridViewRow)r).Cells["First Name"].Value.ToString();
                            textBox2.Text = ((DataGridViewRow)r).Cells["Last Name"].Value.ToString();
                            textBox4.Text = ((DataGridViewRow)r).Cells["Password"].Value.ToString();
                            textBox5.Text = ((DataGridViewRow)r).Cells["Email"].Value.ToString();
                            textBox6.Text = "";
                        }
                    }
                }
            }
            else
            {
                textBox6.Text = "";
                MessageBox.Show("The account does not exist in the system!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Teacher_main.Show();
        }

        private void Update_details_Load(object sender, EventArgs e)
        {
            Database11DataSetTableAdapters.TeacherTableAdapter tr = new Database11DataSetTableAdapters.TeacherTableAdapter();
            Database11DataSet.TeacherDataTable dt1 = tr.GetData();//tr=teacher
            dataGridView1.DataSource = dt1;

            dataGridView1.Hide();
        }

        private void update_Teacher_By_ID(String id)
        {
            string fileName = "Database11.accdb";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
            string workingDirectory = Environment.CurrentDirectory;
            String path2 = Directory.GetParent(workingDirectory).Parent.FullName + "\\Database11.accdb";
            string connStr = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;
                    Data Source={0}", path2);
            string query = " UPDATE [Teacher] SET [First Name]=?, [Last Name]=?, [Email]=?, [Password]=? WHERE [ID] = ?  ";
            //[User Login]=?, [Password]=?,
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, conn);
                
                //cmd.Parameters.AddWithValue(@"user_login", userNameTB.Text);
                cmd.Parameters.AddWithValue(@"firstName", textBox1.Text);
                cmd.Parameters.AddWithValue(@"lastName", textBox2.Text);
                cmd.Parameters.AddWithValue(@"email", textBox5.Text);
                cmd.Parameters.AddWithValue(@"password",textBox4.Text);
                cmd.Parameters.AddWithValue(@"id", id);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("details error", "error");
                }

                //cmd.ExecuteNonQuery();
                //main.Show();
                //this.Close();
            }
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {//update button 
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    if (((TextBox)c).Text == "" && ((TextBox)c).Name != textBox6.Name)
                    {
                        MessageBox.Show("please fill al fields", "error");
                    }
                }
            }
            update_Teacher_By_ID(textBox6.Text);

            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    c.Text = "";
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
