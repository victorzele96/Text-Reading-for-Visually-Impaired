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
    public partial class Send_feedback : Form
    {
        public Teacher Teacher_main;
        public Send_feedback(Teacher main)
        {
            InitializeComponent();
            feedback.Checked = true;
            story_requests.Checked = false;
            this.Teacher_main = main;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Teacher_main.Show();
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (feedback.Checked == true)
            {
                string fileName = "Database11.accdb";
                string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
                string workingDirectory = Environment.CurrentDirectory;
                String path2 = Directory.GetParent(workingDirectory).Parent.FullName + "\\Database11.accdb";
                string connStr = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;
                    Data Source={0}", path2);
                string query = " INSERT INTO [Reports] ([Report Title], [Reports], [SenderID],[Asks]) VALUES (@report_title,@reports,@senderid,@asks)  ";

                using (OleDbConnection conn = new OleDbConnection(connStr))
                {


                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand(query, conn);

                    cmd.Parameters.AddWithValue(@"report_title", textBox1.Text);
                    cmd.Parameters.AddWithValue(@"reports", richTextBox1.Text);
                    cmd.Parameters.AddWithValue(@"senderid", Teacher_main.login_main.userName);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Already sent to admin !");
                    }

                }

                MessageBox.Show("Feedback was sent successfully !");
                richTextBox1.Text = "";
                textBox1.Text = "";
            }
        
            if (story_requests.Checked == true)
            {
                string fileName = "Database11.accdb";
                string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
                string workingDirectory = Environment.CurrentDirectory;
                String path2 = Directory.GetParent(workingDirectory).Parent.FullName + "\\Database11.accdb";
                string connStr = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;
                    Data Source={0}", path2);
                string query = " INSERT INTO [Requests] ([Requests Title], [Request], [SenderID]) VALUES (@requset_title,@request,@senderid)  ";

                using (OleDbConnection conn = new OleDbConnection(connStr))
                {


                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand(query, conn);

                    cmd.Parameters.AddWithValue(@"requset_title", textBox1.Text);
                    cmd.Parameters.AddWithValue(@"request", richTextBox1.Text);
                    cmd.Parameters.AddWithValue(@"senderid", Teacher_main.login_main.userName);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Already sent to admin !");
                    }

                }

                MessageBox.Show("Feedback was sent successfully !");
                richTextBox1.Text = "";
                textBox1.Text = "";
            }
        }
        private void Send_feedback_Load(object sender, EventArgs e)
        {

        }
    }
}
