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
    public partial class Remove : Form
    {
        public List<story> my_story;
        public story chosen_story;
        public Admin Admin_main;
        public Remove(Admin main)
        {
            InitializeComponent();
            this.Admin_main = main;
            my_story = new List<story>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_main.Show();
            //this.Close();
        }

        private void Remove_Load(object sender, EventArgs e)
        {
            build_Story_List();
            foreach (story s in my_story)
            {
                stories_List.Items.Add(s.name);
            }
        }

        public void build_Story_List()
        {
            string fileName = "Database11.accdb";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
            string workingDirectory = Environment.CurrentDirectory;
            String path2 = Directory.GetParent(workingDirectory).Parent.FullName + "\\Database11.accdb";
            string connStr = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}", path2);
            string query = " SELECT * FROM stories";
            //[User Login]=?, [Password]=?,
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataReader reader = cmd.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        if (reader[1].ToString() == "Admin" || reader[1].ToString() == "admin")
                        {
                            story s = new story(reader[2].ToString(), reader[0].ToString(), reader[3].ToString(), reader[1].ToString(), new List<question>());
                            my_story.Add(s);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("details error", "error");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Delete_questions(chosen_story.ID);
                Delete_story(stories_List.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("not deleted");
            }
            /*
            foreach (story s in my_story)
            {
                stories_List.Items.Clear();
            }
            foreach (story s in my_story)
            {
                stories_List.Items.Add(s.name);
            }*/
        }

        public void Delete_story(string story_name)
        {
            string fileName = "Database11.accdb";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
            string workingDirectory = Environment.CurrentDirectory;
            String path2 = Directory.GetParent(workingDirectory).Parent.FullName + "\\Database11.accdb";
            string connStr = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}", path2);
            string query = " DELETE FROM stories WHERE story_Name=@story_name";

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@story_name", story_name);
   
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("details error", "error");
                }
            }
        }


        public void Delete_questions(string story_id)
        {
            string fileName = "Database11.accdb";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
            string workingDirectory = Environment.CurrentDirectory;
            String path2 = Directory.GetParent(workingDirectory).Parent.FullName + "\\Database11.accdb";
            string connStr = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}", path2);
            string query = " DELETE FROM questions WHERE story_ID=@story_id";
            

            using (OleDbConnection conn2 = new OleDbConnection(connStr))
            {
                conn2.Open();
                OleDbCommand cmd2 = new OleDbCommand(query, conn2);
                cmd2.Parameters.AddWithValue("@story_id", story_id);

                try
                {
                    cmd2.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("details error", "error");
                }
            }
        }

        private void stories_List_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach(story s in my_story)
            {
                if(s.name==stories_List.SelectedItem.ToString())
                {
                    this.chosen_story = s;
                }
            }
        }

        private void stories_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
