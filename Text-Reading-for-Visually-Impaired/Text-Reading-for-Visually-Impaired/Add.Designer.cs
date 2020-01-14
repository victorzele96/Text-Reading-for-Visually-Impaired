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
            this.backBTN = new System.Windows.Forms.Button();
            this.BrowseSTR = new System.Windows.Forms.Button();
            this.story_nameTB = new System.Windows.Forms.TextBox();
            this.story_nameLBL = new System.Windows.Forms.Label();
            this.Save_Story = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Add_questionBTN = new System.Windows.Forms.Button();
            this.StoryRTB = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBTN
            // 
            this.backBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.backBTN.Location = new System.Drawing.Point(1367, 542);
            this.backBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(196, 85);
            this.backBTN.TabIndex = 0;
            this.backBTN.Text = "Back";
            this.backBTN.UseVisualStyleBackColor = true;
            this.backBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // BrowseSTR
            // 
            this.BrowseSTR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BrowseSTR.BackColor = System.Drawing.SystemColors.Control;
            this.BrowseSTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseSTR.ForeColor = System.Drawing.Color.Black;
            this.BrowseSTR.Location = new System.Drawing.Point(857, 510);
            this.BrowseSTR.Name = "BrowseSTR";
            this.BrowseSTR.Size = new System.Drawing.Size(196, 85);
            this.BrowseSTR.TabIndex = 1;
            this.BrowseSTR.Text = "Browse";
            this.BrowseSTR.UseVisualStyleBackColor = false;
            this.BrowseSTR.Click += new System.EventHandler(this.button2_Click);
            // 
            // story_nameTB
            // 
            this.story_nameTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.story_nameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.story_nameTB.Location = new System.Drawing.Point(842, 65);
            this.story_nameTB.Name = "story_nameTB";
            this.story_nameTB.Size = new System.Drawing.Size(309, 35);
            this.story_nameTB.TabIndex = 2;
            // 
            // story_nameLBL
            // 
            this.story_nameLBL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.story_nameLBL.AutoSize = true;
            this.story_nameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.story_nameLBL.Location = new System.Drawing.Point(503, 54);
            this.story_nameLBL.Name = "story_nameLBL";
            this.story_nameLBL.Size = new System.Drawing.Size(290, 53);
            this.story_nameLBL.TabIndex = 3;
            this.story_nameLBL.Text = "Story Name:";
            // 
            // Save_Story
            // 
            this.Save_Story.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Save_Story.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Story.Location = new System.Drawing.Point(512, 510);
            this.Save_Story.Name = "Save_Story";
            this.Save_Story.Size = new System.Drawing.Size(196, 85);
            this.Save_Story.TabIndex = 4;
            this.Save_Story.Text = "Save Story";
            this.Save_Story.UseVisualStyleBackColor = true;
            this.Save_Story.Click += new System.EventHandler(this.ok_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Add_questionBTN);
            this.panel1.Controls.Add(this.StoryRTB);
            this.panel1.Controls.Add(this.story_nameTB);
            this.panel1.Controls.Add(this.story_nameLBL);
            this.panel1.Controls.Add(this.Save_Story);
            this.panel1.Controls.Add(this.backBTN);
            this.panel1.Controls.Add(this.BrowseSTR);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1573, 639);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Add_questionBTN
            // 
            this.Add_questionBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_questionBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_questionBTN.Location = new System.Drawing.Point(1367, 22);
            this.Add_questionBTN.Name = "Add_questionBTN";
            this.Add_questionBTN.Size = new System.Drawing.Size(196, 85);
            this.Add_questionBTN.TabIndex = 6;
            this.Add_questionBTN.Text = "Add Questions";
            this.Add_questionBTN.UseVisualStyleBackColor = true;
            this.Add_questionBTN.Click += new System.EventHandler(this.Add_questionBTN_Click);
            // 
            // StoryRTB
            // 
            this.StoryRTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StoryRTB.Location = new System.Drawing.Point(512, 185);
            this.StoryRTB.Name = "StoryRTB";
            this.StoryRTB.Size = new System.Drawing.Size(541, 247);
            this.StoryRTB.TabIndex = 5;
            this.StoryRTB.Text = "";
            this.StoryRTB.TextChanged += new System.EventHandler(this.UpdatesRTB_TextChanged);
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

        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Button BrowseSTR;
        private System.Windows.Forms.TextBox story_nameTB;
        private System.Windows.Forms.Label story_nameLBL;
        private System.Windows.Forms.Button Save_Story;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox StoryRTB;
        private System.Windows.Forms.Button Add_questionBTN;
    }
}