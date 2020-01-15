using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Text_Reading_for_Visually_Impaired
{
    public partial class story_choices : Form
    {
        second_Page main;
        List<story> myList;
        public story_choices(second_Page sp, List <story> list)
        {
            main = sp;
            myList = list;
            this.BackColor = main.BackColor;
            this.ForeColor = main.insertTxtLb.ForeColor;
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Story_choices_Load(object sender, EventArgs e)
        {
            panel1.AutoScroll = false;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = true;
            int lastLocation = 3;
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
            foreach(Control rb in panel1.Controls)
            {
                if (rb is RadioButton)
                {
                    if(((RadioButton)rb).Checked)
                    {
                       // main.fillRichTextBox(((RadioButton)rb).Text);
                        main.chosen_story = get_story_by_name(((RadioButton)rb).Text);
                        main.chosen_story.questions = main.get_story_questions(main.chosen_story.ID);
                        main.richTextBox1.Text = main.chosen_story.text;
                        break;
                    }
                }
            }
            this.Hide();
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
