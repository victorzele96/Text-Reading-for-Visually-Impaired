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
            this.requestsTableAdapter1 = new Text_Reading_for_Visually_Impaired.Database11DataSet4TableAdapters.RequestsTableAdapter();
            this.requestsTableAdapter2 = new Text_Reading_for_Visually_Impaired.Database11DataSet4TableAdapters.RequestsTableAdapter();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1441, 210);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ans1RB
            // 
            this.ans1RB.AutoSize = true;
            this.ans1RB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ans1RB.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ans1RB.Location = new System.Drawing.Point(328, 240);
            this.ans1RB.Name = "ans1RB";
            this.ans1RB.Size = new System.Drawing.Size(370, 61);
            this.ans1RB.TabIndex = 1;
            this.ans1RB.TabStop = true;
            this.ans1RB.Text = "radioButton1";
            this.ans1RB.UseVisualStyleBackColor = true;
            this.ans1RB.CheckedChanged += new System.EventHandler(this.ans1RB_CheckedChanged);
            // 
            // ans2RB
            // 
            this.ans2RB.AutoSize = true;
            this.ans2RB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ans2RB.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ans2RB.Location = new System.Drawing.Point(944, 240);
            this.ans2RB.Name = "ans2RB";
            this.ans2RB.Size = new System.Drawing.Size(370, 61);
            this.ans2RB.TabIndex = 2;
            this.ans2RB.TabStop = true;
            this.ans2RB.Text = "radioButton2";
            this.ans2RB.UseVisualStyleBackColor = true;
            this.ans2RB.CheckedChanged += new System.EventHandler(this.ans1RB_CheckedChanged);
            // 
            // ans3RB
            // 
            this.ans3RB.AutoSize = true;
            this.ans3RB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ans3RB.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ans3RB.Location = new System.Drawing.Point(328, 316);
            this.ans3RB.Name = "ans3RB";
            this.ans3RB.Size = new System.Drawing.Size(370, 61);
            this.ans3RB.TabIndex = 3;
            this.ans3RB.TabStop = true;
            this.ans3RB.Text = "radioButton3";
            this.ans3RB.UseVisualStyleBackColor = true;
            this.ans3RB.CheckedChanged += new System.EventHandler(this.ans1RB_CheckedChanged);
            // 
            // ans4RB
            // 
            this.ans4RB.AutoSize = true;
            this.ans4RB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ans4RB.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ans4RB.Location = new System.Drawing.Point(944, 316);
            this.ans4RB.Name = "ans4RB";
            this.ans4RB.Size = new System.Drawing.Size(370, 61);
            this.ans4RB.TabIndex = 4;
            this.ans4RB.TabStop = true;
            this.ans4RB.Text = "radioButton4";
            this.ans4RB.UseVisualStyleBackColor = true;
            this.ans4RB.CheckedChanged += new System.EventHandler(this.ans1RB_CheckedChanged);
            // 
            // requestsTableAdapter1
            // 
            this.requestsTableAdapter1.ClearBeforeFill = true;
            // 
            // requestsTableAdapter2
            // 
            this.requestsTableAdapter2.ClearBeforeFill = true;
            // 
            // questioPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.Controls.Add(this.ans4RB);
            this.Controls.Add(this.ans3RB);
            this.Controls.Add(this.ans2RB);
            this.Controls.Add(this.ans1RB);
            this.Controls.Add(this.label1);
            this.Name = "questioPanel";
            this.Size = new System.Drawing.Size(1444, 404);
            this.Load += new System.EventHandler(this.questioPanel_Load);
            this.SizeChanged += new System.EventHandler(this.questioPanel_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton ans1RB;
        private System.Windows.Forms.RadioButton ans2RB;
        private System.Windows.Forms.RadioButton ans3RB;
        private System.Windows.Forms.RadioButton ans4RB;
        private Database11DataSet4TableAdapters.RequestsTableAdapter requestsTableAdapter1;
        private Database11DataSet4TableAdapters.RequestsTableAdapter requestsTableAdapter2;
    }
}
