﻿namespace Text_Reading_for_Visually_Impaired
{
    partial class myCheckBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.RB1 = new System.Windows.Forms.RadioButton();
            this.requestsTableAdapter1 = new Text_Reading_for_Visually_Impaired.Database11DataSet4TableAdapters.RequestsTableAdapter();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 39);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.BackColorChanged += new System.EventHandler(this.label1_BackColorChanged);
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RB1
            // 
            this.RB1.AutoSize = true;
            this.RB1.Dock = System.Windows.Forms.DockStyle.Left;
            this.RB1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RB1.Location = new System.Drawing.Point(0, 0);
            this.RB1.Margin = new System.Windows.Forms.Padding(2);
            this.RB1.Name = "RB1";
            this.RB1.Size = new System.Drawing.Size(24, 39);
            this.RB1.TabIndex = 2;
            this.RB1.TabStop = true;
            this.RB1.UseVisualStyleBackColor = true;
            this.RB1.CheckedChanged += new System.EventHandler(this.RB1_CheckedChanged);
            this.RB1.Click += new System.EventHandler(this.RB1_Click);
            // 
            // requestsTableAdapter1
            // 
            this.requestsTableAdapter1.ClearBeforeFill = true;
            // 
            // myCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.Controls.Add(this.RB1);
            this.Controls.Add(this.label1);
            this.Name = "myCheckBox";
            this.Size = new System.Drawing.Size(252, 39);
            this.Load += new System.EventHandler(this.myCheckBox_Load);
            this.BackColorChanged += new System.EventHandler(this.myCheckBox_BackColorChanged);
            this.FontChanged += new System.EventHandler(this.myCheckBox_FontChanged);
            this.ForeColorChanged += new System.EventHandler(this.myCheckBox_ForeColorChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Database11DataSet4TableAdapters.RequestsTableAdapter requestsTableAdapter1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton RB1;
    }
}
