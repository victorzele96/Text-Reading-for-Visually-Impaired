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
    public partial class add_questions : Form
    {
        public Add admin_main;
        public second_Page teacher_main;
        public List<story> stories_List;
        bool isAdmin;
        public story chosenStory;
        public add_questions(Add main)

        {
            InitializeComponent();
            this.admin_main = main;
            this.CenterToScreen();
            stories_List = new List<story>();
            isAdmin = true;

        }

        public add_questions(second_Page main)

        {
            InitializeComponent();
            this.teacher_main = main;
            this.CenterToScreen();
            stories_List = new List<story>();
            isAdmin = false;

        }

        private void add_questions_Load(object sender, EventArgs e)
        {
            build_Questions_List();
            foreach(story s in stories_List)
            {
                story_selectionCB.Items.Add(s.name);
            }
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            List<string> answers = new List<string>();

            if (QuestionRTB.Text != "" && RightAnswerTB.Text != "" && (Answer1TB.Text != "" || Answer2TB.Text != "" || Answer3TB.Text != ""))
            {
                answers.Add(RightAnswerTB.Text);    //add the correct answer into the list

                if (Answer1TB.Text != "")    //check if the first answer isn`t empty
                {
                    answers.Add(Answer1TB.Text);
                }
                if (Answer2TB.Text != "")   //check if the second answer isn`t empty
                {
                    answers.Add(Answer1TB.Text);
                }
                if (Answer3TB.Text != "")   //check if the third answer isn`t empty
                {
                    answers.Add(Answer1TB.Text);
                }

                question Qst = new question(QuestionRTB.Text, answers);

                if (!isAdmin)
                {
                    string fileName = "Database11.accdb";
                    string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
                    string workingDirectory = Environment.CurrentDirectory;
                    String path2 = Directory.GetParent(workingDirectory).Parent.FullName + "\\Database11.accdb";
                    string connStr = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;
                    Data Source={0}", path2);
                    string query = " INSERT INTO questions (teacher_ID, story_ID, question, answer1, answer2, answer3, answer4) VALUES (@teacher_ID, @story_ID, @question, @answer1 , @answer2, @answer3, @answer4)  ";

                    using (OleDbConnection conn = new OleDbConnection(connStr))
                    {
                        conn.Open();
                        OleDbCommand cmd = new OleDbCommand(query, conn);
                        cmd.Parameters.AddWithValue(@"teacher_ID", teacher_main.Teacher_main.login_main.userName);
                        cmd.Parameters.AddWithValue(@"story_ID", Qst.ID);
                        cmd.Parameters.AddWithValue(@"question", Qst.questionString);
                        cmd.Parameters.AddWithValue(@"answer1", Qst.answers[0]);
                        cmd.Parameters.AddWithValue(@"answer2", Qst.answers[1]);
                        cmd.Parameters.AddWithValue(@"answer3", Qst.answers[2]);
                        cmd.Parameters.AddWithValue(@"answer4", Qst.answers[3]);

                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("details error", "error");
                        }


                        MessageBox.Show("Data was saved!");

                    }
                }
                else
                {
                    string fileName = "Database11.accdb";
                    string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
                    string workingDirectory = Environment.CurrentDirectory;
                    String path2 = Directory.GetParent(workingDirectory).Parent.FullName + "\\Database11.accdb";
                    string connStr = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;
                    Data Source={0}", path2);
                    string query = " INSERT INTO questions (teacher_ID, story_ID, question, answer1, answer2, answer3, answer4) VALUES (@teacher_ID, @story_ID, @question, @answer1 , @answer2, @answer3, @answer4)  ";

                    using (OleDbConnection conn = new OleDbConnection(connStr))
                    {
                        conn.Open();
                        OleDbCommand cmd = new OleDbCommand(query, conn);
                        cmd.Parameters.AddWithValue(@"teacher_ID", "Admin");
                        cmd.Parameters.AddWithValue(@"story_ID", chosenStory.ID);
                        cmd.Parameters.AddWithValue(@"question", Qst.questionString);
                        cmd.Parameters.AddWithValue(@"answer1", Qst.answers[0]);
                        cmd.Parameters.AddWithValue(@"answer2", Qst.answers[1]);
                        cmd.Parameters.AddWithValue(@"answer3", Qst.answers[2]);
                        cmd.Parameters.AddWithValue(@"answer4", Qst.answers[3]);

                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("details error", "error");
                        }


                        MessageBox.Show("Data was saved!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields!", "Error!");
            }
        }

        public void build_Questions_List()
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
                            story s = new story(reader[3].ToString(), reader[0].ToString(), reader[2].ToString(), reader[1].ToString(), new List<question>());
                            stories_List.Add(s);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("details error", "error");
                }
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void story_selectionCB_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (story s in stories_List)
            {
                if (s.name == (String)story_selectionCB.SelectedItem)
                {
                    chosenStory = s;
                }
            }
        }

        private void story_selectionCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }
    }
}
