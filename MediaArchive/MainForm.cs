namespace MediaArchive
{
    public partial class MainForm : Form
    {
        private LibraryManager manager = new LibraryManager();
        public MainForm()
        {
            InitializeComponent();

            manager.Items = StorageService.Load();
            cmbGenreFilter.SelectedIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            UpdateGrid(manager.Items);
        }

        private void UpdateGrid(List<MediaItem> items)
        {
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedItem = (MediaItem)dataGridView1.SelectedRows[0].Tag;
                UpdateDetailsPanel(selectedItem);
            }
        }

        private void UpdateDetailsPanel(MediaItem item)
        {
            lblTitleInfo.Text = $"Название: {item.Title}";
            lblGenreInfo.Text = $"Жанр: {item.Genre}";
            lblRatingInfo.Text = $"Рейтинг: {item.Rating}/5";
            rtbDescription.Text = item.Description;
        }

        private void ClearDetailsPanel()
        {
            lblTitleInfo.Text = "Выберите элемент";
            lblGenreInfo.Text = "-";
            lblRatingInfo.Text = "-";
            rtbDescription.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (AddEditForm addForm = new AddEditForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    manager.AddItem(addForm.Item);
                    UpdateGrid(manager.Items);
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
                        UpdateGrid(manager.Items);
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
                var confirm = MessageBox.Show($"Удалить '{selectedItem.Title}'?", "Подтверждение", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    manager.RemoveItem(selectedItem.Id);
                    UpdateGrid(manager.Items);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StorageService.Save(manager.Items);
            MessageBox.Show("Данные успешно сохранены в library.json", "Успех");
        }
    }
}
