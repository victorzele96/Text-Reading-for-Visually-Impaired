namespace Text_Reading_for_Visually_Impaired
{
    partial class Add
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
            this.bacBTN = new System.Windows.Forms.Button();
            this.Add_storyBTN = new System.Windows.Forms.Button();
            this.story_nameTB = new System.Windows.Forms.TextBox();
            this.story_nameLBL = new System.Windows.Forms.Label();
            this.okBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UpdatesRTB = new System.Windows.Forms.RichTextBox();
            this.Add_questionBTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bacBTN
            // 
            this.bacBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bacBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bacBTN.Location = new System.Drawing.Point(1367, 542);
            this.bacBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bacBTN.Name = "bacBTN";
            this.bacBTN.Size = new System.Drawing.Size(196, 85);
            this.bacBTN.TabIndex = 0;
            this.bacBTN.Text = "Back";
            this.bacBTN.UseVisualStyleBackColor = true;
            this.bacBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_storyBTN
            // 
            this.Add_storyBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add_storyBTN.BackColor = System.Drawing.SystemColors.Control;
            this.Add_storyBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_storyBTN.ForeColor = System.Drawing.Color.Black;
            this.Add_storyBTN.Location = new System.Drawing.Point(893, 429);
            this.Add_storyBTN.Name = "Add_storyBTN";
            this.Add_storyBTN.Size = new System.Drawing.Size(196, 85);
            this.Add_storyBTN.TabIndex = 1;
            this.Add_storyBTN.Text = "Add Story";
            this.Add_storyBTN.UseVisualStyleBackColor = false;
            this.Add_storyBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // story_nameTB
            // 
            this.story_nameTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.story_nameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.story_nameTB.Location = new System.Drawing.Point(764, 65);
            this.story_nameTB.Name = "story_nameTB";
            this.story_nameTB.Size = new System.Drawing.Size(309, 35);
            this.story_nameTB.TabIndex = 2;
            // 
            // story_nameLBL
            // 
            this.story_nameLBL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.story_nameLBL.AutoSize = true;
            this.story_nameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.story_nameLBL.Location = new System.Drawing.Point(425, 54);
            this.story_nameLBL.Name = "story_nameLBL";
            this.story_nameLBL.Size = new System.Drawing.Size(290, 53);
            this.story_nameLBL.TabIndex = 3;
            this.story_nameLBL.Text = "Story Name:";
            // 
            // okBTN
            // 
            this.okBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBTN.Location = new System.Drawing.Point(532, 542);
            this.okBTN.Name = "okBTN";
            this.okBTN.Size = new System.Drawing.Size(196, 85);
            this.okBTN.TabIndex = 4;
            this.okBTN.Text = "OK";
            this.okBTN.UseVisualStyleBackColor = true;
            this.okBTN.Click += new System.EventHandler(this.ok_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Add_questionBTN);
            this.panel1.Controls.Add(this.UpdatesRTB);
            this.panel1.Controls.Add(this.story_nameTB);
            this.panel1.Controls.Add(this.story_nameLBL);
            this.panel1.Controls.Add(this.okBTN);
            this.panel1.Controls.Add(this.bacBTN);
            this.panel1.Controls.Add(this.Add_storyBTN);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1573, 639);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // UpdatesRTB
            // 
            this.UpdatesRTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdatesRTB.Location = new System.Drawing.Point(532, 150);
            this.UpdatesRTB.Name = "UpdatesRTB";
            this.UpdatesRTB.Size = new System.Drawing.Size(541, 247);
            this.UpdatesRTB.TabIndex = 5;
            this.UpdatesRTB.Text = "";
            // 
            // Add_questionBTN
            // 
            this.Add_questionBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add_questionBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_questionBTN.Location = new System.Drawing.Point(893, 542);
            this.Add_questionBTN.Name = "Add_questionBTN";
            this.Add_questionBTN.Size = new System.Drawing.Size(196, 85);
            this.Add_questionBTN.TabIndex = 6;
            this.Add_questionBTN.Text = "Add Questions";
            this.Add_questionBTN.UseVisualStyleBackColor = true;
            this.Add_questionBTN.Click += new System.EventHandler(this.Add_questionBTN_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1578, 644);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Add";
            this.Text = "Add";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Add_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bacBTN;
        private System.Windows.Forms.Button Add_storyBTN;
        private System.Windows.Forms.TextBox story_nameTB;
        private System.Windows.Forms.Label story_nameLBL;
        private System.Windows.Forms.Button okBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox UpdatesRTB;
        private System.Windows.Forms.Button Add_questionBTN;
    }
}