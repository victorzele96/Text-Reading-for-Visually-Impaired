namespace Text_Reading_for_Visually_Impaired
{
    partial class Create_new_student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param ID="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.headlineLB = new System.Windows.Forms.Label();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.userNameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.OKBT = new System.Windows.Forms.Button();
            this.cancelBT = new System.Windows.Forms.Button();
            this.maleRB = new System.Windows.Forms.RadioButton();
            this.femaleRB = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // headlineLB
            // 
            this.headlineLB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headlineLB.AutoSize = true;
            this.headlineLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headlineLB.Location = new System.Drawing.Point(557, 9);
            this.headlineLB.Name = "headlineLB";
            this.headlineLB.Size = new System.Drawing.Size(232, 69);
            this.headlineLB.TabIndex = 1;
            this.headlineLB.Text = "Sign up";
            this.headlineLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // firstNameTB
            // 
            this.firstNameTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstNameTB.BackColor = System.Drawing.Color.Gainsboro;
            this.firstNameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTB.Location = new System.Drawing.Point(242, 254);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(367, 51);
            this.firstNameTB.TabIndex = 2;
            this.firstNameTB.Text = "first ID";
            this.firstNameTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.firstNameTB_MouseClick);
            this.firstNameTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.firstNameTB_KeyDown);
            // 
            // lastNameTB
            // 
            this.lastNameTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastNameTB.BackColor = System.Drawing.Color.Gainsboro;
            this.lastNameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTB.Location = new System.Drawing.Point(862, 254);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(367, 51);
            this.lastNameTB.TabIndex = 3;
            this.lastNameTB.Text = "last ID";
            this.lastNameTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lastNameTB_KeyDown_1);
            this.lastNameTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lastNameTB_KeyUp);
            // 
            // userNameTB
            // 
            this.userNameTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userNameTB.BackColor = System.Drawing.Color.Gainsboro;
            this.userNameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTB.Location = new System.Drawing.Point(242, 399);
            this.userNameTB.Name = "userNameTB";
            this.userNameTB.Size = new System.Drawing.Size(367, 51);
            this.userNameTB.TabIndex = 4;
            this.userNameTB.Text = "user ID (id)";
            this.userNameTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userNameTB_KeyDown_1);
            this.userNameTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.userNameTB_KeyUp);
            // 
            // passwordTB
            // 
            this.passwordTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTB.BackColor = System.Drawing.Color.Gainsboro;
            this.passwordTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.Location = new System.Drawing.Point(862, 399);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(367, 51);
            this.passwordTB.TabIndex = 5;
            this.passwordTB.Text = "password";
            this.passwordTB.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.passwordTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTB_KeyDown_1);
            // 
            // EmailTB
            // 
            this.EmailTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailTB.BackColor = System.Drawing.Color.Gainsboro;
            this.EmailTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTB.Location = new System.Drawing.Point(242, 532);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(367, 51);
            this.EmailTB.TabIndex = 6;
            this.EmailTB.Text = "E - mail";
            this.EmailTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmailTB_KeyDown_1);
            // 
            // OKBT
            // 
            this.OKBT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OKBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKBT.Location = new System.Drawing.Point(386, 660);
            this.OKBT.Name = "OKBT";
            this.OKBT.Size = new System.Drawing.Size(290, 75);
            this.OKBT.TabIndex = 7;
            this.OKBT.Text = "Confirm";
            this.OKBT.UseVisualStyleBackColor = true;
            this.OKBT.Click += new System.EventHandler(this.OKBT_Click_1);
            // 
            // cancelBT
            // 
            this.cancelBT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBT.Location = new System.Drawing.Point(745, 660);
            this.cancelBT.Name = "cancelBT";
            this.cancelBT.Size = new System.Drawing.Size(290, 75);
            this.cancelBT.TabIndex = 8;
            this.cancelBT.Text = "Back";
            this.cancelBT.UseVisualStyleBackColor = true;
            this.cancelBT.Click += new System.EventHandler(this.cancelBT_Click_1);
            // 
            // maleRB
            // 
            this.maleRB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maleRB.AutoSize = true;
            this.maleRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRB.Location = new System.Drawing.Point(932, 497);
            this.maleRB.Name = "maleRB";
            this.maleRB.Size = new System.Drawing.Size(145, 56);
            this.maleRB.TabIndex = 9;
            this.maleRB.TabStop = true;
            this.maleRB.Text = "male";
            this.maleRB.UseVisualStyleBackColor = true;
            this.maleRB.CheckedChanged += new System.EventHandler(this.maleRB_CheckedChanged);
            // 
            // femaleRB
            // 
            this.femaleRB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.femaleRB.AutoSize = true;
            this.femaleRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRB.Location = new System.Drawing.Point(932, 565);
            this.femaleRB.Name = "femaleRB";
            this.femaleRB.Size = new System.Drawing.Size(183, 56);
            this.femaleRB.TabIndex = 10;
            this.femaleRB.TabStop = true;
            this.femaleRB.Text = "female";
            this.femaleRB.UseVisualStyleBackColor = true;
            this.femaleRB.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Create_new_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1578, 881);
            this.Controls.Add(this.femaleRB);
            this.Controls.Add(this.maleRB);
            this.Controls.Add(this.cancelBT);
            this.Controls.Add(this.OKBT);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.userNameTB);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.headlineLB);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Create_new_student";
            this.Text = "Create_new_student";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Create_new_student_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Create_new_student_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label headlineLB;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.TextBox userNameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.Button OKBT;
        private System.Windows.Forms.Button cancelBT;
        private System.Windows.Forms.RadioButton maleRB;
        private System.Windows.Forms.RadioButton femaleRB;
    }
}