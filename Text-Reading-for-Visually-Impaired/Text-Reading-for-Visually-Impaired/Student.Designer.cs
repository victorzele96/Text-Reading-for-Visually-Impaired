namespace Text_Reading_for_Visually_Impaired
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.colorDialog4 = new System.Windows.Forms.ColorDialog();
            this.colorDialog5 = new System.Windows.Forms.ColorDialog();
            this.chooseAstory = new System.Windows.Forms.Button();
            this.updateStudentInformation = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button4.Location = new System.Drawing.Point(1283, 712);
            this.button4.Margin = new System.Windows.Forms.Padding(5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(605, 134);
            this.button4.TabIndex = 3;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // chooseAstory
            // 
            this.chooseAstory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chooseAstory.BackColor = System.Drawing.Color.Transparent;
            this.chooseAstory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chooseAstory.BackgroundImage")));
            this.chooseAstory.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chooseAstory.ForeColor = System.Drawing.Color.White;
            this.chooseAstory.Location = new System.Drawing.Point(346, 49);
            this.chooseAstory.Margin = new System.Windows.Forms.Padding(5);
            this.chooseAstory.Name = "chooseAstory";
            this.chooseAstory.Size = new System.Drawing.Size(400, 255);
            this.chooseAstory.TabIndex = 4;
            this.chooseAstory.Text = "Choose a Story";
            this.chooseAstory.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.chooseAstory.UseVisualStyleBackColor = false;
            this.chooseAstory.Click += new System.EventHandler(this.button5_Click);
            // 
            // updateStudentInformation
            // 
            this.updateStudentInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateStudentInformation.BackColor = System.Drawing.Color.Transparent;
            this.updateStudentInformation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateStudentInformation.BackgroundImage")));
            this.updateStudentInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.updateStudentInformation.ForeColor = System.Drawing.Color.White;
            this.updateStudentInformation.Location = new System.Drawing.Point(1021, 49);
            this.updateStudentInformation.Margin = new System.Windows.Forms.Padding(5);
            this.updateStudentInformation.Name = "updateStudentInformation";
            this.updateStudentInformation.Size = new System.Drawing.Size(400, 255);
            this.updateStudentInformation.TabIndex = 5;
            this.updateStudentInformation.Text = "Update Student Information";
            this.updateStudentInformation.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.updateStudentInformation.UseVisualStyleBackColor = false;
            this.updateStudentInformation.Click += new System.EventHandler(this.button6_Click);
            // 
            // logout
            // 
            this.logout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logout.BackgroundImage")));
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(1031, 375);
            this.logout.Margin = new System.Windows.Forms.Padding(5);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(400, 255);
            this.logout.TabIndex = 6;
            this.logout.Text = "Logout";
            this.logout.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.button7_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1578, 644);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.updateStudentInformation);
            this.Controls.Add(this.chooseAstory);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.Controls.SetChildIndex(this.chooseAstory, 0);
            this.Controls.SetChildIndex(this.updateStudentInformation, 0);
            this.Controls.SetChildIndex(this.logout, 0);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ColorDialog colorDialog3;
        private System.Windows.Forms.ColorDialog colorDialog4;
        private System.Windows.Forms.ColorDialog colorDialog5;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button chooseAstory;
        public System.Windows.Forms.Button updateStudentInformation;
        public System.Windows.Forms.Button logout;
    }
}