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
    public partial class T_student_Progress : Form
    {
        Teacher_Reports teacher_rep;
        public T_student_Progress(Teacher_Reports main)
        {
            InitializeComponent();
            teacher_rep = main;
        }

        private void T_student_Progress_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database11DataSet6.Profile' table. You can move, or remove it, as needed.
            this.profileTableAdapter.Fill(this.database11DataSet6.Profile);
            dataGridView1.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.teacher_rep.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Upload_data();
        }

        public void Upload_data()
        {
            Clear_data();
            int a, b;
            string x, y, z;
            // int counter = 0;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                if (r.Index < dataGridView1.Rows.Count - 1)
                {
                    if (((DataGridViewRow)r).Cells[2].Value.ToString() == teacher_rep.Teacher_main.login_main.userName)
                    {
                        x = ((DataGridViewRow)r).Cells[0].Value.ToString();
                        y = ((DataGridViewRow)r).Cells[3].Value.ToString();
                        z = ((DataGridViewRow)r).Cells[4].Value.ToString();

                        a = Convert.ToInt32(y);
                        b = Convert.ToInt32(z);

                        chart1.Series["Right_Answered"].Points.AddXY(x, a);
                        chart1.Series["Q_answered"].Points.AddXY(x, b);
                    }
                }
            }
        }
        public void Clear_data()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
        }
    }
}
