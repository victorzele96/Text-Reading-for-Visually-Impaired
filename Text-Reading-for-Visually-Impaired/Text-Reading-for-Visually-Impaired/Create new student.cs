using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Reading_for_Visually_Impaired
{
    public partial class Create_new_student : Form
    {
        Color original_text_Color = Color.White;
        Color original_text_Color_Active = Color.White;
        String data_Base_Path = "";
        public Teacher Teacher_main;
        public Create_new_student(Teacher main)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            firstNameTB.SelectionStart = 0;
            maleRB.Checked = true;
            femaleRB.Checked = false;
            original_text_Color = userNameTB.ForeColor;
            headlineLB.Location = new Point((this.Width - headlineLB.Width) / 2 - 10, 10);
            this.Teacher_main = main;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cancelBT_Click(object sender, EventArgs e)
        {
           
            //this.Close();
        }

        private void OKBT_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelBT_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Teacher_main.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            maleRB.Checked = !femaleRB.Checked;
        }

        private void textBox_clicked(object sender, EventArgs e)
        {
            if (sender.GetType().Name == "TextBox")
            {
                if (((TextBox)sender).ForeColor == original_text_Color)
                {
                    ((TextBox)sender).Text = "";
                    ((TextBox)sender).ForeColor = original_text_Color_Active;
                    String tempName = ((TextBox)sender).Name;
                    foreach (Control c in this.Controls)
                    {
                        if (c.GetType() == typeof(TextBox) && ((TextBox)c).Text == "" && c.Name != tempName)
                        {
                            c.ForeColor = original_text_Color;
                            if (c.Name == "firstNameTB" && c.Name != tempName)
                            {
                                c.Text = "first name";
                            }
                            else if (c.Name == "lastNameTB" && c.Name != tempName)
                            {
                                c.Text = "last name";

                            }
                            else if (c.Name == "userNameTB" && c.Name != tempName)
                            {
                                c.Text = "user name";
                            }
                            else if (c.Name == "passwordTB" && c.Name != tempName)
                            {
                                c.Text = "password";
                            }
                            else if (c.Name == "EmailTB" && c.Name != tempName)
                            {
                                c.Text = "E-mail";
                            }
                        }
                    }
                }
            }

        }
        private void EmailTB_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        private void firstNameTB_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                lastNameTB.Focus();
                textBox_clicked(sender, e);
                if (firstNameTB.Text == "")
                {
                    firstNameTB.ForeColor = original_text_Color;
                    firstNameTB.Text = "first name";
                }
            }
            else
            {
                if (firstNameTB.ForeColor == original_text_Color)
                {
                    firstNameTB.ForeColor = original_text_Color_Active;
                    firstNameTB.Text = "";
                }

            }
        }

        private void lastNameTB_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void userNameTB_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void passwordTB_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        private void maleRB_CheckedChanged_1(object sender, EventArgs e)
        {
            femaleRB.Checked = !maleRB.Checked;
        }

        private void femaleRB_CheckedChanged(object sender, EventArgs e)
        {
            maleRB.Checked = !femaleRB.Checked;
        }

        private void OKBT_Click_1(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    if (((TextBox)c).Text == "")
                    {
                        MessageBox.Show("please fill al fields", "error");
                        break;
                    }
                }
            }
            String gender = "Female";
            if (maleRB.Checked)
            {
                gender = "Male";
            }

            string fileName = "Database11.accdb";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
            string workingDirectory = Environment.CurrentDirectory;
            String path2 = Directory.GetParent(workingDirectory).Parent.FullName + "\\Database11.accdb";
            string connStr = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;
                    Data Source={0}", path2);
            string query = " INSERT INTO [Profile] ([ID],[User Login], [Password], [First Name], [Last Name], [Email], [Male / Female], [TeacherID]) VALUES (@id,@user_login , @password , @firstName ,@lastName ,  @email , @gender, @teacherid )  ";

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue(@"id", userNameTB.Text);
                cmd.Parameters.AddWithValue(@"user_login", userNameTB.Text);
                cmd.Parameters.AddWithValue(@"password", passwordTB.Text);
                cmd.Parameters.AddWithValue(@"firstName", firstNameTB.Text);
                cmd.Parameters.AddWithValue(@"lastName", lastNameTB.Text);
                cmd.Parameters.AddWithValue(@"email", EmailTB.Text);
                cmd.Parameters.AddWithValue(@"gender", gender);
                cmd.Parameters.AddWithValue(@"teacherid", Teacher_main.login_main.userName);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("details error", "error");
                }


                //main.Show();
                this.Close();
                this.Teacher_main.Show();

            }
        }

        private void Create_new_student_Load(object sender, EventArgs e)
        {

        }

        private void firstNameTB_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void firstNameTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                lastNameTB.Focus();
                textBox_clicked(sender, e);
                if (firstNameTB.Text == "")
                {
                    firstNameTB.ForeColor = original_text_Color;
                    firstNameTB.Text = "first name";
                }
            }
            else
            {
                if (firstNameTB.ForeColor == original_text_Color)
                {
                    firstNameTB.ForeColor = original_text_Color_Active;
                    firstNameTB.Text = "";
                }

            }
        }

        private void Create_new_student_Paint(object sender, PaintEventArgs e)
        {
            DrawLinePointF(e);
        }
        public void DrawLinePointF(PaintEventArgs e)
        {
            foreach (Control t in this.Controls)
            {
                if (t.GetType() == typeof(TextBox))
                {
                    Pen blackPen = new Pen(original_text_Color_Active, 3);
                    PointF point1 = new PointF(t.Location.X, t.Location.Y + t.Height);
                    PointF point2 = new PointF(t.Location.X + t.Width, t.Location.Y + t.Height);
                    e.Graphics.DrawLine(blackPen, point1, point2);
                }
            }

        }

        private void userNameTB_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                passwordTB.Focus();
                textBox_clicked(sender, e);
                if (userNameTB.Text == "")
                {
                    userNameTB.ForeColor = original_text_Color;
                    userNameTB.Text = "last name";
                }
            }
            else
            {
                if (userNameTB.ForeColor == original_text_Color)
                {
                    userNameTB.ForeColor = original_text_Color_Active;
                    userNameTB.Text = "";
                }

            }
        }

        private void maleRB_CheckedChanged(object sender, EventArgs e)
        {
            femaleRB.Checked = !maleRB.Checked;
        }

        private void EmailTB_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                OKBT.Focus();
                textBox_clicked(sender, e);
                if (EmailTB.Text == "")
                {
                    EmailTB.ForeColor = original_text_Color;
                    EmailTB.Text = "last name";
                }
            }
            else
            {
                if (EmailTB.ForeColor == original_text_Color)
                {
                    EmailTB.ForeColor = original_text_Color_Active;
                    EmailTB.Text = "";
                }

            }
        }

        private void passwordTB_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                EmailTB.Focus();
                textBox_clicked(sender, e);
                if (passwordTB.Text == "")
                {
                    passwordTB.ForeColor = original_text_Color;
                    passwordTB.Text = "last name";
                }
            }
            else
            {
                if (passwordTB.ForeColor == original_text_Color)
                {
                    passwordTB.ForeColor = original_text_Color_Active;
                    passwordTB.Text = "";
                }

            }
        }

        private void lastNameTB_KeyUp(object sender, KeyEventArgs e)
        {
          
        }

        private void userNameTB_KeyUp(object sender, KeyEventArgs e)
        {
          
        }

        private void lastNameTB_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                userNameTB.Focus();
                textBox_clicked(sender, e);
                if (lastNameTB.Text == "")
                {
                    lastNameTB.ForeColor = original_text_Color;
                    lastNameTB.Text = "last name";
                }
            }
            else
            {
                if (lastNameTB.ForeColor == original_text_Color)
                {
                    lastNameTB.ForeColor = original_text_Color_Active;
                    lastNameTB.Text = "";
                }

            }
        }
    }
}
