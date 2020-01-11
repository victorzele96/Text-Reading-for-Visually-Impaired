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
    public partial class Update_student_Information : Test
    {
        public Student Student_main;     
        public Update_student_Information(Student main)
        {
            InitializeComponent();
            this.Student_main = main;
            Database11DataSetTableAdapters.ProfileTableAdapter pr = new Database11DataSetTableAdapters.ProfileTableAdapter();
            Database11DataSet.ProfileDataTable dt1 = pr.GetData();//pr=profile
            dataGridView1.DataSource = dt1;

            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    if(((DataGridViewRow)r).Cells["ID"].Value.ToString() == this.Student_main.login_main.userName)
                    {
                        textBox1.Text = ((DataGridViewRow)r).Cells["First Name"].Value.ToString();
                        textBox2.Text = ((DataGridViewRow)r).Cells["Last Name"].Value.ToString();
                        textBox4.Text = ((DataGridViewRow)r).Cells["Password"].Value.ToString();
                        textBox5.Text = ((DataGridViewRow)r).Cells["Email"].Value.ToString();
                        label6.Text = this.Student_main.login_main.userName;
                        break;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Student_main.Show();
            //this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //Database11DataSetTableAdapters.ProfileTableAdapter pr = new Database11DataSetTableAdapters.ProfileTableAdapter();
            //Database11DataSet.ProfileDataTable dt1 = pr.GetData();//pr=profile
            //dataGridView1.DataSource = dt1;
            //String y = textBox6.Text;

            //if (y == Student_main.login_main.userName)
            //{//find only the one that login

            //    if (dataGridView1.Rows.Count > 0)
            //    {
            //        foreach (DataGridViewRow r in dataGridView1.Rows)
            //        {
            //            String x = (String)r.Cells[0].Value;
            //            if (x == y)
            //            {
            //                label6.Text = ((DataGridViewRow)r).Cells["ID"].Value.ToString();
            //                textBox1.Text = ((DataGridViewRow)r).Cells["First Name"].Value.ToString();
            //                textBox2.Text = ((DataGridViewRow)r).Cells["Last Name"].Value.ToString();
            //                textBox4.Text = ((DataGridViewRow)r).Cells["Password"].Value.ToString();
            //                textBox5.Text = ((DataGridViewRow)r).Cells["Email"].Value.ToString();
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("The account does not exist in the system!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    textBox6.Text = "";
            //}
        }
    


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }

        private void Update_student_Information_Load(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            this.ForeColor = Student_main.ForeColor;
            this.BackColor = Student_main.BackColor;
            foreach (Button butt in this.Controls.OfType<Button>())
            {
                butt.BackColor = Student_main.chooseAstory.BackColor;
                butt.ForeColor = Student_main.button4.ForeColor;
            }
            foreach (Label lab in this.Controls.OfType<Label>())
            {
                lab.ForeColor = Student_main.button4.ForeColor;
                lab.BackColor = Student_main.button4.BackColor;
            }
        }

        private void update_Student_By_ID(String id)
        {
            string fileName = "Database11.accdb";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
            string workingDirectory = Environment.CurrentDirectory;
            String path2 = Directory.GetParent(workingDirectory).Parent.FullName + "\\Database11.accdb";
            string connStr = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;
                    Data Source={0}", path2);
            string query = " UPDATE [Profile] SET [First Name]=?, [Last Name]=?, [Email]=?, [Password]=? WHERE [ID] = ?  ";
            //[User Login]=?, [Password]=?,
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, conn);

                //cmd.Parameters.AddWithValue(@"user_login", userNameTB.Text);
                cmd.Parameters.AddWithValue(@"firstName", textBox1.Text);
                cmd.Parameters.AddWithValue(@"lastName", textBox2.Text);
                cmd.Parameters.AddWithValue(@"email", textBox5.Text);
                cmd.Parameters.AddWithValue(@"password", textBox4.Text);
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


        private void button2_Click(object sender, EventArgs e)
        {//update button 
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    if (((TextBox)c).Text == "") //&& ((TextBox)c).Name != textBox6.Name)
                    {
                        MessageBox.Show("please fill al fields", "error");
                        break;
                    }
                }
            }
            update_Student_By_ID(label6.Text);

            MessageBox.Show("Details were updated");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
