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
    public partial class Student_Progression : Form
    {
        public bool isAdmin;
        Reports admin_main;
        Teacher teacher_main;
        public Student_Progression(Reports main)
        {
            InitializeComponent();
            admin_main = main;
            isAdmin = true;
        }
        public Student_Progression(Teacher main)
        {
            InitializeComponent();
            teacher_main = main;
            isAdmin = false;
        }

        private void Student_Progression_Load(object sender, EventArgs e)
        {
            Database11DataSetTableAdapters.ProfileTableAdapter pr = new Database11DataSetTableAdapters.ProfileTableAdapter();
            Database11DataSet.ProfileDataTable dt2 = pr.GetData();//pr=profile
            dataGridView1.DataSource = dt2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isAdmin)
                admin_main.Show();
            else
                teacher_main.Show();

            this.Hide();
        }
    }
}
