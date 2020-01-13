namespace Text_Reading_for_Visually_Impaired
{
    partial class second_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(second_Page));
            this.insertTxtLb = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.stopBT = new System.Windows.Forms.PictureBox();
            this.pauseBT = new System.Windows.Forms.PictureBox();
            this.rewindBT = new System.Windows.Forms.PictureBox();
            this.playBT = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.backBt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stopBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rewindBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBT)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // insertTxtLb
            // 
            this.insertTxtLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insertTxtLb.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.insertTxtLb.ForeColor = System.Drawing.Color.Black;
            this.insertTxtLb.Location = new System.Drawing.Point(675, 31);
            this.insertTxtLb.Name = "insertTxtLb";
            this.insertTxtLb.Size = new System.Drawing.Size(250, 100);
            this.insertTxtLb.TabIndex = 9;
            this.insertTxtLb.Text = "insert text";
            this.insertTxtLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.insertTxtLb.ForeColorChanged += new System.EventHandler(this.InsertTxtLb_ForeColorChanged);
            this.insertTxtLb.Click += new System.EventHandler(this.label6_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(3, 15);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1190, 325);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonsPanel.Controls.Add(this.stopBT);
            this.buttonsPanel.Controls.Add(this.pauseBT);
            this.buttonsPanel.Controls.Add(this.rewindBT);
            this.buttonsPanel.Controls.Add(this.playBT);
            this.buttonsPanel.Location = new System.Drawing.Point(365, 460);
            this.buttonsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(867, 185);
            this.buttonsPanel.TabIndex = 31;
            // 
            // stopBT
            // 
            this.stopBT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stopBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopBT.Image = ((System.Drawing.Image)(resources.GetObject("stopBT.Image")));
            this.stopBT.Location = new System.Drawing.Point(689, 41);
            this.stopBT.Margin = new System.Windows.Forms.Padding(4);
            this.stopBT.Name = "stopBT";
            this.stopBT.Size = new System.Drawing.Size(153, 120);
            this.stopBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stopBT.TabIndex = 36;
            this.stopBT.TabStop = false;
            this.stopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // pauseBT
            // 
            this.pauseBT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pauseBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pauseBT.Image = ((System.Drawing.Image)(resources.GetObject("pauseBT.Image")));
            this.pauseBT.Location = new System.Drawing.Point(490, 41);
            this.pauseBT.Margin = new System.Windows.Forms.Padding(4);
            this.pauseBT.Name = "pauseBT";
            this.pauseBT.Size = new System.Drawing.Size(153, 120);
            this.pauseBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pauseBT.TabIndex = 37;
            this.pauseBT.TabStop = false;
            this.pauseBT.Click += new System.EventHandler(this.PauseBT_Click);
            // 
            // rewindBT
            // 
            this.rewindBT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rewindBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rewindBT.Image = ((System.Drawing.Image)(resources.GetObject("rewindBT.Image")));
            this.rewindBT.Location = new System.Drawing.Point(51, 41);
            this.rewindBT.Margin = new System.Windows.Forms.Padding(4);
            this.rewindBT.Name = "rewindBT";
            this.rewindBT.Size = new System.Drawing.Size(153, 120);
            this.rewindBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rewindBT.TabIndex = 38;
            this.rewindBT.TabStop = false;
            this.rewindBT.Click += new System.EventHandler(this.RewindBT_Click);
            // 
            // playBT
            // 
            this.playBT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playBT.Image = ((System.Drawing.Image)(resources.GetObject("playBT.Image")));
            this.playBT.Location = new System.Drawing.Point(270, 41);
            this.playBT.Margin = new System.Windows.Forms.Padding(4);
            this.playBT.Name = "playBT";
            this.playBT.Size = new System.Drawing.Size(153, 120);
            this.playBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playBT.TabIndex = 35;
            this.playBT.TabStop = false;
            this.playBT.Click += new System.EventHandler(this.PlayBT_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.IndianRed;
            this.button5.Location = new System.Drawing.Point(1385, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(194, 112);
            this.button5.TabIndex = 34;
            this.button5.Text = "famous stories";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click_1);
            // 
            // backBt
            // 
            this.backBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backBt.BackColor = System.Drawing.Color.RoyalBlue;
            this.backBt.Location = new System.Drawing.Point(1371, 501);
            this.backBt.Margin = new System.Windows.Forms.Padding(4);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(194, 122);
            this.backBt.TabIndex = 35;
            this.backBt.Text = "back";
            this.backBt.UseVisualStyleBackColor = false;
            this.backBt.Click += new System.EventHandler(this.Button6_Click_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(188, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 350);
            this.panel1.TabIndex = 36;
            // 
            // second_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1578, 644);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.insertTxtLb);
            this.Name = "second_Page";
            this.Text = "second_Page";
            this.Load += new System.EventHandler(this.second_Page_Load);
            this.ResizeEnd += new System.EventHandler(this.second_Page_ResizeEnd);
            this.BackColorChanged += new System.EventHandler(this.Second_Page_BackColorChanged);
            this.Resize += new System.EventHandler(this.second_Page_Resize);
            this.Controls.SetChildIndex(this.insertTxtLb, 0);
            this.Controls.SetChildIndex(this.buttonsPanel, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            this.Controls.SetChildIndex(this.backBt, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.buttonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stopBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rewindBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.Label insertTxtLb;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.PictureBox playBT;
        private System.Windows.Forms.PictureBox stopBT;
        private System.Windows.Forms.PictureBox pauseBT;
        private System.Windows.Forms.PictureBox rewindBT;
        private System.Windows.Forms.Button backBt;
        private System.Windows.Forms.Panel panel1;
    }
}