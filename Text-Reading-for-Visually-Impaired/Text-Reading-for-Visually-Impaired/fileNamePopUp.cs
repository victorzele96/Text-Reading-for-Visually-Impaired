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
    public partial class fileNamePopUp : Form
    {
        public second_Page myMain;
        public fileNamePopUp(second_Page myMain)
        {
            InitializeComponent();
            this.myMain = myMain;
            this.CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        public Boolean check_Story_Name_Existence(String name)
        {         
            string fileName = "Database11.accdb";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
            string workingDirectory = Environment.CurrentDirectory;
            String path2 = Directory.GetParent(workingDirectory).Parent.FullName + "\\Database11.accdb";
            string connStr = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}", path2);
            string query = " SELECT * FROM stories";
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataReader reader = cmd.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        if (reader[3].ToString()==name)
                        {
                            return true;
                        }
                    }
                }
                catch (Exception)
                {
                    return false;
                }
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean b = check_Story_Name_Existence(textBox1.Text);
            if(textBox1.TextLength==0)
            {
                MessageBox.Show("please fill the ID field", "error");
            }
            if(check_Story_Name_Existence(textBox1.Text))
            {
                MessageBox.Show("file ID already exist, pleae choose a different one", "error");
            }
            else
            {
                string fileName = "Database11.accdb";
                string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
                string workingDirectory = Environment.CurrentDirectory;
                String path2 = Directory.GetParent(workingDirectory).Parent.FullName + "\\Database11.accdb";
                string connStr = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}", path2);
                string query = " INSERT INTO stories (teacher_ID,story,strory_Name) VALUES(@ID,@story,@story_name)";
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", this.myMain.Teacher_main.login_main.userName); ;
                    cmd.Parameters.AddWithValue("@story",this.myMain.richTextBox1.Text);
                    cmd.Parameters.AddWithValue("@story_name",this.textBox1.Text);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        
                    }
                }
            }
        }

        private void fileNamePopUp_Load(object sender, EventArgs e)
        {

        }
    }
}
