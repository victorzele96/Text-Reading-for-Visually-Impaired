namespace Text_Reading_for_Visually_Impaired
{
    partial class Test
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelDropDown = new System.Windows.Forms.Panel();
            this.minusPicture = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.plusPicture = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelDropDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minusPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelDropDown
            // 
            this.panelDropDown.Controls.Add(this.minusPicture);
            this.panelDropDown.Controls.Add(this.button4);
            this.panelDropDown.Controls.Add(this.plusPicture);
            this.panelDropDown.Controls.Add(this.button3);
            this.panelDropDown.Controls.Add(this.pictureBox1);
            this.panelDropDown.Controls.Add(this.button1);
            this.panelDropDown.Controls.Add(this.button2);
            this.panelDropDown.Location = new System.Drawing.Point(12, 12);
            this.panelDropDown.MaximumSize = new System.Drawing.Size(171, 378);
            this.panelDropDown.MinimumSize = new System.Drawing.Size(171, 131);
            this.panelDropDown.Name = "panelDropDown";
            this.panelDropDown.Size = new System.Drawing.Size(171, 131);
            this.panelDropDown.TabIndex = 0;
            // 
            // minusPicture
            // 
            this.minusPicture.BackColor = System.Drawing.Color.White;
            this.minusPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minusPicture.Image = ((System.Drawing.Image)(resources.GetObject("minusPicture.Image")));
            this.minusPicture.Location = new System.Drawing.Point(87, 130);
            this.minusPicture.Name = "minusPicture";
            this.minusPicture.Size = new System.Drawing.Size(86, 50);
            this.minusPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minusPicture.TabIndex = 2;
            this.minusPicture.TabStop = false;
            this.minusPicture.Click += new System.EventHandler(this.minusPicture_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 329);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 50);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // plusPicture
            // 
            this.plusPicture.BackColor = System.Drawing.Color.White;
            this.plusPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plusPicture.Image = ((System.Drawing.Image)(resources.GetObject("plusPicture.Image")));
            this.plusPicture.Location = new System.Drawing.Point(0, 130);
            this.plusPicture.Name = "plusPicture";
            this.plusPicture.Size = new System.Drawing.Size(86, 50);
            this.plusPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plusPicture.TabIndex = 1;
            this.plusPicture.TabStop = false;
            this.plusPicture.Click += new System.EventHandler(this.plusPicture_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 50);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Test
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1623, 959);
            this.Controls.Add(this.panelDropDown);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Test";
            this.Text = "Test";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Test_Load);
            this.panelDropDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minusPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelDropDown;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox minusPicture;
        private System.Windows.Forms.PictureBox plusPicture;
    }
}