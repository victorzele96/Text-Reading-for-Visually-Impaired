using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Reading_for_Visually_Impaired
{
    public partial class question_choices : Form
    {
        second_Page main;
        List<String> myList;
        public question_choices(second_Page sp, List<String> list)
        {
            main = sp;
            myList = list;
            this.BackColor = main.BackColor;
            this.ForeColor = main.insertTxtLb.ForeColor;
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void question_choices_Load(object sender, EventArgs e)
        {

        }
    }
}
