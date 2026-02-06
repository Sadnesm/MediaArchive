namespace MediaArchive
{
    partial class AddEditForm
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
            numYear = new NumericUpDown();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            cmbGenre = new ComboBox();
            numRating = new NumericUpDown();
            txtDesc = new TextBox();
            btnUploadCover = new Button();
            lblCover = new Label();
            btnOk = new Button();
            btnCancel = new Button();
            lblTitle = new Label();
            lblAuthor = new Label();
            lblRating = new Label();
            lblGenre = new Label();
            lblYear = new Label();
            lblDesc = new Label();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRating).BeginInit();
            SuspendLayout();
            // 
            // numYear
            // 
            numYear.Location = new Point(187, 113);
            numYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numYear.Minimum = new decimal(new int[] { 1800, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(150, 27);
            numYear.TabIndex = 9;
            numYear.Value = new decimal(new int[] { 1800, 0, 0, 0 });
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(21, 38);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 0;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(166, 38);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(125, 27);
            txtAuthor.TabIndex = 1;
            // 
            // cmbGenre
            // 
            cmbGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Location = new Point(21, 112);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(151, 28);
            cmbGenre.TabIndex = 2;
            // 
            // numRating
            // 
            numRating.Location = new Point(319, 39);
            numRating.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numRating.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numRating.Name = "numRating";
            numRating.Size = new Size(150, 27);
            numRating.TabIndex = 3;
            numRating.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(21, 191);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(231, 111);
            txtDesc.TabIndex = 4;
            // 
            // btnUploadCover
            // 
            btnUploadCover.Location = new Point(638, 57);
            btnUploadCover.Name = "btnUploadCover";
            btnUploadCover.Size = new Size(150, 29);
            btnUploadCover.TabIndex = 5;
            btnUploadCover.Text = "Загрузить обложку";
            btnUploadCover.UseVisualStyleBackColor = true;
            btnUploadCover.Click += btnUploadCover_Click;
            // 
            // lblCover
            // 
            lblCover.AutoSize = true;
            lblCover.Location = new Point(638, 120);
            lblCover.Name = "lblCover";
            lblCover.Size = new Size(50, 20);
            lblCover.TabIndex = 6;
            lblCover.Text = "label1";
            // 
            // btnOk
            // 
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(21, 410);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 7;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(121, 410);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Выйти";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(23, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(77, 20);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Название";
            lblTitle.Click += label1_Click;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(171, 13);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(51, 20);
            lblAuthor.TabIndex = 11;
            lblAuthor.Text = "Автор";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Location = new Point(319, 12);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(64, 20);
            lblRating.TabIndex = 12;
            lblRating.Text = "Рейтинг";
            lblRating.Click += label3_Click;
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(23, 85);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(48, 20);
            lblGenre.TabIndex = 13;
            lblGenre.Text = "Жанр";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(190, 85);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(33, 20);
            lblYear.TabIndex = 14;
            lblYear.Text = "Год";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(21, 168);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(79, 20);
            lblDesc.TabIndex = 15;
            lblDesc.Text = "Описание";
            // 
            // AddEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDesc);
            Controls.Add(lblYear);
            Controls.Add(lblGenre);
            Controls.Add(lblRating);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Controls.Add(numYear);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(lblCover);
            Controls.Add(btnUploadCover);
            Controls.Add(txtDesc);
            Controls.Add(numRating);
            Controls.Add(cmbGenre);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            DoubleBuffered = true;
            Name = "AddEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddEditForm";
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtAuthor;
        private ComboBox cmbGenre;
        private NumericUpDown numRating;
        private TextBox txtDesc;
        private Button btnUploadCover;
        private Label lblCover;
        private Button btnOk;
        private Button btnCancel;
        private NumericUpDown numYear;
        private Label lblTitle;
        private Label lblAuthor;
        private Label lblRating;
        private Label lblGenre;
        private Label lblYear;
        private Label lblDesc;
    }
}