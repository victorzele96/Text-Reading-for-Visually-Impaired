using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Reading_for_Visually_Impaired
{
    public partial class Registration : Form
    {
        Color original_text_Color = Color.White ;
        String data_Base_Path = "";
        public Registration()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            firstNameTB.SelectionStart = 0;
            maleRB.Checked = true;
            femaleRB.Checked = false;
            original_text_Color = userNameTB.ForeColor;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void firstNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_clicked(object sender, EventArgs e)
        {
            if (sender.GetType().Name == "TextBox")
            {
                if (((TextBox)sender).ForeColor == original_text_Color)
                {
                    ((TextBox)sender).Text = "";
                    ((TextBox)sender).ForeColor = Color.Black;
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

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void firstNameTB_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void firstNameTB_KeyDown(object sender, KeyEventArgs e)
        {

            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            femaleRB.Checked = !maleRB.Checked;
        }

        private void femaleRB_CheckedChanged(object sender, EventArgs e)
        {
            maleRB.Checked = !femaleRB.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registration_Load_1(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    if (((TextBox)c).Text == "")
                    {
                        MessageBox.Show("please fill al fields", "error");
                    }
                }
            }
            String gender = "Female";
            if (maleRB.Checked)
            {
                gender = "Male";
            }
            string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;
                    Data Source=|DataDirectory|\Database11.accdb";
            string query = " INSERT INTO [Teacher] VALUES ( @id  , @user_login , @password , @firstName ,@lastName ,  @email , @gender )  ";
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue(@"id", lastNameTB.Text);
                cmd.Parameters.AddWithValue(@"user_login", userNameTB.Text);
                cmd.Parameters.AddWithValue(@"password", passwordTB.Text);
                cmd.Parameters.AddWithValue(@"firstName", firstNameTB.Text);
                cmd.Parameters.AddWithValue(@"lastName", lastNameTB.Text);
                cmd.Parameters.AddWithValue(@"email", EmailTB.Text);
                cmd.Parameters.AddWithValue(@"gender", gender);
                OleDbDataReader reader = cmd.ExecuteReader();
                reader.Read();
                firstNameTB.Text = reader[0].ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    firstNameTB.ForeColor = Color.Black;
                    firstNameTB.Text = "";
                }

            }
        }

        private void lastNameTB_KeyDown(object sender, KeyEventArgs e)
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
                    lastNameTB.ForeColor = Color.Black;
                    lastNameTB.Text = "";
                }

            }
        }

        private void userNameTB_KeyDown(object sender, KeyEventArgs e)
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
                    userNameTB.ForeColor = Color.Black;
                    userNameTB.Text = "";
                }

            }
        }

        private void passwordTB_KeyDown(object sender, KeyEventArgs e)
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
                    passwordTB.ForeColor = Color.Black;
                    passwordTB.Text = "";
                }

            }
        }


        public void DrawLinePointF(PaintEventArgs e)
        {

            foreach(Control t in this.Controls)
            {
                if(t.GetType() == typeof(TextBox))
                {
                    Pen blackPen = new Pen(t.ForeColor, 3);
                    PointF point1 = new PointF(t.Location.Y + t.Height, t.Location.X);
                    PointF point2 = new PointF(t.Location.Y + t.Height, t.Location.X + t.Width);
                    e.Graphics.DrawLine(blackPen, point1, point2);
                }
            }
  
        }

        private void EmailTB_KeyDown(object sender, KeyEventArgs e)
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
                    EmailTB.ForeColor = Color.Black;
                    EmailTB.Text = "";
                }

            }
        }
    }
}
