using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Text_Reading_for_Visually_Impaired
{
    public partial class Add : Form
    {
        public Admin Admin_main;
        public Add(Admin main)
        {
            InitializeComponent();
            this.Admin_main = main;
        }

        public Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_main.Show();
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string str_file_path = openFileDialog1.FileName;
                MessageBox.Show(str_file_path);  //prints the file path

                string readText = File.ReadAllText(str_file_path);
                StoryRTB.Text = readText;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (StoryRTB.Text == "" || story_nameTB.Text == "")
            {
                MessageBox.Show("Please fill all fields", "Error!");
            }
            else
            {
                story new_story;

                    new_story = new story(story_nameTB.Text, StoryRTB.Text, "Admin", null);

                string fileName = "Database11.accdb";
                string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
                string workingDirectory = Environment.CurrentDirectory;
                String path2 = Directory.GetParent(workingDirectory).Parent.FullName + "\\Database11.accdb";
                string connStr = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;
                    Data Source={0}", path2);
                string query = " INSERT INTO stories (Teacher_ID, story, story_Name) VALUES (@teacherID, @story , @story_name)  ";

                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue(@"teacherID", new_story.teacherID);
                    cmd.Parameters.AddWithValue(@"story", new_story.text);
                    cmd.Parameters.AddWithValue(@"story_name", new_story.name);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("details error", "error");
                    }
                    

                    MessageBox.Show("Data was saved!");
                    StoryRTB.Text = "";
                    story_nameTB.Text = "";
                }
            }
        }

        private void Add_questionBTN_Click(object sender, EventArgs e)
        {
            add_questions add_Questions = new add_questions(this);
            add_Questions.ShowDialog();
        }

        private void UpdatesRTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
