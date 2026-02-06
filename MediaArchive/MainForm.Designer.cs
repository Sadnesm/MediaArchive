namespace MediaArchive
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSearch = new TextBox();
            cmbGenreFilter = new ComboBox();
            dataGridView1 = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colAuthor = new DataGridViewTextBoxColumn();
            colYear = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            rtbDescription = new RichTextBox();
            lblRatingInfo = new Label();
            lblGenreInfo = new Label();
            lblTitleInfo = new Label();
            pbCover = new PictureBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCover).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Поиск по названию...";
            txtSearch.Size = new Size(176, 27);
            txtSearch.TabIndex = 0;
            // 
            // cmbGenreFilter
            // 
            cmbGenreFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenreFilter.FormattingEnabled = true;
            cmbGenreFilter.Items.AddRange(new object[] { "Все", "Фильм", "Книга", "Игра" });
            cmbGenreFilter.Location = new Point(207, 11);
            cmbGenreFilter.Name = "cmbGenreFilter";
            cmbGenreFilter.Size = new Size(151, 28);
            cmbGenreFilter.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colName, colAuthor, colYear });
            dataGridView1.Location = new Point(14, 61);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(426, 415);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colName
            // 
            colName.HeaderText = "Название";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 125;
            // 
            // colAuthor
            // 
            colAuthor.HeaderText = "Автор/Режиссер";
            colAuthor.MinimumWidth = 6;
            colAuthor.Name = "colAuthor";
            colAuthor.ReadOnly = true;
            colAuthor.Width = 125;
            // 
            // colYear
            // 
            colYear.HeaderText = "Год";
            colYear.MinimumWidth = 6;
            colYear.Name = "colYear";
            colYear.ReadOnly = true;
            colYear.Width = 125;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Controls.Add(rtbDescription);
            panel1.Controls.Add(lblRatingInfo);
            panel1.Controls.Add(lblGenreInfo);
            panel1.Controls.Add(lblTitleInfo);
            panel1.Controls.Add(pbCover);
            panel1.Location = new Point(512, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 415);
            panel1.TabIndex = 3;
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(37, 298);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.ReadOnly = true;
            rtbDescription.Size = new Size(200, 104);
            rtbDescription.TabIndex = 4;
            rtbDescription.Text = "";
            // 
            // lblRatingInfo
            // 
            lblRatingInfo.AutoSize = true;
            lblRatingInfo.Location = new Point(185, 237);
            lblRatingInfo.Name = "lblRatingInfo";
            lblRatingInfo.Size = new Size(52, 20);
            lblRatingInfo.TabIndex = 3;
            lblRatingInfo.Text = "Rating";
            // 
            // lblGenreInfo
            // 
            lblGenreInfo.AutoSize = true;
            lblGenreInfo.Location = new Point(37, 266);
            lblGenreInfo.Name = "lblGenreInfo";
            lblGenreInfo.Size = new Size(48, 20);
            lblGenreInfo.TabIndex = 2;
            lblGenreInfo.Text = "Genre";
            lblGenreInfo.Click += label1_Click;
            // 
            // lblTitleInfo
            // 
            lblTitleInfo.AutoSize = true;
            lblTitleInfo.Location = new Point(37, 237);
            lblTitleInfo.Name = "lblTitleInfo";
            lblTitleInfo.Size = new Size(38, 20);
            lblTitleInfo.TabIndex = 1;
            lblTitleInfo.Text = "Title";
            // 
            // pbCover
            // 
            pbCover.BorderStyle = BorderStyle.FixedSingle;
            pbCover.Location = new Point(37, 20);
            pbCover.Name = "pbCover";
            pbCover.Size = new Size(200, 200);
            pbCover.SizeMode = PictureBoxSizeMode.Zoom;
            pbCover.TabIndex = 0;
            pbCover.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 516);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(218, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Добавить новый объект";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(12, 571);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(218, 29);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Редактировать выбранный";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(253, 571);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(253, 516);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(180, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "Сохранить базу в JSON";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 789);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(cmbGenreFilter);
            Controls.Add(txtSearch);
            DoubleBuffered = true;
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private ComboBox cmbGenreFilter;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colAuthor;
        private DataGridViewTextBoxColumn colYear;
        private Panel panel1;
        private PictureBox pbCover;
        private Label lblTitleInfo;
        private Label lblRatingInfo;
        private Label lblGenreInfo;
        private RichTextBox rtbDescription;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSave;
    }
}
