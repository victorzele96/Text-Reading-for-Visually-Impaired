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
    public class teacherModel
    {
        public List<studentModel> students;
        public String ID;
        public String userName;
        public String last_logged_in;
        public teacherModel(String username)
        {
            this.userName = username;
            build_students_List();
            get_teacher_details();
        }

        public void build_students_List()
        {
            students = new List<studentModel>();
            string fileName = "Database11.accdb";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
            string workingDirectory = Environment.CurrentDirectory;
            String path2 = Directory.GetParent(workingDirectory).Parent.FullName + "\\Database11.accdb";
            string connStr = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}", path2);
            string query = " SELECT * FROM Profile";
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataReader reader = cmd.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        if (reader[1].ToString() == this.userName)
                        {
                            studentModel sm = new studentModel(reader[0].ToString(),reader[1].ToString());
                            students.Add(sm);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("details error", "error");
                }
            }
        }

        public void get_teacher_details()
        {
            students = new List<studentModel>();
            string fileName = "Database11.accdb";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
            string workingDirectory = Environment.CurrentDirectory;
            String path2 = Directory.GetParent(workingDirectory).Parent.FullName + "\\Database11.accdb";
            string connStr = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}", path2);
            string query = " SELECT * FROM Teacher";
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataReader reader = cmd.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        if (reader[1].ToString() ==this.userName)
                        {
                            this.ID = reader[0].ToString();
                            this.last_logged_in = reader[7].ToString();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("details error", "error");
                }
            }
        }

    }
}
