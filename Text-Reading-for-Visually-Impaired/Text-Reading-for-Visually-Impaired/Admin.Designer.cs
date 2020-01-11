namespace Text_Reading_for_Visually_Impaired
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.reports = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.requests = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reports
            // 
            this.reports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reports.BackColor = System.Drawing.Color.Transparent;
            this.reports.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reports.BackgroundImage")));
            this.reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.reports.ForeColor = System.Drawing.Color.White;
            this.reports.Location = new System.Drawing.Point(179, 21);
            this.reports.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(400, 255);
            this.reports.TabIndex = 0;
            this.reports.Text = "Reports";
            this.reports.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.reports.UseVisualStyleBackColor = false;
            this.reports.Click += new System.EventHandler(this.button1_Click);
            // 
            // logout
            // 
            this.logout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logout.BackgroundImage")));
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(1081, 367);
            this.logout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(400, 255);
            this.logout.TabIndex = 1;
            this.logout.Text = "Logout";
            this.logout.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.button2_Click);
            // 
            // requests
            // 
            this.requests.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.requests.BackColor = System.Drawing.Color.Transparent;
            this.requests.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("requests.BackgroundImage")));
            this.requests.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.requests.ForeColor = System.Drawing.Color.White;
            this.requests.Location = new System.Drawing.Point(179, 367);
            this.requests.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.requests.Name = "requests";
            this.requests.Size = new System.Drawing.Size(400, 255);
            this.requests.TabIndex = 2;
            this.requests.Text = "Requests";
            this.requests.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.requests.UseVisualStyleBackColor = false;
            this.requests.Click += new System.EventHandler(this.button3_Click);
            // 
            // add
            // 
            this.add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add.BackgroundImage")));
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(626, 21);
            this.add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(400, 255);
            this.add.TabIndex = 3;
            this.add.Text = "Add";
            this.add.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.button4_Click);
            // 
            // remove
            // 
            this.remove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.remove.BackColor = System.Drawing.Color.Black;
            this.remove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("remove.BackgroundImage")));
            this.remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.remove.ForeColor = System.Drawing.SystemColors.Control;
            this.remove.Location = new System.Drawing.Point(626, 367);
            this.remove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(400, 255);
            this.remove.TabIndex = 4;
            this.remove.Text = "Remove";
            this.remove.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.button5_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1578, 644);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.add);
            this.Controls.Add(this.requests);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.reports);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Admin";
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reports;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button requests;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button remove;
    }
}