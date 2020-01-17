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
        public Reports report_main;
        public Student_Progression(Reports main)
        {
            InitializeComponent();
            report_main = main;
        }

        private void Student_Progression_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database11DataSet6.Profile' table. You can move, or remove it, as needed.
            this.profileTableAdapter.Fill(this.database11DataSet6.Profile);

            UpdateFont();
            Upload_data();
        }

        private void UpdateFont()
        {
            //Change cell font
            foreach (DataGridViewColumn c in dataGridView1.Columns)
                c.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 16F, GraphicsUnit.Pixel);
        }

        public void Clear_data()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
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

        private void Clear_Click(object sender, EventArgs e)
        {
            Clear_data();
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            Upload_data();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            Clear_data();

            string x = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string y = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            string z = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

            int a = Convert.ToInt32(y);
            int b = Convert.ToInt32(z);

            chart1.Series["Right_Answered"].Points.AddXY(x, a);
            chart1.Series["Q_answered"].Points.AddXY(x, b);
        }
    }
}
