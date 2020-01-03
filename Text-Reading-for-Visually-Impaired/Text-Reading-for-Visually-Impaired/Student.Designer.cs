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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.colorDialog4 = new System.Windows.Forms.ColorDialog();
            this.colorDialog5 = new System.Windows.Forms.ColorDialog();
            this.thems = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button4.Location = new System.Drawing.Point(770, 462);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(363, 87);
            this.button4.TabIndex = 3;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // thems
            // 
            this.thems.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thems.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.thems.IntegralHeight = false;
            this.thems.ItemHeight = 51;
            this.thems.Items.AddRange(new object[] {
            "Default",
            "Black and Yellow",
            "Black and Red",
            "3",
            "4",
            "5"});
            this.thems.Location = new System.Drawing.Point(227, 180);
            this.thems.Name = "thems";
            this.thems.Size = new System.Drawing.Size(363, 59);
            this.thems.TabIndex = 0;
            this.thems.Text = "Pick  Theme";
            this.thems.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button5.Location = new System.Drawing.Point(227, 461);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(363, 87);
            this.button5.TabIndex = 4;
            this.button5.Text = "Choose a story";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button6.Location = new System.Drawing.Point(770, 172);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(363, 87);
            this.button6.TabIndex = 5;
            this.button6.Text = "Update student Information";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1204, 737);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.thems);
            this.Controls.Add(this.button4);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.thems, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            this.Controls.SetChildIndex(this.button6, 0);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ColorDialog colorDialog3;
        private System.Windows.Forms.ColorDialog colorDialog4;
        private System.Windows.Forms.ColorDialog colorDialog5;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.ComboBox thems;
    }
}