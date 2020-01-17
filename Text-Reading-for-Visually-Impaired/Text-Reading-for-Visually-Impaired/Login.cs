using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Text_Reading_for_Visually_Impaired
{
    public partial class Login :Test
    {

        public String userName;
        public String password;

        public String first_name;
        public String last_name;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration r = new Registration(this);
            r.ShowDialog();
            this.Close();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (e.KeyChar == (char)13)
                txtPassword.Focus();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnLogin.PerformClick();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please enter your username.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            try
            {
                //Get data from user table
                Database11DataSetTableAdapters.AdminTableAdapter admin = new Database11DataSetTableAdapters.AdminTableAdapter();
                Database11DataSet.AdminDataTable dt = admin.GetDataByUsernamePassword(txtUsername.Text, txtPassword.Text);
                Database11DataSetTableAdapters.TeacherTableAdapter teacher = new Database11DataSetTableAdapters.TeacherTableAdapter();
                Database11DataSet.TeacherDataTable dt1 = teacher.GetDataByUsernamePasswordTeacher(txtUsername.Text, txtPassword.Text);
                Database11DataSetTableAdapters.ProfileTableAdapter student = new Database11DataSetTableAdapters.ProfileTableAdapter();
                Database11DataSet.ProfileDataTable dt2 = student.GetDataByUsernamePasswordProfile(txtUsername.Text, txtPassword.Text);
                //Check row > 0
                this.userName = txtUsername.Text;
                
                this.password = txtPassword.Text;
                
                if (dt.Rows.Count > 0)
                {
                    txtPassword.Text = "";
                    txtUsername.Text = "";
                    //Process your login here
                    this.Hide();
                    Admin ad = new Admin(this);
                    ad.ShowDialog();
                    this.Close();
                }
                else if(dt1.Rows.Count > 0)
                {
                    txtPassword.Text = "";
                    txtUsername.Text = "";
                    //Process your login here
                    this.Hide();
                    Teacher th = new Teacher(this);
                    th.ShowDialog();
                    
                    this.Close();

                }
                else if(dt2.Rows.Count > 0)
                {
                    //Process your login here
                    //this.Hide();
                    txtPassword.Text = "";
                    txtUsername.Text = "";
                    Student st = new Student(this);
                    st.Show();
                    st.Theme_color(ExitBT.ForeColor, ExitBT.BackColor, Login.ActiveForm.BackColor);
                    this.Hide();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Your username or password is incorrect.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Exit(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            //panel1.Location = new Point((ClientSize.Width - panel1.Width) / 2,(ClientSize.Height-panel1.Height)/2);
            ExitBT.Location = new Point((ClientSize.Width - ExitBT.Width), ClientSize.Height - ExitBT.Height);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public bool user_name_Admin(string user,string pass)
        {
            Database11DataSetTableAdapters.AdminTableAdapter admin = new Database11DataSetTableAdapters.AdminTableAdapter();
            Database11DataSet.AdminDataTable dt = admin.GetDataByUsernamePassword(user, pass);
            if (dt.Rows.Count > 0)
                    return true;
            else
                return false;
        }
        public bool user_name_Teacher(string user, string pass)
        {
            Database11DataSetTableAdapters.TeacherTableAdapter teacher = new Database11DataSetTableAdapters.TeacherTableAdapter();
            Database11DataSet.TeacherDataTable dt1 = teacher.GetDataByUsernamePasswordTeacher(user, pass);
            if (dt1.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public bool user_name_Student(string user, string pass)
        {
            Database11DataSetTableAdapters.ProfileTableAdapter student = new Database11DataSetTableAdapters.ProfileTableAdapter();
            Database11DataSet.ProfileDataTable dt2 = student.GetDataByUsernamePasswordProfile(user, pass);
            if (dt2.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}

