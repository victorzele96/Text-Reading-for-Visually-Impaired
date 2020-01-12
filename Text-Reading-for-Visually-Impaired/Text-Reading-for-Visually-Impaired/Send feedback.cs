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
            string fileName = "Database11.accdb";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
            string workingDirectory = Environment.CurrentDirectory;
            String path2 = Directory.GetParent(workingDirectory).Parent.FullName + "\\Database11.accdb";
            string connStr = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;
                    Data Source={0}", path2);
            string query = " INSERT INTO [Reports] ([Report Title], [Reports], [General Report], [Periodic Report], [SenderID]) VALUES (@report_title,@reports,@genaral_report,@periodic_report,@senderid)  ";

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, conn);

                cmd.Parameters.AddWithValue(@"report_title", textBox1.Text);
                cmd.Parameters.AddWithValue(@"reports", richTextBox1.Text);
                textBox1.Text = "";
                cmd.Parameters.AddWithValue(@"genaral_report", textBox1.Text);
                cmd.Parameters.AddWithValue(@"periodic_report", textBox1.Text);
                cmd.Parameters.AddWithValue(@"senderid", Teacher_main.login_main.userName);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("details error", "error");
                }

                MessageBox.Show("Feedback was sent successfully !");
                richTextBox1.Text = "";
                textBox1.Text = "";
            }
        }
    }
}
