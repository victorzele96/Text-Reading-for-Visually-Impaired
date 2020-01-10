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

namespace Text_Reading_for_Visually_Impaired
{
    public partial class second_Page : Test
    {
        List<String> textFiles_List;
        Boolean paused = false;
        Boolean stopped = false;
        SpeechSynthesizer synth = new SpeechSynthesizer();
        string Text_To_Read = "";
        public Teacher Teacher_main;
        public second_Page(Teacher main)
        {
            InitializeComponent();
            synth = new SpeechSynthesizer();
            this.WindowState = FormWindowState.Maximized;
            richTextBox1.DragDrop += RichTextBox1_DragDrop;
            richTextBox1.DragEnter += RichTextBox1_DragEnter;
            synth.SpeakProgress += new EventHandler<SpeakProgressEventArgs>(speak_in_progress);
            this.Teacher_main = main;
            richTextBox1.Width = ClientSize.Width;
        }
        public second_Page()
        {
            InitializeComponent();
            
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
    }
}
