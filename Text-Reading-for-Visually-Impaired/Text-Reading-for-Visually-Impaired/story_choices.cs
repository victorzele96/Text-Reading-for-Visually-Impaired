using System;
using System.Collections.Generic;
using System.Drawing;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace Text_Reading_for_Visually_Impaired
{
    public partial class story_choices : Form
    {
        second_Page main;
        List<story> myList;
        List<String> voicesList;
        Boolean isStoryList;
        Boolean is_teacher_for_student;
        teacherModel myTeacher;
        Teacher teacher_main;
        Student studentmain;
        public story_choices(second_Page sp, List <story> list)
        {
            main = sp;
            myList = list;
            this.BackColor = main.BackColor;
            this.ForeColor = main.insertTxtLb.ForeColor;

            InitializeComponent();
            isStoryList = true;
            this.CenterToScreen();
        }

        public story_choices(second_Page sp)
        {
            InitializeComponent();
            isStoryList = false;
            main = sp;
            voicesList = new List<string>();
            foreach (InstalledVoice voice in main.synth.GetInstalledVoices())
            {
                voicesList.Add(voice.VoiceInfo.Name);
            }
        }

        public story_choices(Teacher sp, teacherModel tm)
        {
            InitializeComponent();
            is_teacher_for_student = true;
            this.myTeacher = tm;
            teacher_main = sp;
            this.CenterToScreen();
        }

        private void Story_choices_Load(object sender, EventArgs e)
        {
            button1.BackColor = this.BackColor;
            button1.ForeColor = this.ForeColor;
            button2.BackColor = this.BackColor;
            button2.ForeColor = this.ForeColor;
            panel1.AutoScroll = false;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = true;
            int lastLocation = 3;
            if (isStoryList)
            { 
                foreach (story s in myList)
                {
                    RadioButton newButton = new RadioButton();
                    newButton.Text = s.name;
                    newButton.Width = panel1.Width;
                    newButton.Height = 102;
                    newButton.BackColor = this.BackColor;
                    newButton.ForeColor = this.ForeColor;
                    newButton.Font = main.richTextBox1.Font;
                    panel1.Controls.Add(newButton);
                    newButton.Location = new Point(2, lastLocation);
                    lastLocation += newButton.Size.Height + 10;
                }
            }
            else if(is_teacher_for_student)
            {
                foreach (studentModel sm in myTeacher.students)
                {
                    RadioButton newButton = new RadioButton();
                    newButton.Text = sm.firstName + " " + sm.lastName;
                    newButton.Width = panel1.Width;
                    newButton.Height = 102;
                    newButton.BackColor = this.BackColor;
                    newButton.ForeColor = this.ForeColor;
                    newButton.Font = teacher_main.login_main.label2.Font;
                    panel1.Controls.Add(newButton);
                    newButton.Location = new Point(2, lastLocation);
                    lastLocation += newButton.Size.Height + 10;
                }
            }
            else
            {
               
                foreach (String s in voicesList)
                {
                    RadioButton newButton = new RadioButton();
                    newButton.Text = s;
                    newButton.Width = panel1.Width;
                    newButton.Height = 102;
                    newButton.BackColor = this.BackColor;
                    newButton.ForeColor = this.ForeColor;
                    newButton.Font = main.richTextBox1.Font;
                    panel1.Controls.Add(newButton);
                    newButton.Location = new Point(2, lastLocation);
                    lastLocation += newButton.Size.Height + 10;
                }
            }
           
        }

        private story get_story_by_name(String name)
        {
            foreach(story s in myList)
            {
                if(s.name==name)
                {
                    return s;
                }
            }
            return null;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(isStoryList)
            {
                foreach (Control rb in panel1.Controls)
                {
                    if (rb is RadioButton)
                    {
                        if (((RadioButton)rb).Checked)
                        {
                            // main.fillRichTextBox(((RadioButton)rb).Text);
                            main.chosen_story = get_story_by_name(((RadioButton)rb).Text);
                            //main.question_choices_page = new question_choices(main, main.chosen_story);
                            main.chosen_story.questions = main.get_story_questions(main.chosen_story.ID);
                            main.richTextBox1.Text = main.chosen_story.text;
                            break;
                        }
                    }
                }
                this.Hide();
            }
            else if(is_teacher_for_student)
            {
                foreach (Control rb in panel1.Controls)
                {
                    if (rb is RadioButton)
                    {
                        if (((RadioButton)rb).Checked)
                        {
                            second_Page sp = new second_Page(teacher_main,myTeacher);
                            foreach(studentModel s_m in myTeacher.students)
                            {
                                if(s_m.firstName+" " + s_m.lastName == ((RadioButton)rb).Text)
                                {
                                    main.studentID = s_m.userName;
                                    //main.myStudent.ID = s_m.userName;
                                }
                            }
                            sp.Show();
                            this.Hide();
                        }
                    }
                }
            }
            else
            {
                foreach (Control rb in panel1.Controls)
                {
                    if (rb is RadioButton)
                    {
                        if (((RadioButton)rb).Checked)
                        {
                            main.synth.SelectVoice(rb.Text);
                            break;
                        }
                    }
                }
                this.Hide();
            }
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
