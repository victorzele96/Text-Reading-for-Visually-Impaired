namespace Text_Reading_for_Visually_Impaired
{
    partial class questioPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ans1RB = new System.Windows.Forms.RadioButton();
            this.ans2RB = new System.Windows.Forms.RadioButton();
            this.ans3RB = new System.Windows.Forms.RadioButton();
            this.ans4RB = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(728, 70);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ans1RB
            // 
            this.ans1RB.AutoSize = true;
            this.ans1RB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ans1RB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ans1RB.Location = new System.Drawing.Point(188, 97);
            this.ans1RB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ans1RB.Name = "ans1RB";
            this.ans1RB.Size = new System.Drawing.Size(151, 29);
            this.ans1RB.TabIndex = 1;
            this.ans1RB.TabStop = true;
            this.ans1RB.Text = "radioButton1";
            this.ans1RB.UseVisualStyleBackColor = true;
            this.ans1RB.CheckedChanged += new System.EventHandler(this.ans2RB_CheckedChanged);
            // 
            // ans2RB
            // 
            this.ans2RB.AutoSize = true;
            this.ans2RB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ans2RB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ans2RB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ans2RB.Location = new System.Drawing.Point(507, 97);
            this.ans2RB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ans2RB.Name = "ans2RB";
            this.ans2RB.Size = new System.Drawing.Size(151, 29);
            this.ans2RB.TabIndex = 2;
            this.ans2RB.TabStop = true;
            this.ans2RB.Text = "radioButton2";
            this.ans2RB.UseVisualStyleBackColor = true;
            this.ans2RB.CheckedChanged += new System.EventHandler(this.ans2RB_CheckedChanged);
            // 
            // ans3RB
            // 
            this.ans3RB.AutoSize = true;
            this.ans3RB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ans3RB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ans3RB.Location = new System.Drawing.Point(507, 139);
            this.ans3RB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ans3RB.Name = "ans3RB";
            this.ans3RB.Size = new System.Drawing.Size(151, 29);
            this.ans3RB.TabIndex = 3;
            this.ans3RB.TabStop = true;
            this.ans3RB.Text = "radioButton3";
            this.ans3RB.UseVisualStyleBackColor = true;
            this.ans3RB.CheckedChanged += new System.EventHandler(this.ans2RB_CheckedChanged);
            // 
            // ans4RB
            // 
            this.ans4RB.AutoSize = true;
            this.ans4RB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ans4RB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ans4RB.Location = new System.Drawing.Point(188, 139);
            this.ans4RB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ans4RB.Name = "ans4RB";
            this.ans4RB.Size = new System.Drawing.Size(151, 29);
            this.ans4RB.TabIndex = 4;
            this.ans4RB.TabStop = true;
            this.ans4RB.Text = "radioButton4";
            this.ans4RB.UseVisualStyleBackColor = true;
            this.ans4RB.CheckedChanged += new System.EventHandler(this.ans2RB_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ans3RB);
            this.panel1.Controls.Add(this.ans4RB);
            this.panel1.Controls.Add(this.ans1RB);
            this.panel1.Controls.Add(this.ans2RB);
            this.panel1.Location = new System.Drawing.Point(10, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 176);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(7, 108);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 57);
            this.button1.TabIndex = 5;
            this.button1.Text = "read me";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // questioPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "questioPanel";
            this.Size = new System.Drawing.Size(750, 198);
            this.Load += new System.EventHandler(this.questioPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton ans1RB;
        private System.Windows.Forms.RadioButton ans2RB;
        private System.Windows.Forms.RadioButton ans3RB;
        private System.Windows.Forms.RadioButton ans4RB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}
