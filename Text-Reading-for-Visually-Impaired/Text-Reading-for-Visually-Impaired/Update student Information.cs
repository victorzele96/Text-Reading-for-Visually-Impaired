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
    public partial class Update_student_Information : Form
    {
        public Student Student_main;
        public Update_student_Information(Student main)
        {
            InitializeComponent();
            this.Student_main = main;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Student_main.Show();
            //this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Database11DataSetTableAdapters.ProfileTableAdapter pr = new Database11DataSetTableAdapters.ProfileTableAdapter();
            Database11DataSet.ProfileDataTable dt1 = pr.GetData();//pr=profile
            dataGridView1.DataSource = dt1;

            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    String x = (String)r.Cells[0].Value;
                    String y = textBox6.Text;
                    if (x == y)
                    {
                        textBox3.Text = ((DataGridViewRow)r).Cells["ID"].Value.ToString();
                        textBox1.Text = ((DataGridViewRow)r).Cells["First Name"].Value.ToString();
                        textBox2.Text = ((DataGridViewRow)r).Cells["Last Name"].Value.ToString();
                        textBox4.Text = ((DataGridViewRow)r).Cells["Male / Female"].Value.ToString();
                        textBox5.Text = ((DataGridViewRow)r).Cells["Email"].Value.ToString();
                    }
                }
            }
            else 
                MessageBox.Show("The account does not exist in the system!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox6.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }

        private void Update_student_Information_Load(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            this.ForeColor = Student_main.ForeColor;
            this.BackColor = Student_main.BackColor;
            foreach (Button butt in this.Controls.OfType<Button>())
            {
                butt.BackColor = Student_main.button5.BackColor;
                butt.ForeColor = Student_main.button4.ForeColor;
            }
            foreach (Label lab in this.Controls.OfType<Label>())
            {
                lab.ForeColor = Student_main.button4.ForeColor;
                lab.BackColor = Student_main.button4.BackColor;
            }
        }
    }
}
