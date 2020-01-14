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
        public List<story> stories_List;
        public Add add_main;
        public add_questions(Add main)

        {
            InitializeComponent();
            this.add_main = main;
            this.CenterToScreen();
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

            if(QuestionRTB.Text != "" && RightAnswerTB.Text != "" && (Answer1TB.Text != "" || Answer2TB.Text != "" || Answer3TB.Text != ""))
            {
                answers.Add(RightAnswerTB.Text);    //add the correct answer into the list

                if(Answer1TB.Text != "")    //check if the first answer isn`t empty
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
/*
                string fileName = "Database11.accdb";
                string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
                string workingDirectory = Environment.CurrentDirectory;
                String path2 = Directory.GetParent(workingDirectory).Parent.FullName + "\\Database11.accdb";
                string connStr = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;
                    Data Source={0}", path2);
                string query = " INSERT INTO questions (question, answer1, answer2, answer3, answer4) VALUES (@question, @answer1 , @answer2, @answer3, @answer4)  ";

                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue(@"question", Qst.ID);
                    cmd.Parameters.AddWithValue(@"question", Qst.questionString);
                    cmd.Parameters.AddWithValue(@"story_name", Qst.answers[0]);
                    cmd.Parameters.AddWithValue(@"story_name", Qst.name);
                    cmd.Parameters.AddWithValue(@"story_name", Qst.name);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("details error", "error");
                    }


                    MessageBox.Show("Data was saved!");
*/
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
    }
}
