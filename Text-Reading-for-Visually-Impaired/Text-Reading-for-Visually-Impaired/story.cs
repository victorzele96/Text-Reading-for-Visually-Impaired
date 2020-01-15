using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Reading_for_Visually_Impaired
{
    public class story
    {
        public String name;
        public String ID;
        public String text;
        public List<question> questions;
        public String teacherID;

        public story(String name, String id, String text, String teacher_ID ,List<question> q)
        {
            this.name = name;
            this.text = text;
            this.questions = q;
            this.ID = id;
            this.teacherID = teacher_ID;
            //add_Questions_To_Story();
        }

        public story(String id, String text, String teacher_ID, List<question> q)
        {
            this.text = text;
            this.questions = q;
            this.ID = id;
            this.teacherID = teacher_ID;
        }

        /*public void add_Questions_To_Story()
        {
            string fileName = "Database11.accdb";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
            string workingDirectory = Environment.CurrentDirectory;
            String path2 = Directory.GetParent(workingDirectory).Parent.FullName + "\\Database11.accdb";
            string connStr = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}", path2);
            string query = " SELECT * FROM questions";
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataReader reader = cmd.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        if (reader[2].ToString() == this.ID)
                        {
                            String a1 = reader[4].ToString();
                            String a1 = reader[5].ToString();
                            String a1 = reader[6].ToString();
                            String a1 = reader[7].ToString();
                            List<String> answers = new List<string> { reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString() };
                            this.questions.Add(new question(reader[0].ToString(), reader[3].ToString(), answers));
                        }
                    }
                }
                catch (Exception)
                {

                }
            }
        }*/
    }
}
