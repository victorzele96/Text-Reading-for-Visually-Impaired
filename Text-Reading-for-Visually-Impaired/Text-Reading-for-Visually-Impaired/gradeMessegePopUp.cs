using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Reading_for_Visually_Impaired
{
    public partial class gradeMessegePopUp : Form
    {
        List<PictureBox> picList;
        public gradeMessegePopUp(second_Page main, int grade)
        {
            InitializeComponent();
            picList = new List<PictureBox>(){ pictureBox1, pictureBox2, pictureBox3 };
           // picList[0] = pictureBox1;
            //picList[1] = pictureBox2;
            //picList[2] = pictureBox3;
            foreach(Control c in Controls)
            {
                if(c is PictureBox)
                {
                    ((PictureBox)c).Image = System.Drawing.Image.FromFile(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\resources\\" + "empty_star" + ".bmp");
                }
            }
            for(int i=0;i<grade;i++)
                ((PictureBox)picList[i]).Image = System.Drawing.Image.FromFile(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\resources\\" + "full_star" + ".png");
            if(grade==3)
            {
                msgLB.Text = "Excellent work!!";
            }
            else if (grade == 2)
            {
                msgLB.Text = "Good job!!";
            }
            if (grade == 1)
            {
                msgLB.Text = "Better luck next time";
            }
            gradeLb.Text = string.Format("{0}/{1}", main.last_questions_page.correct_Answeres, main.last_questions_page.myStory.questions.Count);
        }

        private void backBt_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gradeMessegePopUp_Load(object sender, EventArgs e)
        {

        }
    }
}
