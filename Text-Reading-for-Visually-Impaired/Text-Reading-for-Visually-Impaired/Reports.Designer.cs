namespace Text_Reading_for_Visually_Impaired
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.userDetails = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.feedback = new System.Windows.Forms.Button();
            this.studentProgression = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userDetails
            // 
            this.userDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userDetails.BackColor = System.Drawing.Color.Transparent;
            this.userDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userDetails.BackgroundImage")));
            this.userDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.userDetails.ForeColor = System.Drawing.Color.White;
            this.userDetails.Location = new System.Drawing.Point(587, 58);
            this.userDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userDetails.Name = "userDetails";
            this.userDetails.Size = new System.Drawing.Size(400, 255);
            this.userDetails.TabIndex = 0;
            this.userDetails.Text = "Users Details";
            this.userDetails.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.userDetails.UseVisualStyleBackColor = false;
            this.userDetails.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(1322, 576);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // feedback
            // 
            this.feedback.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.feedback.BackColor = System.Drawing.Color.Black;
            this.feedback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("feedback.BackgroundImage")));
            this.feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.feedback.ForeColor = System.Drawing.Color.White;
            this.feedback.Location = new System.Drawing.Point(1064, 58);
            this.feedback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.feedback.Name = "feedback";
            this.feedback.Size = new System.Drawing.Size(400, 255);
            this.feedback.TabIndex = 2;
            this.feedback.Text = "Feedback";
            this.feedback.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.feedback.UseVisualStyleBackColor = false;
            this.feedback.Click += new System.EventHandler(this.button3_Click);
            // 
            // studentProgression
            // 
            this.studentProgression.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studentProgression.BackColor = System.Drawing.Color.Transparent;
            this.studentProgression.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("studentProgression.BackgroundImage")));
            this.studentProgression.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.studentProgression.ForeColor = System.Drawing.Color.White;
            this.studentProgression.Location = new System.Drawing.Point(116, 58);
            this.studentProgression.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentProgression.Name = "studentProgression";
            this.studentProgression.Size = new System.Drawing.Size(400, 255);
            this.studentProgression.TabIndex = 3;
            this.studentProgression.Text = "Student Progression";
            this.studentProgression.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.studentProgression.UseVisualStyleBackColor = false;
            this.studentProgression.Click += new System.EventHandler(this.button4_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1578, 644);
            this.Controls.Add(this.studentProgression);
            this.Controls.Add(this.feedback);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.userDetails);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Reports";
            this.Text = "Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reports_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button userDetails;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button feedback;
        private System.Windows.Forms.Button studentProgression;
    }
}