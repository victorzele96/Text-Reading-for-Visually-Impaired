﻿namespace Text_Reading_for_Visually_Impaired
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.maleRB = new System.Windows.Forms.RadioButton();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.OKBT = new System.Windows.Forms.Button();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.userNameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.cancelBT = new System.Windows.Forms.Button();
            this.femaleRB = new System.Windows.Forms.RadioButton();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(584, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 89);
            this.label2.TabIndex = 0;
            this.label2.Text = "sign in";
            // 
            // maleRB
            // 
            this.maleRB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maleRB.AutoSize = true;
            this.maleRB.Font = new System.Drawing.Font("Arial", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.maleRB.ForeColor = System.Drawing.Color.White;
            this.maleRB.Location = new System.Drawing.Point(921, 441);
            this.maleRB.Name = "maleRB";
            this.maleRB.Size = new System.Drawing.Size(187, 70);
            this.maleRB.TabIndex = 1;
            this.maleRB.TabStop = true;
            this.maleRB.Text = "male";
            this.maleRB.UseVisualStyleBackColor = true;
            // 
            // firstNameTB
            // 
            this.firstNameTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstNameTB.BackColor = System.Drawing.Color.MidnightBlue;
            this.firstNameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameTB.Font = new System.Drawing.Font("Arial", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.firstNameTB.ForeColor = System.Drawing.Color.DarkGray;
            this.firstNameTB.Location = new System.Drawing.Point(231, 198);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(367, 68);
            this.firstNameTB.TabIndex = 2;
            this.firstNameTB.Text = "first name";
            this.firstNameTB.Click += new System.EventHandler(this.textBox_clicked);
            this.firstNameTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.firstNameTB_KeyDown_1);
            // 
            // OKBT
            // 
            this.OKBT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OKBT.BackColor = System.Drawing.Color.LightSteelBlue;
            this.OKBT.Font = new System.Drawing.Font("Arial", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.OKBT.Location = new System.Drawing.Point(789, 625);
            this.OKBT.Name = "OKBT";
            this.OKBT.Size = new System.Drawing.Size(200, 102);
            this.OKBT.TabIndex = 3;
            this.OKBT.Text = "OK";
            this.OKBT.UseVisualStyleBackColor = false;
            this.OKBT.Click += new System.EventHandler(this.OK_Click);
            // 
            // lastNameTB
            // 
            this.lastNameTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastNameTB.BackColor = System.Drawing.Color.MidnightBlue;
            this.lastNameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameTB.Font = new System.Drawing.Font("Arial", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lastNameTB.ForeColor = System.Drawing.Color.DarkGray;
            this.lastNameTB.Location = new System.Drawing.Point(851, 198);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(367, 68);
            this.lastNameTB.TabIndex = 4;
            this.lastNameTB.Text = "last name";
            this.lastNameTB.Click += new System.EventHandler(this.textBox_clicked);
            this.lastNameTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lastNameTB_KeyDown);
            // 
            // userNameTB
            // 
            this.userNameTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userNameTB.BackColor = System.Drawing.Color.MidnightBlue;
            this.userNameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTB.Font = new System.Drawing.Font("Arial", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.userNameTB.ForeColor = System.Drawing.Color.DarkGray;
            this.userNameTB.Location = new System.Drawing.Point(231, 343);
            this.userNameTB.Name = "userNameTB";
            this.userNameTB.Size = new System.Drawing.Size(367, 68);
            this.userNameTB.TabIndex = 5;
            this.userNameTB.Text = "user name";
            this.userNameTB.Click += new System.EventHandler(this.textBox_clicked);
            this.userNameTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userNameTB_KeyDown);
            // 
            // passwordTB
            // 
            this.passwordTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTB.BackColor = System.Drawing.Color.MidnightBlue;
            this.passwordTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTB.Font = new System.Drawing.Font("Arial", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.passwordTB.ForeColor = System.Drawing.Color.DarkGray;
            this.passwordTB.Location = new System.Drawing.Point(851, 343);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(367, 68);
            this.passwordTB.TabIndex = 6;
            this.passwordTB.Text = "password";
            this.passwordTB.Click += new System.EventHandler(this.textBox_clicked);
            this.passwordTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTB_KeyDown);
            // 
            // cancelBT
            // 
            this.cancelBT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelBT.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cancelBT.Font = new System.Drawing.Font("Arial", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cancelBT.Location = new System.Drawing.Point(432, 624);
            this.cancelBT.Name = "cancelBT";
            this.cancelBT.Size = new System.Drawing.Size(222, 105);
            this.cancelBT.TabIndex = 7;
            this.cancelBT.Text = "Cancel";
            this.cancelBT.UseVisualStyleBackColor = false;
            this.cancelBT.Click += new System.EventHandler(this.button3_Click);
            // 
            // femaleRB
            // 
            this.femaleRB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.femaleRB.AutoSize = true;
            this.femaleRB.Font = new System.Drawing.Font("Arial", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.femaleRB.ForeColor = System.Drawing.Color.White;
            this.femaleRB.Location = new System.Drawing.Point(921, 509);
            this.femaleRB.Name = "femaleRB";
            this.femaleRB.Size = new System.Drawing.Size(237, 70);
            this.femaleRB.TabIndex = 8;
            this.femaleRB.TabStop = true;
            this.femaleRB.Text = "female";
            this.femaleRB.UseVisualStyleBackColor = true;
            // 
            // EmailTB
            // 
            this.EmailTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailTB.BackColor = System.Drawing.Color.MidnightBlue;
            this.EmailTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailTB.Font = new System.Drawing.Font("Arial", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.EmailTB.ForeColor = System.Drawing.Color.DarkGray;
            this.EmailTB.Location = new System.Drawing.Point(231, 476);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(367, 68);
            this.EmailTB.TabIndex = 9;
            this.EmailTB.Text = "E-mail";
            this.EmailTB.Click += new System.EventHandler(this.textBox_clicked);
            this.EmailTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmailTB_KeyDown);
            // 
            // Registration
            // 
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1557, 769);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.femaleRB);
            this.Controls.Add(this.cancelBT);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.userNameTB);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.OKBT);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.maleRB);
            this.Controls.Add(this.label2);
            this.Name = "Registration";
            this.ShowIcon = false;
            this.Text = "registration";
            this.Load += new System.EventHandler(this.Registration_Load_1);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Registration_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton maleRB;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.Button OKBT;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.TextBox userNameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button cancelBT;
        private System.Windows.Forms.RadioButton femaleRB;
        private System.Windows.Forms.TextBox EmailTB;
    }
}