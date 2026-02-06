using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MediaArchive
{
    public partial class MainForm : Form
    {
        private LibraryManager manager = new LibraryManager();
        private bool _isUpdating = false;

        public MainForm()
        {
            InitializeComponent();

            manager.Items = StorageService.Load();

            txtSearch.TextChanged += (s, e) => UpdateGrid();
            cmbGenreFilter.SelectedIndexChanged += (s, e) => UpdateGrid();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;

            if (cmbGenreFilter.Items.Count > 0) cmbGenreFilter.SelectedIndex = 0;

            UpdateGrid();
        }

        private void UpdateGrid()
        {
            if (_isUpdating) return;
            _isUpdating = true;

            try
            {
                string search = txtSearch.Text;
                string genre = cmbGenreFilter.SelectedItem?.ToString();

                var items = manager.GetFilteredItems(search, genre);

                dataGridView1.Rows.Clear();
                foreach (var item in items)
                {
                    int rowIndex = dataGridView1.Rows.Add(item.Title, item.Author, item.Year);
                    dataGridView1.Rows[rowIndex].Tag = item;
                }

                if (dataGridView1.Rows.Count > 0)
                    UpdateDetailsPanel((MediaItem)dataGridView1.Rows[0].Tag);
                else
                    ClearDetailsPanel();
            }
            finally
            {
                _isUpdating = false;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (_isUpdating) return;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedItem = (MediaItem)dataGridView1.SelectedRows[0].Tag;
                UpdateDetailsPanel(selectedItem);
            }
        }

        private void UpdateDetailsPanel(MediaItem item)
        {
            if (item == null) return;
            lblTitleInfo.Text = $"Название: {item.Title}";
            lblGenreInfo.Text = $"Жанр: {item.Genre}";
            lblRatingInfo.Text = $"Рейтинг: {item.Rating}/5";
            rtbDescription.Text = item.Description;

            if (!string.IsNullOrEmpty(item.ImagePath) && File.Exists(item.ImagePath))
            {
                try
                {
                    pbCover.Image = Image.FromFile(item.ImagePath);
                }
                catch
                {
                    pbCover.Image = null;
                }
            }
            else
            {
                pbCover.Image = null;
            }
        }

        private void ClearDetailsPanel()
        {
            lblTitleInfo.Text = "Выберите элемент";
            lblGenreInfo.Text = "-";
            lblRatingInfo.Text = "-";
            rtbDescription.Clear();
            pbCover.Image = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (AddEditForm addForm = new AddEditForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    manager.AddItem(addForm.Item);
                    UpdateGrid();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedItem = (MediaItem)dataGridView1.SelectedRows[0].Tag;
                using (AddEditForm editForm = new AddEditForm(selectedItem))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        UpdateGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку для редактирования.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedItem = (MediaItem)dataGridView1.SelectedRows[0].Tag;
                if (MessageBox.Show($"Удалить '{selectedItem.Title}'?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    manager.RemoveItem(selectedItem.Id);
                    UpdateGrid();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StorageService.Save(manager.Items);
            MessageBox.Show("Данные успешно сохранены в library.json", "Успех");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }

        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}