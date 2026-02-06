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
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            cmbGenre = new ComboBox();
            numRating = new NumericUpDown();
            txtDesc = new TextBox();
            btnUploadCover = new Button();
            lblCover = new Label();
            btnOk = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numRating).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(21, 25);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 0;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(163, 24);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(125, 27);
            txtAuthor.TabIndex = 1;
            // 
            // cmbGenre
            // 
            cmbGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Location = new Point(12, 410);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(151, 28);
            cmbGenre.TabIndex = 2;
            // 
            // numRating
            // 
            numRating.Location = new Point(319, 25);
            numRating.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numRating.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numRating.Name = "numRating";
            numRating.Size = new Size(150, 27);
            numRating.TabIndex = 3;
            numRating.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(319, 79);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(231, 111);
            txtDesc.TabIndex = 4;
            // 
            // btnUploadCover
            // 
            btnUploadCover.Location = new Point(13, 330);
            btnUploadCover.Name = "btnUploadCover";
            btnUploadCover.Size = new Size(150, 29);
            btnUploadCover.TabIndex = 5;
            btnUploadCover.Text = "Загрузить обложку";
            btnUploadCover.UseVisualStyleBackColor = true;
            // 
            // lblCover
            // 
            lblCover.AutoSize = true;
            lblCover.Location = new Point(21, 79);
            lblCover.Name = "lblCover";
            lblCover.Size = new Size(50, 20);
            lblCover.TabIndex = 6;
            lblCover.Text = "label1";
            // 
            // btnOk
            // 
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(319, 409);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 7;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(439, 410);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Выйти";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(lblCover);
            Controls.Add(btnUploadCover);
            Controls.Add(txtDesc);
            Controls.Add(numRating);
            Controls.Add(cmbGenre);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Name = "AddEditForm";
            Text = "AddEditForm";
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
    }
}