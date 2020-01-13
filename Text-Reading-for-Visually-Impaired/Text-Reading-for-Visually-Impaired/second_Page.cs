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
        SpeechSynthesizer synth = new SpeechSynthesizer();
        string Text_To_Read = "";
        String user_ID;
        public Teacher Teacher_main;
        public Student student_main;
        List<story> stories_List = new List<story>();
        String teacherID;
        Color backSColor; //famous stories button backcolor
        Color storyBtColor; //famous stories button forecolor
        Color questionBtColor; //questions button backcolor
        Color backQColor; //questions button forecolor
        public second_Page(Teacher main)
        {
            InitializeComponent();
            synth = new SpeechSynthesizer();
            this.WindowState = FormWindowState.Maximized;
            richTextBox1.DragDrop += RichTextBox1_DragDrop;
            richTextBox1.DragEnter += RichTextBox1_DragEnter;
            synth.SpeakProgress += new EventHandler<SpeakProgressEventArgs>(speak_in_progress);
            this.Teacher_main = main;
            this.is_Teacher = true;
            this.button6.Text = "save story";
            build_Stories_List();
            richTextBox1.Width = ClientSize.Width;
        }

        public second_Page(Student main)
        {
            InitializeComponent();
            synth = new SpeechSynthesizer();
            this.WindowState = FormWindowState.Maximized;
            richTextBox1.DragDrop += RichTextBox1_DragDrop;
            richTextBox1.DragEnter += RichTextBox1_DragEnter;
            synth.SpeakProgress += new EventHandler<SpeakProgressEventArgs>(speak_in_progress);
            this.student_main = main;
            this.is_Teacher = false;
            this.button6.Text = "questions";
            build_Stories_List();
            richTextBox1.Width = ClientSize.Width;
        }


        public second_Page()
        {
            InitializeComponent();
            
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
            this.backSColor = button5.BackColor;
            this.storyBtColor = button5.ForeColor;
            this.questionBtColor = button6.ForeColor;
            this.backQColor = button6.BackColor;
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
            story_choices nePage = new story_choices(this,textFiles_List);
            nePage.Show();
        }

        public void fillRichTextBox(string name)
        {
            richTextBox1.Text = "";
            String path = Application.StartupPath + "\\text_files\\" + name + ".txt";
            richTextBox1.LoadFile(path, RichTextBoxStreamType.PlainText);
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
                button5.BackColor = this.backSColor;
                button5.ForeColor = this.storyBtColor;
                button6.ForeColor = this.questionBtColor;
                button6.BackColor = this.backQColor;
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
            else
            {
                student_main.Show();
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            if(is_Teacher)
            {
                fileNamePopUp fnp = new fileNamePopUp(this);
                fnp.Show();
            }
            else
            {
                question_choices nePage = new question_choices(this, stories_List);
                nePage.Show();
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
                        story s = new story(reader[3].ToString(),reader[0].ToString(),reader[2].ToString(),reader[1].ToString(),new List<question>());
                        stories_List.Add(s);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("details error", "error");
                }
            }
        }

        public void set_user_ID()
        {
            String user_Name;
            String query;
            if(is_Teacher)
            {
                user_Name = this.Teacher_main.login_main.userName;
                query = " SELECT * FROM Teacher WHERE [User Login]=@user_Name";
            }
            else
            {
                user_Name = this.student_main.login_main.userName;
                query = " SELECT * FROM Profile WHERE [User Login]=@user_Name";
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
                cmd.Parameters.AddWithValue("@user_Name", user_Name);
                OleDbDataReader reader = cmd.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        if(reader[1].ToString()==user_Name)
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
        }

       
    }
}
