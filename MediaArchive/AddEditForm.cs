using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaArchive
{
    public partial class AddEditForm : Form
    {
        public MediaItem Item { get; private set; }

        public AddEditForm()
        {
            InitializeComponent();
            Item = new MediaItem();
            this.Text = "Добавить новый объект";
        }

        public AddEditForm(MediaItem itemToEdit)
        {
            InitializeComponent();
            Item = itemToEdit;
            this.Text = "Редактировать медиа";
            PrepareForm();

            txtTitle.Text = Item.Title;
            txtAuthor.Text = Item.Author;
            numYear.Value = Item.Year;
            cmbGenre.SelectedItem = Item.Genre;
            numRating.Value = Item.Rating;
            txtDesc.Text = Item.Description;
            lblCover.Text = Item.ImagePath;
        }

        private void PrepareForm()
        {
            if (cmbGenre.Items.Count == 0)
                cmbGenre.Items.AddRange(new object[] { "Фильм", "Книга", "Игра", "Сериал", "Другое" });
            if (cmbGenre.SelectedIndex == -1) cmbGenre.SelectedIndex = 0;
        }

        private void btnUploadCover_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Изображения|*.jpg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Item.ImagePath = ofd.FileName;
                    lblCover.Text = ofd.FileName;
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Название обязательно!");
                return;
            }

            Item.Title = txtTitle.Text;
            Item.Author = txtAuthor.Text;
            Item.Year = (int)numYear.Value;
            Item.Genre = cmbGenre.SelectedItem.ToString();
            Item.Rating = (int)numRating.Value;
            Item.Description = txtDesc.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
