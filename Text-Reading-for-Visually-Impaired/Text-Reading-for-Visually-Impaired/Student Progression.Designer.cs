namespace Text_Reading_for_Visually_Impaired
{
    partial class Student_Progression
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.profileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database11DataSet6 = new Text_Reading_for_Visually_Impaired.Database11DataSet6();
            this.button1 = new System.Windows.Forms.Button();
            this.profileTableAdapter = new Text_Reading_for_Visually_Impaired.Database11DataSet6TableAdapters.ProfileTableAdapter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Clear = new System.Windows.Forms.Button();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightansweredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qansweredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Upload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.teacherIDDataGridViewTextBoxColumn,
            this.rightansweredDataGridViewTextBoxColumn,
            this.qansweredDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.profileBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(862, 380);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // profileBindingSource
            // 
            this.profileBindingSource.DataMember = "Profile";
            this.profileBindingSource.DataSource = this.database11DataSet6;
            // 
            // database11DataSet6
            // 
            this.database11DataSet6.DataSetName = "Database11DataSet6";
            this.database11DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(1322, 571);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // profileTableAdapter
            // 
            this.profileTableAdapter.ClearBeforeFill = true;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(923, 70);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Right_Answered";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Q_answered";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(588, 386);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Clear.Location = new System.Drawing.Point(688, 470);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(210, 59);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Save_Click);
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // teacherIDDataGridViewTextBoxColumn
            // 
            this.teacherIDDataGridViewTextBoxColumn.DataPropertyName = "TeacherID";
            this.teacherIDDataGridViewTextBoxColumn.HeaderText = "TeacherID";
            this.teacherIDDataGridViewTextBoxColumn.Name = "teacherIDDataGridViewTextBoxColumn";
            // 
            // rightansweredDataGridViewTextBoxColumn
            // 
            this.rightansweredDataGridViewTextBoxColumn.DataPropertyName = "Right_answered";
            this.rightansweredDataGridViewTextBoxColumn.HeaderText = "Right_answered";
            this.rightansweredDataGridViewTextBoxColumn.Name = "rightansweredDataGridViewTextBoxColumn";
            // 
            // qansweredDataGridViewTextBoxColumn
            // 
            this.qansweredDataGridViewTextBoxColumn.DataPropertyName = "Q_answered";
            this.qansweredDataGridViewTextBoxColumn.HeaderText = "Q_answered";
            this.qansweredDataGridViewTextBoxColumn.Name = "qansweredDataGridViewTextBoxColumn";
            // 
            // Upload
            // 
            this.Upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Upload.Location = new System.Drawing.Point(1301, 470);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(210, 59);
            this.Upload.TabIndex = 4;
            this.Upload.Text = "show all";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // Student_Progression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 653);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Student_Progression";
            this.Text = "Student_Progression";
            this.Load += new System.EventHandler(this.Student_Progression_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private Database11DataSet6 database11DataSet6;
        private System.Windows.Forms.BindingSource profileBindingSource;
        private Database11DataSet6TableAdapters.ProfileTableAdapter profileTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rightansweredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qansweredDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Upload;
    }
}