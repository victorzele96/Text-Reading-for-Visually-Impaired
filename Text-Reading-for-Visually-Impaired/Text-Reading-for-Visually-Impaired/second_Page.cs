using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Threading;
using System.IO;
using System.Data.OleDb;

namespace Text_Reading_for_Visually_Impaired
{
    public partial class second_Page : Test
    {
        List<String> textFiles_List;
        Boolean paused = false;
        Boolean stopped = false;
        Boolean is_Teacher;
       public  SpeechSynthesizer synth = new SpeechSynthesizer();
        string Text_To_Read = "";
        public String user_ID;
        public Teacher Teacher_main;
        public Student student_main;
        public question_choices last_questions_page;
        List<story> stories_List = new List<story>();
       // String teacherID;
        public story chosen_story;
        Color backSColor; //famous stories button backcolor
        Color storyBtColor; //famous stories button forecolor
        Color questionBtColor; //questions button backcolor
        Color backQColor; //questions button forecolor
        public Boolean is_teacher_for_Student;
        public teacherModel myTeacher;
        public studentModel myStudent;
        public question_choices question_choices_page;
        public String studentID;
        public second_Page(Teacher main)
        {
            InitializeComponent();
            this.CenterToScreen();
            synth = new SpeechSynthesizer();
            this.WindowState = FormWindowState.Maximized;
            richTextBox1.DragDrop += RichTextBox1_DragDrop;
            richTextBox1.DragEnter += RichTextBox1_DragEnter;
            synth.SpeakProgress += new EventHandler<SpeakProgressEventArgs>(speak_in_progress);
            this.Teacher_main = main;
            this.is_Teacher = true;
            this.button5000.Text = "my stories";
            this.button6000.Text = "save story";
            build_Stories_List();
            richTextBox1.Width = ClientSize.Width;
        }

        public second_Page(Student main)
        {
            InitializeComponent();
            this.CenterToScreen();
            synth = new SpeechSynthesizer();
            this.WindowState = FormWindowState.Maximized;
            richTextBox1.DragDrop += RichTextBox1_DragDrop;
            richTextBox1.DragEnter += RichTextBox1_DragEnter;
            synth.SpeakProgress += new EventHandler<SpeakProgressEventArgs>(speak_in_progress);
            this.student_main = main;
            this.is_Teacher = false;
            this.button6000.Text = "questions";
            this.studentID = this.student_main.login_main.userName;
            build_Stories_List();
            richTextBox1.Width = ClientSize.Width;
            //this.question_choices_page = new question_choices(this,)
        }

        public second_Page(Teacher main ,teacherModel tm)
        {
            InitializeComponent();
            this.CenterToScreen();
            is_teacher_for_Student = true;
            this.is_Teacher = false;
            this.Teacher_main = main;
            synth = new SpeechSynthesizer();
            this.myTeacher = tm;
            //this.myStudent = sm;
            this.WindowState = FormWindowState.Maximized;
            richTextBox1.DragDrop += RichTextBox1_DragDrop;
            richTextBox1.DragEnter += RichTextBox1_DragEnter;
            synth.SpeakProgress += new EventHandler<SpeakProgressEventArgs>(speak_in_progress);
            this.button5000.Text = "my stories";
            this.button6000.Text = "questions";
            build_Stories_List();
            richTextBox1.Width = ClientSize.Width;
        }


        public second_Page()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void set_buttons_font(String color)
        {
            String resources_path = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\resources\\";
            foreach(Control b in buttonsPanel.Controls)
            {
                if(b is PictureBox)
                {
                    String mypath = resources_path + ((PictureBox)b).Name + color + ".bmp";
                    ((PictureBox)b).Image = System.Drawing.Image.FromFile(resources_path + ((PictureBox)b).Name + color + ".bmp");
                }
            }
        }



        public void get_text_files_to_list()
        {
            textFiles_List = new List<string>();
            DirectoryInfo d = new DirectoryInfo(Application.StartupPath +@"\\text_files");
            FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
            foreach (FileInfo file in Files)
            {
                textFiles_List.Add(file.Name.Substring(0,file.Name.Length - 4));
                
                //comboBox1.Items.Add(file.Name.Substring(0, file.Name.Length - 4));
            }
        }


        private void setObjectsLocation()
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                richTextBox1.Location = new Point((ClientSize.Width - richTextBox1.Width) / 2, richTextBox1.Location.Y);
                buttonsPanel.Location = new Point(richTextBox1.Location.X + (richTextBox1.Width - buttonsPanel.Width) / 2, richTextBox1.Location.Y + richTextBox1.Height + 10);
                insertTxtLb.Location = new Point((ClientSize.Width-insertTxtLb.Width)/2, richTextBox1.Location.Y - insertTxtLb.Height - 3);
                backBt.Location = new Point(ClientSize.Width - backBt.Width, 2);
            }
            
        }

        private void RichTextBox1_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void RichTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            object filename = e.Data.GetData("FileDrop");
            if (filename != null)
            {
                var list = filename as string[];
                if (list != null && !string.IsNullOrWhiteSpace(list[0]))
                {
                    richTextBox1.Clear();
                    richTextBox1.LoadFile(list[0], RichTextBoxStreamType.PlainText);
                    //string[] lines = System.IO.File.ReadAllLines(e.Data.);
                    /*foreach (String line in lines)
                    {
                        richTextBox1.AppendText(line);
                    }*/

                }

            }

        }
        private void speak_in_progress(object sender, SpeakProgressEventArgs e)
        {
            if(stopped)
            {
                
            }
            richTextBox1.HideSelection = false;
            int textposition = e.CharacterPosition;
            richTextBox1.Find(e.Text,textposition, RichTextBoxFinds.WholeWord);

            //richTextBox1.Select(0,textposition);
        }

        private void button6_Click(object sender, EventArgs e)
        { 
            //synth = new SpeechSynthesizer();
           // synth.SetOutputToDefaultAudioDevice();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            stopped = false;
            Text_To_Read = richTextBox1.Text;
            if (paused)
            {
                synth.Resume();
                paused = false;
            }
            else
            {
                speak();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.paused = true;
            synth.Pause();
        }

        private void speak()
        {
            synth.SpeakAsync(Text_To_Read);
        }

        private void second_Page_Load(object sender, EventArgs e)
        {
            get_text_files_to_list();
            this.backSColor = button5000.BackColor;
            this.storyBtColor = button5000.ForeColor;
            this.questionBtColor = button6000.ForeColor;
            this.backQColor = button6000.BackColor;
            // this.backBt.Location = new Point(this.Width-this.backBt.Width, this.Height-backBt.Height);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
            //speak();
            synth.SpeakAsync(Text_To_Read);
            paused = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            synth.Dispose();
            stopped = true;
            paused = false;
            //richTextBox1.Select(0,1);
            synth = new SpeechSynthesizer();
            synth.SpeakProgress += new EventHandler<SpeakProgressEventArgs>(speak_in_progress);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher_main.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void second_Page_Resize(object sender, EventArgs e)
        {

        }

        private void second_Page_ResizeEnd(object sender, EventArgs e)
        {
            setObjectsLocation();
            richTextBox1.Width = this.Width;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            //String path = Application.StartupPath + "\\text_files\\" + comboBox1.SelectedItem.ToString() + ".txt";
           // richTextBox1.LoadFile(path, RichTextBoxStreamType.PlainText);
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            story_choices nePage = new story_choices(this,stories_List);
            nePage.Show();
        }

        public void fillRichTextBox(string name)
        {
            //richTextBox1.Text = "";
            //String path = Application.StartupPath + "\\text_files\\" + name + ".txt";
            //richTextBox1.LoadFile(path, RichTextBoxStreamType.PlainText);
        }

        private void Second_Page_BackColorChanged(object sender, EventArgs e)
        {
           if(this.BackColor == Color.Gainsboro)
           {
                set_buttons_font("gray");
                return;
           }
           if(this.BackColor == Color.Black)
           {
              if(this.insertTxtLb.ForeColor==Color.Red)
              {
                    set_buttons_font("red");

              }
              else
              {
                    set_buttons_font("yellow");
              }
           }
           else
           {
                set_buttons_font("blue");
           }

        }

        private void RewindBT_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
            //speak();
            synth.SpeakAsync(Text_To_Read);
            paused = false;
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            synth.Dispose();
            stopped = true;
            paused = false;
            //richTextBox1.Select(0,1);
            synth = new SpeechSynthesizer();
            synth.SpeakProgress += new EventHandler<SpeakProgressEventArgs>(speak_in_progress);
        }

        private void PauseBT_Click(object sender, EventArgs e)
        {
            this.paused = true;
            synth.Pause();
        }

        private void PlayBT_Click(object sender, EventArgs e)
        {
            stopped = false;
            Text_To_Read = richTextBox1.Text;
            if (paused)
            {
                synth.Resume();
                paused = false;
            }
            else
            {
                speak();
            }
        }

        private void InsertTxtLb_ForeColorChanged(object sender, EventArgs e)
        {
            if(this.insertTxtLb.ForeColor == Color.Yellow)
            {
                set_buttons_font("yellow");
            }
            if (this.insertTxtLb.ForeColor == Color.Red)
            {
                set_buttons_font("red");
            }
            if (this.insertTxtLb.ForeColor == Color.Black)
            {
                set_buttons_font("gray");
                button5000.BackColor = this.backSColor;
                button5000.ForeColor = this.storyBtColor;
                button6000.ForeColor = this.questionBtColor;
                button6000.BackColor = this.backQColor;
            }
            if (this.insertTxtLb.ForeColor == Color.Blue)
            {
                set_buttons_font("blue");
            }
           
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            if(is_Teacher)
            {
                Teacher_main.Show();
            }
            else if(is_teacher_for_Student)
            {
                Login logi = new Login();
                this.Hide();
                logi.Show();
            }
            else
            {
                student_main.Theme_color(button5.ForeColor, button5.BackColor, this.BackColor);
                student_main.Show();
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            if(chosen_story==null)
            {
                MessageBox.Show("please choose a story first");
            }
            else
            {
                if (is_Teacher)
                {
                    fileNamePopUp fnp = new fileNamePopUp(this);
                    fnp.Show();
                }
                else
                {
                    if(question_choices_page==null)
                    {
                        this.chosen_story.questions = get_story_questions(chosen_story.ID);
                        question_choices newPage = new question_choices(this, chosen_story);
                        this.question_choices_page = newPage;
                        this.last_questions_page = newPage;
                        newPage.Show();
                    }
                    else
                    {
                        question_choices_page.Show();
                    }
                   
                }
            }
           
        }


        public void build_Stories_List()
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
                    while(reader.Read())
                    {
                        if(is_Teacher)
                        {
                            if (reader[1].ToString() == this.Teacher_main.login_main.userName)
                            {
                                story s = new story(reader[2].ToString(), reader[0].ToString(), reader[3].ToString(), reader[1].ToString(), new List<question>());
                                stories_List.Add(s);
                            }
                        }
                        else if(is_teacher_for_Student)
                        {
                            if (reader[1].ToString() == myTeacher.userName || reader[1].ToString() == "admin" || reader[1].ToString() == "Admin")
                            {
                                story s = new story(reader[2].ToString(), reader[0].ToString(), reader[3].ToString(), reader[1].ToString(), new List<question>());
                                stories_List.Add(s);
                            }
                        }
                        else
                        {
                            if (reader[1].ToString() == get_student_teacher( this.student_main.login_main.userName) || reader[1].ToString() == "admin" || reader[1].ToString() == "Admin")
                            {
                                story s = new story(reader[2].ToString(), reader[0].ToString(), reader[3].ToString(), reader[1].ToString(), new List<question>());
                                stories_List.Add(s);
                            }
                        }
                       
                    }
               }
               catch (Exception)
               {
                   MessageBox.Show("details error", "error");
               }
            }
        }

        

        /*public void set_user_ID()
        {
            String user_Name;
            String query;
            if(is_Teacher)
            {
                user_Name = this.Teacher_main.login_main.userName;
                query = " SELECT * FROM Teacher";
            }
            else
            {
                user_Name = this.student_main.login_main.userName;
                query = " SELECT * FROM Profile";
            }
            string fileName = "Database11.accdb";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
            string workingDirectory = Environment.CurrentDirectory;
            String path2 = Directory.GetParent(workingDirectory).Parent.FullName + "\\Database11.accdb";
            string connStr = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}", path2);
            //[User Login]=?, [Password]=?,
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, conn);
                //cmd.Parameters.AddWithValue("@user_Name", user_Name);
                OleDbDataReader reader = cmd.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        String s = reader[1].ToString();
                        if(reader[0].ToString()==user_Name)
                        {
                            this.user_ID = reader[0].ToString();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("details error", "error");
                }
            }
        }*/
        public String get_student_teacher(String student_id)
        {
           
            String user_Name = this.student_main.login_main.userName;
            String query = " SELECT * FROM Profile";
            string fileName = "Database11.accdb";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
            string workingDirectory = Environment.CurrentDirectory;
            String path2 = Directory.GetParent(workingDirectory).Parent.FullName + "\\Database11.accdb";
            string connStr = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}", path2);
            //[User Login]=?, [Password]=?,
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, conn);
                //cmd.Parameters.AddWithValue("@user_Name", user_Name);
                OleDbDataReader reader = cmd.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        String s = reader[1].ToString();
                        if (reader[0].ToString() == user_Name)
                        {
                            return reader[8].ToString();
                        }
                    }
                }
                catch (Exception)
                {
                    return null;
                }
                return null;
            }
        }


        public List<question> get_story_questions(String story_id)
        {

            List<question> q = new List<question>();
            String query = " SELECT * FROM questions";
            string fileName = "Database11.accdb";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
            string workingDirectory = Environment.CurrentDirectory;
            String path2 = Directory.GetParent(workingDirectory).Parent.FullName + "\\Database11.accdb";
            string connStr = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}", path2);
            //[User Login]=?, [Password]=?,
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, conn);
                //cmd.Parameters.AddWithValue("@user_Name", user_Name);
                OleDbDataReader reader = cmd.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        String s = reader[2].ToString();
                        if (s == story_id)
                        {
                            List<String> list = new List<String>();
                            if(reader[4] != null && reader[4].ToString() != null && reader[4].ToString()!="")
                            {
                                list.Add(reader[4].ToString());
                            }
                            if (reader[5] != null && reader[5].ToString() != null && reader[5].ToString() != "")
                            {
                                list.Add(reader[5].ToString());
                            }
                            if (reader[6] != null && reader[6].ToString() != null && reader[6].ToString() != "")
                            {
                                list.Add(reader[6].ToString());
                            }
                            if (reader[7] != null && reader[7].ToString() != null && reader[7].ToString() != "")
                            {
                                list.Add(reader[7].ToString());
                            }
                            String s1 = reader[4].ToString();
                            String s2 = reader[5].ToString();
                            String s3 = reader[6].ToString();
                            String s4 = reader[7].ToString();
                            q.Add(new question(reader[0].ToString(), reader[3].ToString(), list));
                        }
                    }
                }
                catch (Exception)
                {
                    return null;
                }
                return q;
            }
        }

        private void button4000_Click(object sender, EventArgs e)
        {
            story_choices s = new story_choices(this);
            s.Show();
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            if(last_questions_page==null)
            {
                MessageBox.Show("questions are not availible, make sure you chose a story", "error");
            }
            last_questions_page.sum_questions();
            if(!last_questions_page.check_if_all_questions_answered())
            {
                if (MessageBox.Show("not all questions were answered, are you sure you want to finish?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    showGrade();
                }
            }
            else
            {
                showGrade();
            }

        }

        private void showGrade()
        {
            
            double firstClass = question_choices_page.answered_questions*0.33;
            double secondClass = question_choices_page.answered_questions * 0.66;
            if (firstClass>Convert.ToDouble(last_questions_page.correct_Answeres))
            {
                gradeMessegePopUp gmp = new gradeMessegePopUp(this, 1);
                gmp.Show();
            }
            else if(secondClass > Convert.ToDouble(last_questions_page.correct_Answeres))
            {
                gradeMessegePopUp gmp = new gradeMessegePopUp(this, 2);
                gmp.Show();
            }
            else if(secondClass < Convert.ToDouble(last_questions_page.correct_Answeres))
            {
                gradeMessegePopUp gmp = new gradeMessegePopUp(this, 3);
                gmp.Show();
            }
        }


        public void update_answeres_in_database()
        {
            string fileName = "Database11.accdb";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
            string workingDirectory = Environment.CurrentDirectory;
            String path2 = Directory.GetParent(workingDirectory).Parent.FullName + "\\Database11.accdb";
            string connStr = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;
                    Data Source={0}", path2);
            string query = " UPDATE [Profile] SET [Q_answered] = [Q_answered] + ?, [right_answered]= [right_answered] + ? WHERE [ID]=?";
            //[User Login]=?, [Password]=?,
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, conn);

                //cmd.Parameters.AddWithValue(@"user_login", userNameTB.Text);
               cmd.Parameters.AddWithValue(@"answered", Convert.ToString(question_choices_page.myStory.questions.Count));
               cmd.Parameters.AddWithValue(@"right_answered", Convert.ToString(question_choices_page.correct_Answeres));
               cmd.Parameters.AddWithValue(@"ID",studentID);
                cmd.ExecuteNonQuery();
                try
                {
                   // cmd.ExecuteNonQuery();
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
    }
}
