namespace RS2015_CheckinSystem
{
    partial class FrmManager
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
            this.dgvManager = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMovie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.function = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btmDelete = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.movieDataSet = new RS2015_CheckinSystem.MovieDataSet();
            this.recordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recordTableAdapter = new RS2015_CheckinSystem.MovieDataSetTableAdapters.RecordTableAdapter();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movie_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movie_Director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Released = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).BeginInit();
            this.function.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvManager
            // 
            this.dgvManager.AutoGenerateColumns = false;
            this.dgvManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Movie_Name,
            this.Movie_Director,
            this.Date_Released});
            this.dgvManager.DataSource = this.recordBindingSource;
            this.dgvManager.Location = new System.Drawing.Point(34, 37);
            this.dgvManager.Name = "dgvManager";
            this.dgvManager.RowTemplate.Height = 24;
            this.dgvManager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManager.Size = new System.Drawing.Size(444, 144);
            this.dgvManager.TabIndex = 0;
            this.dgvManager.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManager_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Management interface";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Movie Name";
            // 
            // txtMovie
            // 
            this.txtMovie.Location = new System.Drawing.Point(102, 198);
            this.txtMovie.Name = "txtMovie";
            this.txtMovie.Size = new System.Drawing.Size(100, 22);
            this.txtMovie.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Director";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Release Date";
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(102, 230);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(100, 22);
            this.txtDirector.TabIndex = 6;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(102, 262);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 22);
            this.txtDate.TabIndex = 7;
            // 
            // function
            // 
            this.function.Controls.Add(this.btnSave);
            this.function.Controls.Add(this.btnAdd);
            this.function.Controls.Add(this.btmDelete);
            this.function.Controls.Add(this.btnView);
            this.function.Location = new System.Drawing.Point(225, 197);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(205, 87);
            this.function.TabIndex = 8;
            this.function.TabStop = false;
            this.function.Text = "function";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(112, 51);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btmDelete
            // 
            this.btmDelete.Location = new System.Drawing.Point(112, 22);
            this.btmDelete.Name = "btmDelete";
            this.btmDelete.Size = new System.Drawing.Size(75, 23);
            this.btmDelete.TabIndex = 1;
            this.btmDelete.Text = "Delete";
            this.btmDelete.UseVisualStyleBackColor = true;
            this.btmDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(16, 22);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // movieDataSet
            // 
            this.movieDataSet.DataSetName = "MovieDataSet";
            this.movieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recordBindingSource
            // 
            this.recordBindingSource.DataMember = "Record";
            this.recordBindingSource.DataSource = this.movieDataSet;
            // 
            // recordTableAdapter
            // 
            this.recordTableAdapter.ClearBeforeFill = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "編號";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Movie_Name
            // 
            this.Movie_Name.DataPropertyName = "Movie_Name";
            this.Movie_Name.HeaderText = "電影名稱";
            this.Movie_Name.Name = "Movie_Name";
            // 
            // Movie_Director
            // 
            this.Movie_Director.DataPropertyName = "Movie_Director";
            this.Movie_Director.HeaderText = "導演";
            this.Movie_Director.Name = "Movie_Director";
            // 
            // Date_Released
            // 
            this.Date_Released.DataPropertyName = "Date_Released";
            this.Date_Released.HeaderText = "發行日期";
            this.Date_Released.Name = "Date_Released";
            // 
            // FrmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 308);
            this.Controls.Add(this.function);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMovie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvManager);
            this.Name = "FrmManager";
            this.Text = "Management Interface";
            this.Load += new System.EventHandler(this.FrmManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).EndInit();
            this.function.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.movieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMovie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.GroupBox function;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btmDelete;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieDirectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReleasedDataGridViewTextBoxColumn;
        private MovieDataSet movieDataSet;
        private System.Windows.Forms.BindingSource recordBindingSource;
        private MovieDataSetTableAdapters.RecordTableAdapter recordTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movie_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movie_Director;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Released;
    }
}