namespace Text_Reading_for_Visually_Impaired
{
    partial class Teacher_Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher_Reports));
            this.button1 = new System.Windows.Forms.Button();
            this.studentProgression = new System.Windows.Forms.Button();
            this.Updates = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(1360, 527);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 82);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // studentProgression
            // 
            this.studentProgression.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studentProgression.BackColor = System.Drawing.Color.Transparent;
            this.studentProgression.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("studentProgression.BackgroundImage")));
            this.studentProgression.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.studentProgression.ForeColor = System.Drawing.Color.White;
            this.studentProgression.Location = new System.Drawing.Point(287, 66);
            this.studentProgression.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentProgression.Name = "studentProgression";
            this.studentProgression.Size = new System.Drawing.Size(400, 255);
            this.studentProgression.TabIndex = 4;
            this.studentProgression.Text = "Student Progression";
            this.studentProgression.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.studentProgression.UseVisualStyleBackColor = false;
            this.studentProgression.Click += new System.EventHandler(this.button4_Click);
            // 
            // Updates
            // 
            this.Updates.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Updates.BackColor = System.Drawing.Color.Transparent;
            this.Updates.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Updates.BackgroundImage")));
            this.Updates.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Updates.ForeColor = System.Drawing.Color.White;
            this.Updates.Location = new System.Drawing.Point(818, 66);
            this.Updates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Updates.Name = "Updates";
            this.Updates.Size = new System.Drawing.Size(400, 255);
            this.Updates.TabIndex = 5;
            this.Updates.Text = "Updates";
            this.Updates.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Updates.UseVisualStyleBackColor = false;
            // 
            // Teacher_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1578, 644);
            this.Controls.Add(this.Updates);
            this.Controls.Add(this.studentProgression);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Teacher_Reports";
            this.Text = "Teacher_Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button studentProgression;
        private System.Windows.Forms.Button Updates;
    }
}