using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Text_Reading_for_Visually_Impaired
{
    public partial class Add : Form
    {
        public Admin Admin_main;
        public Teacher Teacher_main;
        public bool isAdmin;
        public Add(Admin main)
        {
            InitializeComponent();
            this.Admin_main = main;
        }

        public Add(Teacher main)
        {
            InitializeComponent();
            this.Teacher_main = main;
        }

        public Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_main.Show();
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string str_file_path = openFileDialog1.FileName;
                //MessageBox.Show(str_file_path);  //prints the file path

                string readText = File.ReadAllText(str_file_path);
                StoryRTB.Text = readText;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (StoryRTB.Text == "" || story_nameTB.Text == "")
            {
                MessageBox.Show("Please fill all fields", "Error!");
            }
            else
            {
                story new_story = new story(story_nameTB.Text, StoryRTB.Text, "Admin", null);
                /*if()
                {
                    MessageBox.Show("Data was saved!");
                }
                StoryRTB.Text = "";
                story_nameTB.Text = "";*/
            }
        }

        private void Add_questionBTN_Click(object sender, EventArgs e)
        {
            add_questions add_Questions = new add_questions(this);
            add_Questions.ShowDialog();
        }

        private void UpdatesRTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
