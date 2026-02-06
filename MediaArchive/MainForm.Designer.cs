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
            Name = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            pbCover = new PictureBox();
            lblTitleInfo = new Label();
            lblGenreInfo = new Label();
            lblRatingInfo = new Label();
            rtbDescription = new RichTextBox();
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
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, Author, Year });
            dataGridView1.Location = new Point(14, 61);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(419, 415);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Name
            // 
            Name.HeaderText = "Название";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.ReadOnly = true;
            Name.Width = 125;
            // 
            // Author
            // 
            Author.HeaderText = "Автор/Режиссер";
            Author.MinimumWidth = 6;
            Author.Name = "Author";
            Author.ReadOnly = true;
            Author.Width = 125;
            // 
            // Year
            // 
            Year.HeaderText = "Год";
            Year.MinimumWidth = 6;
            Year.Name = "Year";
            Year.ReadOnly = true;
            Year.Width = 125;
            // 
            // panel1
            // 
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
            // lblTitleInfo
            // 
            lblTitleInfo.AutoSize = true;
            lblTitleInfo.Location = new Point(37, 237);
            lblTitleInfo.Name = "lblTitleInfo";
            lblTitleInfo.Size = new Size(38, 20);
            lblTitleInfo.TabIndex = 1;
            lblTitleInfo.Text = "Title";
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
            // lblRatingInfo
            // 
            lblRatingInfo.AutoSize = true;
            lblRatingInfo.Location = new Point(185, 237);
            lblRatingInfo.Name = "lblRatingInfo";
            lblRatingInfo.Size = new Size(52, 20);
            lblRatingInfo.TabIndex = 3;
            lblRatingInfo.Text = "Rating";
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
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 516);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(218, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Добавить новый объект";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(12, 571);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(218, 29);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Редактировать выбранный";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(253, 571);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(253, 516);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(180, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "Сохранить базу в JSON";
            btnSave.UseVisualStyleBackColor = true;
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
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Year;
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
